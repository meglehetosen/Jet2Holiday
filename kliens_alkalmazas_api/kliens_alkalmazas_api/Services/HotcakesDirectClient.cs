using System.Text.Json;
using kliens_alkalmazas_api.Models;

namespace kliens_alkalmazas_api.Services;

public sealed class HotcakesDirectClient
{
    private const string BaseUrl = "http://20.67.251.10/DesktopModules/Hotcakes/API/rest/v1/";
    private const string ApiKey = "1-16c0cacd-f831-467a-8800-772f2b69967c";
    private static readonly HttpClient HttpClient = new()
    {
        Timeout = TimeSpan.FromSeconds(10)
    };

    public async Task<List<User>> GetUsersAsync(string? filter = null)
    {
        var orders = await GetOrdersAsync();
        return orders
            .Where(order => int.TryParse(order.UserId, out _))
            .GroupBy(order => order.UserId)
            .Select(group =>
            {
                var order = group.First();
                return new User
                {
                    UserId = int.Parse(order.UserId),
                    Username = order.UserEmail,
                    Email = order.UserEmail,
                    DisplayName = order.UserEmail,
                    FirstName = string.Empty,
                    LastName = string.Empty
                };
            })
            .Where(user => string.IsNullOrWhiteSpace(filter)
                || user.DisplayName.Contains(filter, StringComparison.OrdinalIgnoreCase)
                || (user.Email?.Contains(filter, StringComparison.OrdinalIgnoreCase) ?? false))
            .OrderBy(user => user.DisplayName)
            .ToList();
    }

    public async Task<List<Foglala>> GetFoglalasAsync(int userId, string? status)
    {
        var orders = (await GetOrdersAsync())
            .Where(order => string.Equals(order.UserId, userId.ToString(), StringComparison.OrdinalIgnoreCase))
            .ToList();

        var foglalasok = new List<Foglala>();
        foreach (var order in orders)
        {
            var foglalas = await BuildFoglalasFromOrderAsync(order);
            if (foglalas != null &&
                (string.IsNullOrWhiteSpace(status) ||
                 string.Equals(status, "All", StringComparison.OrdinalIgnoreCase) ||
                 string.Equals(foglalas.Status, status, StringComparison.OrdinalIgnoreCase)))
            {
                foglalasok.Add(foglalas);
            }
        }

        return foglalasok.OrderBy(foglalas => foglalas.FoglalasId).ToList();
    }

    public async Task<List<HccOrder>> GetOrdersAsync(string? filter = null)
    {
        using var document = await GetDocumentAsync("orders");
        return ReadContentArray(document.RootElement)
            .Select(ReadOrder)
            .Where(order => string.IsNullOrWhiteSpace(filter)
                || order.Bvin.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)
                || order.OrderNumber.Contains(filter, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(order => order.TimeOfOrder)
            .Take(500)
            .ToList();
    }

    public async Task<List<HccProduct>> GetProductsAsync(string? filter = null)
    {
        using var document = await GetDocumentAsync("products");
        return ReadContentArray(document.RootElement)
            .Select(ReadProduct)
            .Where(product => string.IsNullOrWhiteSpace(filter)
                || product.Bvin.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)
                || product.Sku.Contains(filter, StringComparison.OrdinalIgnoreCase))
            .OrderBy(product => product.Sku)
            .Take(500)
            .ToList();
    }

    public async Task<List<HccLineItem>> GetLineItemsByProductIdsAsync(IEnumerable<Guid> productIds)
    {
        var ids = productIds.Where(id => id != Guid.Empty).ToHashSet();
        if (ids.Count == 0)
        {
            return new List<HccLineItem>();
        }

        var result = new List<HccLineItem>();
        foreach (var order in await GetOrdersAsync())
        {
            result.AddRange(await GetLineItemsForOrderAsync(order.Bvin, ids));
        }

        return result;
    }

    public async Task<HccLineItem?> GetFirstLineItemForOrderAsync(Guid orderBvin)
        => (await GetLineItemsForOrderAsync(orderBvin, null)).OrderBy(item => item.Id).FirstOrDefault();

