namespace kliens_alkalmazas_api.Models;

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
