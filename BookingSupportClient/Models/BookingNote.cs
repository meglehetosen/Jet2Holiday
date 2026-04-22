namespace BookingSupportClient.Models;

public sealed class BookingNote
{
    public int NoteId { get; set; }
    public int BookingId { get; set; }
    public string NoteText { get; set; } = string.Empty;
    public string CreatedBy { get; set; } = "Support";
    public DateTime CreatedAt { get; set; }

    public override string ToString()
    {
        return $"{CreatedAt:g} - {CreatedBy}: {NoteText}";
    }
}
