using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = null;
});

var app = builder.Build();
var connectionString = Environment.GetEnvironmentVariable("JET2HOLIDAY_CONNECTION_STRING")
    ?? "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Jet2HolidaySQLdb;Persist Security Info=True;User ID=Jet2HolidaySQLUser;Password=legyen5os@;Trust Server Certificate=True";
var hotcakesBaseUrl = builder.Configuration["Hotcakes:BaseUrl"]
    ?? throw new InvalidOperationException("Missing Hotcakes BaseUrl.");
var hotcakesApiKey = builder.Configuration["Hotcakes:ApiKey"]
    ?? throw new InvalidOperationException("Missing Hotcakes ApiKey.");
var hotcakes = new HotcakesRestClient(hotcakesBaseUrl, hotcakesApiKey);

app.MapGet("/api/health", () => Results.Ok("OK"));

app.MapGet("/api/users", async (bool hasBookings, string? filter) =>
{
    var sql = """
        SELECT UserID, Username, FirstName, LastName, IsSuperUser, AffiliateId, Email, DisplayName,
               UpdatePassword, LastIPAddress, IsDeleted, CreatedByUserID, CreatedOnDate,
               LastModifiedByUserID, LastModifiedOnDate, PasswordResetToken, PasswordResetExpiration
        FROM dbo.Users u
        WHERE (@hasBookings = 0 OR EXISTS (SELECT 1 FROM dbo.Foglalas f WHERE f.UserID = u.UserID))
          AND (@filter IS NULL OR u.DisplayName LIKE '%' + @filter + '%')
        ORDER BY u.DisplayName
        """;

    return Results.Ok(await QueryAsync(connectionString, sql, ReadUser,
        Param("@hasBookings", hasBookings), Param("@filter", filter)));
});

app.MapGet("/api/users/{userId:int}/phone", async (int userId, string? email) =>
{
    if (string.IsNullOrWhiteSpace(email))
    {
        return Results.Text(string.Empty);
    }

    var sql = """
        SELECT TOP (1) a.Phone
        FROM dbo.hcc_User hu
        JOIN dbo.hcc_Address a ON a.UserBvin = hu.Bvin
        WHERE hu.Email = @email AND a.Phone <> ''
        ORDER BY a.LastUpdated DESC
        """;

    var phone = await ScalarAsync<string?>(connectionString, sql, Param("@email", email));
    if (!string.IsNullOrWhiteSpace(phone))
    {
        return Results.Text(phone);
    }

    sql = """
        SELECT TOP (1) Phones
        FROM dbo.hcc_User
        WHERE Email = @email AND Phones <> ''
        """;

    return Results.Text(await ScalarAsync<string?>(connectionString, sql, Param("@email", email)) ?? string.Empty);
});

app.MapGet("/api/foglalas", async (int userId, string? status) =>
{
    var sql = """
        SELECT FoglalasId, UserID, ProductBvin, Telefon, Lokacio, ErkezesDatum, TavozasDatum,
               VendegSzam, LetrehozasDatuma, Status, IsCancelled, CancellationReason,
               LastModifiedDate, HandledByUserId, BookingReference, EjszakakSzama, OrderBvin, Nev, Email
        FROM dbo.Foglalas
        WHERE UserID = @userId
          AND (@status IS NULL OR Status = @status)
        ORDER BY FoglalasId
        """;

    return Results.Ok(await QueryAsync(connectionString, sql, ReadFoglalas,
        Param("@userId", userId), Param("@status", status)));
});

async Task<IResult> GetAllFoglalasJsonAsync(string? key)
{
    if (!string.Equals(key, hotcakesApiKey, StringComparison.Ordinal))
    {
        return Results.Unauthorized();
    }

    var sql = """
        SELECT FoglalasId, UserID, ProductBvin, Telefon, Lokacio, ErkezesDatum, TavozasDatum,
               VendegSzam, LetrehozasDatuma, Status, IsCancelled, CancellationReason,
               LastModifiedDate, HandledByUserId, BookingReference, EjszakakSzama, OrderBvin, Nev, Email
        FROM dbo.Foglalas
        ORDER BY FoglalasId
        """;

    var foglalasok = await QueryAsync(connectionString, sql, ReadFoglalas);
    return Results.Ok(new { Content = foglalasok });
}

