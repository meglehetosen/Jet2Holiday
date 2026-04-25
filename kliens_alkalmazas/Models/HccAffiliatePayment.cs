using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccAffiliatePayment
{
    public long Id { get; set; }

    public long AffiliateId { get; set; }

    public decimal PaymentAmount { get; set; }

    public string? Notes { get; set; }

    public string? FileName { get; set; }

    public DateTime PaymentDate { get; set; }

    public virtual HccAffiliate Affiliate { get; set; } = null!;
}
