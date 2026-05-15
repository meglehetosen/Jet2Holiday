namespace kliens_alkalmazas_api.Models;

public class HccProduct
{
    public long Id { get; set; }
    public Guid Bvin { get; set; }
    public string Sku { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public decimal ListPrice { get; set; }
    public decimal? SitePrice { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastUpdated { get; set; }
    public string RewriteUrl { get; set; } = string.Empty;
    public long StoreId { get; set; }
    public bool IsAvailableForSale { get; set; }
}
