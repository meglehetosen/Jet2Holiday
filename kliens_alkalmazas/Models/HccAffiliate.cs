using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccAffiliate
{
    public long Id { get; set; }

    public string? ReferralId { get; set; }

    public bool Enabled { get; set; }

    public decimal CommissionAmount { get; set; }

    public int CommissionType { get; set; }

    public int ReferralDays { get; set; }

    public string TaxId { get; set; } = null!;

    public string DriversLicenseNumber { get; set; } = null!;

    public string WebSiteUrl { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public int UserId { get; set; }

    public string AffiliateId { get; set; } = null!;

    public bool Approved { get; set; }

    public DateTime CreationDate { get; set; }

    public virtual ICollection<HccAffiliatePayment> HccAffiliatePayments { get; set; } = new List<HccAffiliatePayment>();

    public virtual ICollection<HccAffiliateReferral> HccAffiliateReferrals { get; set; } = new List<HccAffiliateReferral>();
}
