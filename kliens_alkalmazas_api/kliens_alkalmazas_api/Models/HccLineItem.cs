namespace kliens_alkalmazas_api.Models;

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