    public async Task<BookingOrderDetails?> GetBookingOrderDetailsAsync(Guid orderBvin)
    {
        using var document = await GetDocumentAsync("orders/" + orderBvin);
        var orderElement = ReadContentElement(document.RootElement);
        var firstItemElement = ReadLineItemElements(orderElement).FirstOrDefault();
        if (firstItemElement.ValueKind == JsonValueKind.Undefined)
        {
            return null;
        }

        var firstItem = ReadLineItem(firstItemElement, orderBvin);
        var orderProperties = ReadCustomProperties(orderElement);
        var itemProperties = ReadCustomProperties(firstItemElement);

        var erkezes = ReadDateOnly(orderProperties, "checkInUtc")
            ?? ReadDateOnly(itemProperties, "checkInUtc");
        var tavozas = ReadDateOnly(orderProperties, "checkOutUtc")
            ?? ReadDateOnly(itemProperties, "checkOutUtc");
        var vendegSzam = ReadInt(orderProperties, "guestCount")
            ?? ReadInt(itemProperties, "guestCount");
        var ejszakak = erkezes.HasValue && tavozas.HasValue
            ? Math.Max(1, tavozas.Value.DayNumber - erkezes.Value.DayNumber)
            : (int?)null;

        return new BookingOrderDetails
        {
            OrderBvin = orderBvin,
            ProductBvin = firstItem.ProductId,
            ProductName = firstItem.ProductName,
            ProductSku = firstItem.ProductSku,
            Lokacio = GetLocationBySku(firstItem.ProductSku) ?? firstItem.ProductSku,
            ErkezesDatum = erkezes,
            TavozasDatum = tavozas,
            VendegSzam = vendegSzam,
            EjszakakSzama = ejszakak
        };
    }

    private async Task<List<HccLineItem>> GetLineItemsForOrderAsync(Guid orderBvin, HashSet<Guid>? productIds)
    {
        using var document = await GetDocumentAsync("orders/" + orderBvin);
        var orderElement = ReadContentElement(document.RootElement);
        return ReadLineItemElements(orderElement)
            .Select(item => ReadLineItem(item, orderBvin))
            .Where(item => productIds == null || productIds.Contains(item.ProductId))
            .ToList();
    }

    private async Task<Foglala?> BuildFoglalasFromOrderAsync(HccOrder order)
    {
        using var document = await GetDocumentAsync("orders/" + order.Bvin);
        var orderElement = ReadContentElement(document.RootElement);
        var firstItem = ReadLineItemElements(orderElement)
            .Select(item => ReadLineItem(item, order.Bvin))
            .OrderBy(item => item.Id)
            .FirstOrDefault();

        if (firstItem == null || !int.TryParse(order.UserId, out var userId))
        {
            return null;
        }

        var customProperties = ReadCustomProperties(orderElement);
        var itemProperties = ReadCustomProperties(ReadLineItemElements(orderElement).FirstOrDefault());
        var erkezes = ReadDateOnly(customProperties, "checkInUtc")
            ?? ReadDateOnly(itemProperties, "checkInUtc")
            ?? DateOnly.FromDateTime(order.TimeOfOrder);
        var tavozas = ReadDateOnly(customProperties, "checkOutUtc")
            ?? ReadDateOnly(itemProperties, "checkOutUtc")
            ?? erkezes.AddDays(1);
        var guestCount = ReadInt(customProperties, "guestCount")
            ?? ReadInt(itemProperties, "guestCount");

        return new Foglala
        {
            FoglalasId = order.Id,
            UserId = userId,
            ProductBvin = firstItem.ProductId,
            Lokacio = GetLocationBySku(firstItem.ProductSku) ?? firstItem.ProductSku,
            ErkezesDatum = erkezes,
            TavozasDatum = tavozas,
            VendegSzam = guestCount,
            LetrehozasDatuma = order.TimeOfOrder,
            Status = string.IsNullOrWhiteSpace(order.StatusName) ? "Pending" : order.StatusName,
            IsCancelled = string.Equals(order.StatusName, "Cancelled", StringComparison.OrdinalIgnoreCase),
            BookingReference = "HC-" + order.OrderNumber,
            EjszakakSzama = Math.Max(1, tavozas.DayNumber - erkezes.DayNumber),
            OrderBvin = order.Bvin,
            Nev = order.UserEmail,
            Email = order.UserEmail
        };
    }

    private static async Task<JsonDocument> GetDocumentAsync(string relativePath)
    {
        var separator = relativePath.Contains('?') ? "&" : "?";
        var url = BaseUrl + relativePath.TrimStart('/') + separator + "key=" + Uri.EscapeDataString(ApiKey);
        using var response = await HttpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        await using var stream = await response.Content.ReadAsStreamAsync();
        return await JsonDocument.ParseAsync(stream);
    }

    private static IEnumerable<JsonElement> ReadContentArray(JsonElement root)
    {
        var content = ReadContentElement(root);
        return content.ValueKind == JsonValueKind.Array
            ? content.EnumerateArray()
            : Enumerable.Empty<JsonElement>();
    }

    private static JsonElement ReadContentElement(JsonElement root)
    {
        if (root.ValueKind != JsonValueKind.Object)
        {
            return root;
        }

        foreach (var name in new[] { "Content", "content", "Products", "products", "Result", "result" })
        {
            if (root.TryGetProperty(name, out var content))
            {
                return content;
            }
        }

        return root;
    }

    private static IEnumerable<JsonElement> ReadLineItemElements(JsonElement orderElement)
    {
        if (orderElement.ValueKind != JsonValueKind.Object)
        {
            return Enumerable.Empty<JsonElement>();
        }

        foreach (var name in new[] { "Items", "items", "LineItems", "lineItems" })
        {
            if (orderElement.TryGetProperty(name, out var items) && items.ValueKind == JsonValueKind.Array)
            {
                return items.EnumerateArray();
            }
        }

        return Enumerable.Empty<JsonElement>();
    }