app.MapGet("/api/foglalas/all", GetAllFoglalasJsonAsync);
app.MapGet("/DesktopModules/Hotcakes/API/rest/v1/foglalas", GetAllFoglalasJsonAsync);

app.MapGet("/api/foglalas/next-reference", async () =>
{
    var year = DateTime.Now.Year;
    var prefix = $"JH-{year}-";
    var sql = """
        SELECT MAX(TRY_CONVERT(int, RIGHT(BookingReference, 6)))
        FROM dbo.Foglalas
        WHERE BookingReference LIKE @prefix + '%'
        """;

    var lastNumber = await ScalarAsync<int?>(connectionString, sql, Param("@prefix", prefix)) ?? 0;
    return Results.Text($"{prefix}{lastNumber + 1:000000}");
});

app.MapPost("/api/foglalas", async (Foglala foglalas) =>
{
    var sql = """
        INSERT INTO dbo.Foglalas
        (UserID, ProductBvin, Telefon, Lokacio, ErkezesDatum, TavozasDatum, VendegSzam,
         LetrehozasDatuma, Status, IsCancelled, CancellationReason, LastModifiedDate,
         HandledByUserId, BookingReference, OrderBvin, Nev, Email)
        OUTPUT INSERTED.FoglalasId
        VALUES
        (@UserId, @ProductBvin, @Telefon, @Lokacio, @ErkezesDatum, @TavozasDatum, @VendegSzam,
         @LetrehozasDatuma, @Status, @IsCancelled, @CancellationReason, @LastModifiedDate,
         @HandledByUserId, @BookingReference, @OrderBvin, @Nev, @Email)
        """;

    foglalas.FoglalasId = await ScalarAsync<int>(connectionString, sql, FoglalasParams(foglalas));
    return Results.Created($"/api/foglalas/{foglalas.FoglalasId}", foglalas);
});

app.MapPut("/api/foglalas/{id:int}", async (int id, Foglala foglalas) =>
{
    foglalas.FoglalasId = id;
    var sql = """
        UPDATE dbo.Foglalas SET
            UserID = @UserId, ProductBvin = @ProductBvin, Telefon = @Telefon, Lokacio = @Lokacio,
            ErkezesDatum = @ErkezesDatum, TavozasDatum = @TavozasDatum, VendegSzam = @VendegSzam,
            LetrehozasDatuma = @LetrehozasDatuma, Status = @Status, IsCancelled = @IsCancelled,
            CancellationReason = @CancellationReason, LastModifiedDate = @LastModifiedDate,
            HandledByUserId = @HandledByUserId, BookingReference = @BookingReference,
            OrderBvin = @OrderBvin, Nev = @Nev, Email = @Email
        WHERE FoglalasId = @FoglalasId
        """;

    var rows = await ExecuteAsync(connectionString, sql, FoglalasParams(foglalas).Append(Param("@FoglalasId", id)).ToArray());
    return rows == 0 ? Results.NotFound() : Results.NoContent();
});

app.MapDelete("/api/foglalas/{id:int}", async (int id) =>
{
    var rows = await ExecuteAsync(connectionString, "DELETE FROM dbo.Foglalas WHERE FoglalasId = @id", Param("@id", id));
    return rows == 0 ? Results.NotFound() : Results.NoContent();
});

app.MapGet("/api/orders", async (string? filter) =>
{
    return Results.Ok(await hotcakes.GetOrdersAsync(filter));
});

app.MapGet("/api/products", async (string? filter) =>
{
    return Results.Ok(await hotcakes.GetProductsAsync(filter));
});

