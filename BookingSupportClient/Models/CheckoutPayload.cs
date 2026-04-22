using System.Text.Json.Serialization;

namespace BookingSupportClient.Models;

public sealed class CheckoutPayload
{
    [JsonPropertyName("checkoutReference")]
    public string CheckoutReference { get; set; } = string.Empty;

    [JsonPropertyName("customerName")]
    public string CustomerName { get; set; } = string.Empty;

    [JsonPropertyName("customerContact")]
    public string CustomerContact { get; set; } = string.Empty;

    [JsonPropertyName("productCode")]
    public string ProductCode { get; set; } = string.Empty;

    [JsonPropertyName("bookingDate")]
    public DateTime BookingDate { get; set; } = DateTime.Today;

    [JsonPropertyName("selectedDate")]
    public DateTime SelectedDate { get; set; } = DateTime.Today;

    [JsonPropertyName("status")]
    public string Status { get; set; } = "CheckoutCompleted";

    [JsonPropertyName("checkoutAmount")]
    public decimal CheckoutAmount { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = "EUR";

    [JsonPropertyName("paymentStatus")]
    public string PaymentStatus { get; set; } = "Paid";

    [JsonPropertyName("transactionDateUtc")]
    public DateTime TransactionDateUtc { get; set; } = DateTime.UtcNow;
}