    private static HccOrder ReadOrder(JsonElement element) => new()
    {
        Id = GetInt(element, "Id", "id"),
        Bvin = GetGuid(element, "Bvin", "bvin"),
        CustomProperties = GetString(element, "CustomProperties", "customProperties"),
        LastUpdated = GetDateTime(element, "LastUpdated", "lastUpdated", "LastUpdatedUtc", "lastUpdatedUtc"),
        OrderNumber = GetString(element, "OrderNumber", "orderNumber"),
        TimeOfOrder = GetDateTime(element, "TimeOfOrder", "timeOfOrder", "TimeOfOrderUtc", "timeOfOrderUtc"),
        UserEmail = GetString(element, "UserEmail", "userEmail"),
        UserId = GetString(element, "UserId", "UserID", "userId"),
        StatusCode = GetString(element, "StatusCode", "statusCode"),
        StatusName = GetString(element, "StatusName", "statusName"),
        GrandTotal = GetDecimal(element, "GrandTotal", "grandTotal")
    };

    private static HccProduct ReadProduct(JsonElement element) => new()
    {
        Id = GetLong(element, "Id", "id"),
        Bvin = GetGuid(element, "Bvin", "bvin"),
        Sku = GetString(element, "Sku", "sku"),
        ProductName = GetString(element, "ProductName", "productName"),
        ListPrice = GetDecimal(element, "ListPrice", "listPrice"),
        SitePrice = GetNullableDecimal(element, "SitePrice", "sitePrice"),
        CreationDate = GetDateTime(element, "CreationDate", "creationDate"),
        LastUpdated = GetDateTime(element, "LastUpdated", "lastUpdated", "LastUpdatedUtc", "lastUpdatedUtc"),
        RewriteUrl = GetString(element, "RewriteUrl", "rewriteUrl"),
        StoreId = GetLong(element, "StoreId", "storeId"),
        IsAvailableForSale = GetBool(element, "IsAvailableForSale", "isAvailableForSale")
    };

    private static HccLineItem ReadLineItem(JsonElement element, Guid orderBvin) => new()
    {
        Id = GetLong(element, "Id", "id"),
        LastUpdated = GetDateTime(element, "LastUpdated", "lastUpdated", "LastUpdatedUtc", "lastUpdatedUtc"),
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

    private static Dictionary<string, string?> ReadCustomProperties(JsonElement orderElement)
    {
        var result = new Dictionary<string, string?>(StringComparer.OrdinalIgnoreCase);
        var properties = Find(orderElement, "CustomProperties", "customProperties");
        if (properties?.ValueKind != JsonValueKind.Array)
        {
            return result;
        }

        foreach (var property in properties.Value.EnumerateArray())
        {
            var key = GetString(property, "Key", "key");
            if (!string.IsNullOrWhiteSpace(key))
            {
                result[key] = GetString(property, "Value", "value");
            }
        }

        return result;
    }

    private static DateOnly? ReadDateOnly(Dictionary<string, string?> properties, string key)
    {
        if (!properties.TryGetValue(key, out var value) || string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        return DateTimeOffset.TryParse(value, out var parsed)
            ? DateOnly.FromDateTime(parsed.UtcDateTime)
            : null;
    }

    private static int? ReadInt(Dictionary<string, string?> properties, string key)
    {
        return properties.TryGetValue(key, out var value) &&
               int.TryParse(value, out var parsed)
            ? parsed
            : null;
    }

    private static string? GetLocationBySku(string? sku)
    {
        if (string.IsNullOrWhiteSpace(sku))
        {
            return null;
        }

        sku = sku.Trim().ToUpperInvariant();
        if (System.Text.RegularExpressions.Regex.IsMatch(sku, @"^MALDIV-\d{3}$"))
        {
            return "Maldiv-szigetek";
        }

        if (System.Text.RegularExpressions.Regex.IsMatch(sku, @"^MILANO\d{2}$"))
        {
            return "Milano";
        }

        if (System.Text.RegularExpressions.Regex.IsMatch(sku, @"^ISZTAMBUL\d{2}$"))
        {
            return "Isztambul";
        }

        return null;
    }

    private static JsonElement? Find(JsonElement element, params string[] names)
    {
        if (element.ValueKind != JsonValueKind.Object)
        {
            return null;
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
    {
        var text = GetString(element, names);
        if (DateTime.TryParse(text, out var value))
        {
            return value;
        }

        var match = System.Text.RegularExpressions.Regex.Match(text, @"Date\((\d+)\)");
        return match.Success && long.TryParse(match.Groups[1].Value, out var milliseconds)
            ? DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).UtcDateTime
            : DateTime.MinValue;
    }
}