app.MapGet("/api/lineitems", async (string? productIds, Guid? orderBvin) =>
{
    var ids = (productIds ?? string.Empty)
        .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
        .Select(id => Guid.TryParse(id, out var parsed) ? parsed : Guid.Empty)
        .Where(id => id != Guid.Empty)
        .ToHashSet();

    var sql = """
        SELECT Id, LastUpdated, ProductId, Quantity, OrderBvin, LineTotal,
               ProductName, ProductSku, StatusCode, StatusName, StoreId
        FROM dbo.hcc_LineItem
        WHERE (@orderBvin IS NULL OR OrderBvin = @orderBvin)
          AND (@hasProductIds = 0 OR ProductId IN (SELECT TRY_CONVERT(uniqueidentifier, value) FROM STRING_SPLIT(@productIds, ',')))
          AND ProductName <> ''
        ORDER BY LastUpdated DESC
        """;

    return Results.Ok(await QueryAsync(connectionString, sql, ReadLineItem,
        Param("@orderBvin", orderBvin),
        Param("@hasProductIds", ids.Count > 0),
        Param("@productIds", string.Join(',', ids))));
});
app.Run();

static SqlParameter Param(string name, object? value) => new(name, value ?? DBNull.Value);

static SqlParameter[] FoglalasParams(Foglala f) =>
[
    Param("@UserId", f.UserId),
    Param("@ProductBvin", f.ProductBvin),
    Param("@Telefon", f.Telefon),
    Param("@Lokacio", f.Lokacio),
    Param("@ErkezesDatum", f.ErkezesDatum.ToDateTime(TimeOnly.MinValue)),
    Param("@TavozasDatum", f.TavozasDatum.ToDateTime(TimeOnly.MinValue)),
    Param("@VendegSzam", f.VendegSzam),
    Param("@LetrehozasDatuma", f.LetrehozasDatuma),
    Param("@Status", f.Status),
    Param("@IsCancelled", f.IsCancelled),
    Param("@CancellationReason", f.CancellationReason),
    Param("@LastModifiedDate", f.LastModifiedDate),
    Param("@HandledByUserId", f.HandledByUserId),
    Param("@BookingReference", f.BookingReference),
    Param("@OrderBvin", f.OrderBvin),
    Param("@Nev", f.Nev),
    Param("@Email", f.Email)
];

static async Task<List<T>> QueryAsync<T>(string cs, string sql, Func<SqlDataReader, T> read, params SqlParameter[] parameters)
{
    await using var connection = new SqlConnection(cs);
    await using var command = new SqlCommand(sql, connection);
    command.Parameters.AddRange(parameters);
    await connection.OpenAsync();
    await using var reader = await command.ExecuteReaderAsync();
    var result = new List<T>();
    while (await reader.ReadAsync())
    {
        result.Add(read(reader));
    }

    return result;
}

static async Task<T?> ScalarAsync<T>(string cs, string sql, params SqlParameter[] parameters)
{
    await using var connection = new SqlConnection(cs);
    await using var command = new SqlCommand(sql, connection);
    command.Parameters.AddRange(parameters);
    await connection.OpenAsync();
    var value = await command.ExecuteScalarAsync();
    return value == null || value == DBNull.Value ? default : (T)value;
}

static async Task<int> ExecuteAsync(string cs, string sql, params SqlParameter[] parameters)
{
    await using var connection = new SqlConnection(cs);
    await using var command = new SqlCommand(sql, connection);
    command.Parameters.AddRange(parameters);
    await connection.OpenAsync();
    return await command.ExecuteNonQueryAsync();
}

