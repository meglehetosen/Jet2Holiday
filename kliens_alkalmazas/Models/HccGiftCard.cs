using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccGiftCard
{
    public long GiftCardId { get; set; }

    public long StoreId { get; set; }

    public long? LineItemId { get; set; }

    public string CardNumber { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal UsedAmount { get; set; }

    public DateTime IssueDateUtc { get; set; }

    public DateTime ExpirationDateUtc { get; set; }

    public string? RecipientEmail { get; set; }

    public string? RecipientName { get; set; }

    public string? GiftMessage { get; set; }

    public bool Enabled { get; set; }
}
