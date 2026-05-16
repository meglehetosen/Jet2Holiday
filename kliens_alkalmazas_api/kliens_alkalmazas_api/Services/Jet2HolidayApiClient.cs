using System.Net.Http.Json;
using System.Diagnostics;
using kliens_alkalmazas_api.Models;

namespace kliens_alkalmazas_api.Services;

public sealed class Jet2HolidayApiClient
{
    private const string HotcakesApiKey = "1-16c0cacd-f831-467a-8800-772f2b69967c";
    private readonly HotcakesDirectClient hotcakes = new();

    private static readonly HttpClient HttpClient = new()
    {
        BaseAddress = new Uri(
            Environment.GetEnvironmentVariable("JET2HOLIDAY_API_BASE_URL")
            ?? "http://20.67.251.10/FoglalasApi/"),
        Timeout = TimeSpan.FromSeconds(5)
    };

    public async Task<List<User>> GetUsersAsync(string? filter = null, bool hasBookings = true)
    {
        try
        {
            await EnsureLocalApiRunningAsync();
            var path = "api/users?hasBookings=" + hasBookings.ToString().ToLowerInvariant();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                path += "&filter=" + Uri.EscapeDataString(filter);
            }

            var users = await GetListAsync<User>(path);
            return users.Count > 0
                ? users
                : await hotcakes.GetUsersAsync(filter);
        }
        catch (Exception)
        {
            return await hotcakes.GetUsersAsync(filter);
        }
    }

    public async Task<List<Foglala>> GetFoglalasAsync(int userId, string? status)
    {
        try
        {
            await EnsureLocalApiRunningAsync();
            var path = "api/foglalas?userId=" + userId;
            if (!string.IsNullOrWhiteSpace(status) && !string.Equals(status, "All", StringComparison.OrdinalIgnoreCase))
            {
                path += "&status=" + Uri.EscapeDataString(status);
            }

            var foglalasok = await GetListAsync<Foglala>(path);
            return foglalasok.Count > 0
                ? foglalasok
                : await hotcakes.GetFoglalasAsync(userId, status);
        }
        catch (Exception)
        {
            return await hotcakes.GetFoglalasAsync(userId, status);
        }
    }

    public async Task<List<Foglala>> GetAllFoglalasAsync()
    {
        await EnsureLocalApiRunningAsync();
        using var response = await HttpClient.GetAsync("api/foglalas/all?key=" + Uri.EscapeDataString(HotcakesApiKey));
        await EnsureSuccessAsync(response);
        var result = await response.Content.ReadFromJsonAsync<ContentResponse<Foglala>>();
        return result?.Content ?? new List<Foglala>();
    }

    public async Task<Foglala> CreateFoglalasAsync(Foglala foglalas)
    {
        await EnsureLocalApiRunningAsync();
        var response = await HttpClient.PostAsJsonAsync("api/foglalas", foglalas);
        await EnsureSuccessAsync(response);
        return (await response.Content.ReadFromJsonAsync<Foglala>()) ?? foglalas;
    }

    public async Task UpdateFoglalasAsync(Foglala foglalas)
    {
        await EnsureLocalApiRunningAsync();
        var response = await HttpClient.PutAsJsonAsync("api/foglalas/" + foglalas.FoglalasId, foglalas);
        await EnsureSuccessAsync(response);
    }

    public async Task DeleteFoglalasAsync(int foglalasId)
    {
        await EnsureLocalApiRunningAsync();
        var response = await HttpClient.DeleteAsync("api/foglalas/" + foglalasId);
        await EnsureSuccessAsync(response);
    }

    public async Task<string> GetNextBookingReferenceAsync()
    {
        await EnsureLocalApiRunningAsync();
        return await HttpClient.GetStringAsync("api/foglalas/next-reference");
    }

    public async Task<List<HccOrder>> GetOrdersAsync(string? filter = null)
        => await hotcakes.GetOrdersAsync(filter);

    public async Task<List<HccProduct>> GetProductsAsync(string? filter = null)
        => await hotcakes.GetProductsAsync(filter);

    public async Task<Dictionary<Guid, string>> GetProductNamesAsync(IEnumerable<Guid> productIds)
    {
        var ids = productIds.Where(id => id != Guid.Empty).ToHashSet();
        if (ids.Count == 0)
        {
            return new Dictionary<Guid, string>();
        }

        return (await GetLineItemsByProductIdsAsync(ids))
            .Where(lineItem => ids.Contains(lineItem.ProductId) && !string.IsNullOrWhiteSpace(lineItem.ProductName))
            .GroupBy(lineItem => lineItem.ProductId)
            .ToDictionary(
                group => group.Key,
                group => group
                    .OrderByDescending(lineItem => lineItem.LastUpdated)
                    .Select(lineItem => lineItem.ProductName)
                    .First());
    }

    public async Task<List<HccLineItem>> GetLineItemsByProductIdsAsync(IEnumerable<Guid> productIds)
    {
        var ids = string.Join(",", productIds.Where(id => id != Guid.Empty).Distinct());
        if (string.IsNullOrWhiteSpace(ids))
        {
            return new List<HccLineItem>();
        }

        return await hotcakes.GetLineItemsByProductIdsAsync(productIds);
    }

    public async Task<HccLineItem?> GetFirstLineItemForOrderAsync(Guid orderBvin)
    {
        return await hotcakes.GetFirstLineItemForOrderAsync(orderBvin);
    }

    public async Task<BookingOrderDetails?> GetBookingOrderDetailsAsync(Guid orderBvin)
    {
        return await hotcakes.GetBookingOrderDetailsAsync(orderBvin);
    }

    public async Task<string?> GetPhoneNumberForUserAsync(User selectedUser)
    {
        if (string.IsNullOrWhiteSpace(selectedUser.Email))
        {
            return null;
        }

        try
        {
            await EnsureLocalApiRunningAsync();
            var path = "api/users/" + selectedUser.UserId + "/phone?email=" + Uri.EscapeDataString(selectedUser.Email);
            return await HttpClient.GetStringAsync(path);
        }
        catch (Exception)
        {
            return null;
        }
    }

    private static async Task EnsureLocalApiRunningAsync()
    {
        try
        {
            using var response = await HttpClient.GetAsync("api/health");
            if (response.IsSuccessStatusCode)
            {
                return;
            }
        }
        catch (Exception)
        {
        }

        if (!IsLocalApiAddress())
        {
            throw new InvalidOperationException($"A FoglalasApi nem erheto el ezen a cimen: {HttpClient.BaseAddress}");
        }

        var projectPath = FindFoglalasApiProject();
        if (projectPath != null)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"run --project \"{projectPath}\" --urls http://localhost:5127",
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = Path.GetDirectoryName(projectPath)!
            });

            for (var i = 0; i < 20; i++)
            {
                await Task.Delay(500);
                try
                {
                    using var response = await HttpClient.GetAsync("api/health");
                    if (response.IsSuccessStatusCode)
                    {
                        return;
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        throw new InvalidOperationException("A FoglalasApi nem fut a http://localhost:5127 cimen. Inditsd el a FoglalasApi projektet is, vagy allits be tobb startup projektet Visual Studio-ban.");
    }

    private static bool IsLocalApiAddress()
    {
        var host = HttpClient.BaseAddress?.Host;
        return string.Equals(host, "localhost", StringComparison.OrdinalIgnoreCase)
            || string.Equals(host, "127.0.0.1", StringComparison.OrdinalIgnoreCase)
            || string.Equals(host, "::1", StringComparison.OrdinalIgnoreCase);
    }

    private static string? FindFoglalasApiProject()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory != null)
        {
            var candidate = Path.Combine(directory.FullName, "FoglalasApi", "FoglalasApi.csproj");
            if (File.Exists(candidate))
            {
                return candidate;
            }

            candidate = Path.Combine(directory.FullName, "..", "FoglalasApi", "FoglalasApi.csproj");
            if (File.Exists(candidate))
            {
                return Path.GetFullPath(candidate);
            }

            directory = directory.Parent;
        }

        return null;
    }

    private static async Task<List<T>> GetListAsync<T>(string path)
    {
        using var response = await HttpClient.GetAsync(path);
        await EnsureSuccessAsync(response);
        return await response.Content.ReadFromJsonAsync<List<T>>() ?? new List<T>();
    }

    private static async Task EnsureSuccessAsync(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode)
        {
            return;
        }

        var details = await response.Content.ReadAsStringAsync();
        throw new InvalidOperationException(string.IsNullOrWhiteSpace(details) ? response.ReasonPhrase : details);
    }

    private sealed class ContentResponse<T>
    {
        public List<T> Content { get; set; } = new();
    }
}