static string S(SqlDataReader r, string name) => r[name] == DBNull.Value ? string.Empty : (string)r[name];
static string? SN(SqlDataReader r, string name) => r[name] == DBNull.Value ? null : (string)r[name];
static int IN(SqlDataReader r, string name) => (int)r[name];
static int? INull(SqlDataReader r, string name) => r[name] == DBNull.Value ? null : (int)r[name];
static long L(SqlDataReader r, string name) => (long)r[name];
static decimal D(SqlDataReader r, string name) => (decimal)r[name];
static decimal? DNull(SqlDataReader r, string name) => r[name] == DBNull.Value ? null : (decimal)r[name];
static DateTime DT(SqlDataReader r, string name) => (DateTime)r[name];
static DateTime? DTN(SqlDataReader r, string name) => r[name] == DBNull.Value ? null : (DateTime)r[name];
static Guid G(SqlDataReader r, string name) => (Guid)r[name];
static Guid? GN(SqlDataReader r, string name) => r[name] == DBNull.Value ? null : (Guid)r[name];
static bool B(SqlDataReader r, string name) => (bool)r[name];
static DateOnly DO(SqlDataReader r, string name) => DateOnly.FromDateTime((DateTime)r[name]);

static User ReadUser(SqlDataReader r) => new()
{
    UserId = IN(r, "UserID"),
    Username = S(r, "Username"),
    FirstName = S(r, "FirstName"),
    LastName = S(r, "LastName"),
    IsSuperUser = B(r, "IsSuperUser"),
    AffiliateId = INull(r, "AffiliateId"),
    Email = SN(r, "Email"),
    DisplayName = S(r, "DisplayName"),
    UpdatePassword = B(r, "UpdatePassword"),
    LastIpaddress = SN(r, "LastIPAddress"),
    IsDeleted = B(r, "IsDeleted"),
    CreatedByUserId = INull(r, "CreatedByUserID"),
    CreatedOnDate = DTN(r, "CreatedOnDate"),
    LastModifiedByUserId = INull(r, "LastModifiedByUserID"),
    LastModifiedOnDate = DTN(r, "LastModifiedOnDate"),
    PasswordResetToken = GN(r, "PasswordResetToken"),
    PasswordResetExpiration = DTN(r, "PasswordResetExpiration")
};

static Foglala ReadFoglalas(SqlDataReader r) => new()
{
    FoglalasId = IN(r, "FoglalasId"),
    UserId = IN(r, "UserID"),
    ProductBvin = G(r, "ProductBvin"),
    Telefon = SN(r, "Telefon"),
    Lokacio = S(r, "Lokacio"),
    ErkezesDatum = DO(r, "ErkezesDatum"),
    TavozasDatum = DO(r, "TavozasDatum"),
    VendegSzam = INull(r, "VendegSzam"),
    LetrehozasDatuma = DTN(r, "LetrehozasDatuma"),
    Status = S(r, "Status"),
    IsCancelled = B(r, "IsCancelled"),
    CancellationReason = SN(r, "CancellationReason"),
    LastModifiedDate = DTN(r, "LastModifiedDate"),
    HandledByUserId = INull(r, "HandledByUserId"),
    BookingReference = SN(r, "BookingReference"),
    EjszakakSzama = INull(r, "EjszakakSzama"),
    OrderBvin = GN(r, "OrderBvin"),
    Nev = S(r, "Nev"),
    Email = S(r, "Email")
};

static HccOrder ReadOrder(SqlDataReader r) => new()
{
    Id = IN(r, "Id"),
    Bvin = G(r, "Bvin"),
    CustomProperties = S(r, "CustomProperties"),
    LastUpdated = DT(r, "LastUpdated"),
    OrderNumber = S(r, "OrderNumber"),
    TimeOfOrder = DT(r, "TimeOfOrder"),
    UserEmail = S(r, "UserEmail"),
    UserId = S(r, "UserID"),
    StatusCode = S(r, "StatusCode"),
    StatusName = S(r, "StatusName"),
    GrandTotal = D(r, "GrandTotal")
};

static HccProduct ReadProduct(SqlDataReader r) => new()
{
    Id = L(r, "Id"),
    Bvin = G(r, "Bvin"),
    Sku = S(r, "Sku"),
    ListPrice = D(r, "ListPrice"),
    SitePrice = DNull(r, "SitePrice"),
    CreationDate = DT(r, "CreationDate"),
    LastUpdated = DT(r, "LastUpdated"),
    RewriteUrl = S(r, "RewriteUrl"),
    StoreId = L(r, "StoreId"),
    IsAvailableForSale = B(r, "IsAvailableForSale")
};

