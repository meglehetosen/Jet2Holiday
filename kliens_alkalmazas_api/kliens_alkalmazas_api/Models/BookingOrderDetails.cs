namespace kliens_alkalmazas_api.Models;

public class BookingOrderDetails
{
    public Guid OrderBvin { get; set; }
    public Guid ProductBvin { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public string ProductSku { get; set; } = string.Empty;
    public string Lokacio { get; set; } = string.Empty;
    public DateOnly? ErkezesDatum { get; set; }
    public DateOnly? TavozasDatum { get; set; }
    public int? VendegSzam { get; set; }
    public int? EjszakakSzama { get; set; }
}
