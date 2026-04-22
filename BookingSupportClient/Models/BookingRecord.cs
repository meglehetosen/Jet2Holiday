namespace BookingSupportClient.Models;

public sealed class BookingRecord
{
    public int BookingId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerContact { get; set; } = string.Empty;
    public string ProductCode { get; set; } = string.Empty;
    public DateTime BookingDate { get; set; } = DateTime.Today;
    public DateTime SelectedDate { get; set; } = DateTime.Today;
    public string Status { get; set; } = "Pending";
    public string CheckoutReference { get; set; } = string.Empty;
    public string CheckoutDataJson { get; set; } = "{}";
    public string InternalNotes { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