static HccLineItem ReadLineItem(SqlDataReader r) => new()
{
    Id = L(r, "Id"),
    LastUpdated = DT(r, "LastUpdated"),
    ProductId = G(r, "ProductId"),
    Quantity = IN(r, "Quantity"),
    OrderBvin = G(r, "OrderBvin"),
    LineTotal = D(r, "LineTotal"),
    ProductName = S(r, "ProductName"),
    ProductSku = S(r, "ProductSku"),
    StatusCode = S(r, "StatusCode"),
    StatusName = S(r, "StatusName"),
    StoreId = L(r, "StoreId")
};

sealed class HotcakesRestClient
{
    private readonly HttpClient httpClient = new();
    private readonly string baseUrl;
    private readonly string apiKey;

    public HotcakesRestClient(string baseUrl, string apiKey)
    {
        this.baseUrl = baseUrl.TrimEnd('/') + "/";
        this.apiKey = apiKey;
    }

    public async Task<List<HccOrder>> GetOrdersAsync(string? filter)
    {
        using var document = await GetDocumentAsync("orders");
        return ReadContentArray(document.RootElement)
            .Select(ReadHotcakesOrder)
            .Where(order => string.IsNullOrWhiteSpace(filter)
                || order.Bvin.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)
                || order.OrderNumber.Contains(filter, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(order => order.TimeOfOrder)
            .Take(500)
            .ToList();
    }

    public async Task<List<HccProduct>> GetProductsAsync(string? filter)
    {
        using var document = await GetDocumentAsync("products");
        return ReadContentArray(document.RootElement)
            .Select(ReadHotcakesProduct)
            .Where(product => string.IsNullOrWhiteSpace(filter)
                || product.Bvin.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)
                || product.Sku.Contains(filter, StringComparison.OrdinalIgnoreCase))
            .OrderBy(product => product.Sku)
            .Take(500)
            .ToList();
    }

    public async Task<List<HccLineItem>> GetLineItemsAsync(HashSet<Guid> productIds, Guid? orderBvin)
    {
        var orders = await GetOrdersAsync(null);
        var selectedOrders = orderBvin.HasValue
            ? orders.Where(order => order.Bvin == orderBvin.Value).ToList()
            : orders;

        var result = new List<HccLineItem>();
        foreach (var order in selectedOrders)
        {
            using var document = await GetDocumentAsync("orders/" + order.Bvin);
            var orderElement = ReadContentElement(document.RootElement);
            foreach (var itemElement in ReadLineItemElements(orderElement))
            {
                var item = ReadHotcakesLineItem(itemElement, order.Bvin);
                if (productIds.Count == 0 || productIds.Contains(item.ProductId))
                {
                    result.Add(item);
                }
            }
        }

        return result
            .OrderByDescending(item => item.LastUpdated)
            .Take(1000)
            .ToList();
    }

    private async Task<JsonDocument> GetDocumentAsync(string relativePath)
    {
        var separator = relativePath.Contains('?') ? "&" : "?";
        var url = baseUrl + relativePath.TrimStart('/') + separator + "key=" + Uri.EscapeDataString(apiKey);
        using var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        await using var stream = await response.Content.ReadAsStreamAsync();
        return await JsonDocument.ParseAsync(stream);
    }

    private static IEnumerable<JsonElement> ReadContentArray(JsonElement root)
    {
        var content = ReadContentElement(root);
        if (content.ValueKind == JsonValueKind.Array)
        {
            return content.EnumerateArray();
        }

        if (content.ValueKind == JsonValueKind.Object)
        {
            foreach (var name in new[] { "Items", "items", "List", "list" })
            {
                if (content.TryGetProperty(name, out var items) && items.ValueKind == JsonValueKind.Array)
                {
                    return items.EnumerateArray();
                }
            }
        }

        return Enumerable.Empty<JsonElement>();
    }

    private static JsonElement ReadContentElement(JsonElement root)
    {
        if (root.ValueKind == JsonValueKind.Object)
        {
            foreach (var name in new[] { "Content", "content", "Result", "result" })
            {
                if (root.TryGetProperty(name, out var content))
                {
                    return content;
                }
            }
        }

        return root;
    }

    private static IEnumerable<JsonElement> ReadLineItemElements(JsonElement orderElement)
    {
        foreach (var name in new[] { "Items", "items", "LineItems", "lineItems" })
        {
            if (orderElement.ValueKind == JsonValueKind.Object &&
                orderElement.TryGetProperty(name, out var items) &&
                items.ValueKind == JsonValueKind.Array)
            {
                return items.EnumerateArray();
            }
        }

        return Enumerable.Empty<JsonElement>();
    }

    private static HccOrder ReadHotcakesOrder(JsonElement element) => new()
    {
        Id = GetInt(element, "Id", "id"),
        Bvin = GetGuid(element, "Bvin", "bvin"),
        CustomProperties = GetRawOrString(element, "CustomProperties", "customProperties"),
        LastUpdated = GetDateTime(element, "LastUpdated", "lastUpdated"),
        OrderNumber = GetString(element, "OrderNumber", "orderNumber"),
        TimeOfOrder = GetDateTime(element, "TimeOfOrder", "timeOfOrder"),
        UserEmail = GetString(element, "UserEmail", "userEmail"),
        UserId = GetString(element, "UserId", "UserID", "userId"),
        StatusCode = GetString(element, "StatusCode", "statusCode"),
        StatusName = GetString(element, "StatusName", "statusName"),
        GrandTotal = GetDecimal(element, "GrandTotal", "grandTotal")
    };

    private static HccProduct ReadHotcakesProduct(JsonElement element) => new()
    {
        Id = GetLong(element, "Id", "id"),
        Bvin = GetGuid(element, "Bvin", "bvin"),
        Sku = GetString(element, "Sku", "sku"),
        ListPrice = GetDecimal(element, "ListPrice", "listPrice"),
        SitePrice = GetNullableDecimal(element, "SitePrice", "sitePrice"),
        CreationDate = GetDateTime(element, "CreationDate", "creationDate"),
        LastUpdated = GetDateTime(element, "LastUpdated", "lastUpdated"),
        RewriteUrl = GetString(element, "RewriteUrl", "rewriteUrl"),
        StoreId = GetLong(element, "StoreId", "storeId"),
        IsAvailableForSale = GetBool(element, "IsAvailableForSale", "isAvailableForSale")
    };

    private static HccLineItem ReadHotcakesLineItem(JsonElement element, Guid orderBvin) => new()
    {
        Id = GetLong(element, "Id", "id"),
        LastUpdated = GetDateTime(element, "LastUpdated", "lastUpdated"),
        ProductId = GetGuid(element, "ProductId", "productId", "ProductBvin", "productBvin"),
        Quantity = GetInt(element, "Quantity", "quantity"),
        OrderBvin = orderBvin,
        LineTotal = GetDecimal(element, "LineTotal", "lineTotal"),
        ProductName = GetString(element, "ProductName", "productName"),
        ProductSku = GetString(element, "ProductSku", "productSku"),
        StatusCode = GetString(element, "StatusCode", "statusCode"),
        StatusName = GetString(element, "StatusName", "statusName"),
        StoreId = GetLong(element, "StoreId", "storeId")
    };

    private static JsonElement? Find(JsonElement element, params string[] names)
    {
        if (element.ValueKind != JsonValueKind.Object)
        {
            return null;
        }

        foreach (var name in names)
        {
            if (element.TryGetProperty(name, out var value))
            {
                return value;
            }
        }

        foreach (var property in element.EnumerateObject())
        {
            if (names.Any(name => string.Equals(name, property.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return property.Value;
            }
        }

        return null;
    }

    private static string GetString(JsonElement element, params string[] names)
        => Find(element, names)?.ToString() ?? string.Empty;

    private static string GetRawOrString(JsonElement element, params string[] names)
    {
        var value = Find(element, names);
        return value.HasValue ? value.Value.ToString() : string.Empty;
    }

    private static Guid GetGuid(JsonElement element, params string[] names)
        => Guid.TryParse(GetString(element, names), out var value) ? value : Guid.Empty;

    private static int GetInt(JsonElement element, params string[] names)
        => int.TryParse(GetString(element, names), out var value) ? value : 0;

    private static long GetLong(JsonElement element, params string[] names)
        => long.TryParse(GetString(element, names), out var value) ? value : 0;

    private static decimal GetDecimal(JsonElement element, params string[] names)
        => decimal.TryParse(GetString(element, names), out var value) ? value : 0m;

    private static decimal? GetNullableDecimal(JsonElement element, params string[] names)
        => decimal.TryParse(GetString(element, names), out var value) ? value : null;

    private static bool GetBool(JsonElement element, params string[] names)
        => bool.TryParse(GetString(element, names), out var value) && value;

    private static DateTime GetDateTime(JsonElement element, params string[] names)
        => DateTime.TryParse(GetString(element, names), out var value) ? value : DateTime.MinValue;
}

public class Foglala
{
    public int FoglalasId { get; set; }
    public int UserId { get; set; }
    public Guid ProductBvin { get; set; }
    public string? Telefon { get; set; }
    public string Lokacio { get; set; } = string.Empty;
    public DateOnly ErkezesDatum { get; set; }
    public DateOnly TavozasDatum { get; set; }
    public int? VendegSzam { get; set; }
    public DateTime? LetrehozasDatuma { get; set; }
    public string Status { get; set; } = string.Empty;
    public bool IsCancelled { get; set; }
    public string? CancellationReason { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public int? HandledByUserId { get; set; }
    public string? BookingReference { get; set; }
    public int? EjszakakSzama { get; set; }
    public Guid? OrderBvin { get; set; }
    public string Nev { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public bool IsSuperUser { get; set; }
    public int? AffiliateId { get; set; }
    public string? Email { get; set; }
    public string DisplayName { get; set; } = string.Empty;
    public bool UpdatePassword { get; set; }
    public string? LastIpaddress { get; set; }
    public bool IsDeleted { get; set; }
    public int? CreatedByUserId { get; set; }
    public DateTime? CreatedOnDate { get; set; }
    public int? LastModifiedByUserId { get; set; }
    public DateTime? LastModifiedOnDate { get; set; }
    public Guid? PasswordResetToken { get; set; }
    public DateTime? PasswordResetExpiration { get; set; }
}

public class HccOrder
{
    public int Id { get; set; }
    public Guid Bvin { get; set; }
    public string CustomProperties { get; set; } = string.Empty;
    public DateTime LastUpdated { get; set; }
    public string OrderNumber { get; set; } = string.Empty;
    public DateTime TimeOfOrder { get; set; }
    public string UserEmail { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
    public string StatusCode { get; set; } = string.Empty;
    public string StatusName { get; set; } = string.Empty;
    public decimal GrandTotal { get; set; }
}

public class HccProduct
{
    public long Id { get; set; }
    public Guid Bvin { get; set; }
    public string Sku { get; set; } = string.Empty;
    public decimal ListPrice { get; set; }
    public decimal? SitePrice { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastUpdated { get; set; }
    public string RewriteUrl { get; set; } = string.Empty;
    public long StoreId { get; set; }
    public bool IsAvailableForSale { get; set; }
}

public class HccLineItem
{
    public long Id { get; set; }
    public DateTime LastUpdated { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public Guid OrderBvin { get; set; }
    public decimal LineTotal { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string ProductSku { get; set; } = string.Empty;
    public string StatusCode { get; set; } = string.Empty;
    public string StatusName { get; set; } = string.Empty;
    public long StoreId { get; set; }
}
