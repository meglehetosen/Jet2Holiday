using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccOrder
{
    public int Id { get; set; }

    public Guid Bvin { get; set; }

    public long? AffiliateId { get; set; }

    public string BillingAddress { get; set; } = null!;

    public string CustomProperties { get; set; } = null!;

    public decimal FraudScore { get; set; }

    public decimal GrandTotal { get; set; }

    public decimal HandlingTotal { get; set; }

    public string Instructions { get; set; } = null!;

    public int IsPlaced { get; set; }

    public DateTime LastUpdated { get; set; }

    public decimal OrderDiscounts { get; set; }

    public string OrderDiscountDetails { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public int PaymentStatus { get; set; }

    public string ShippingAddress { get; set; } = null!;

    public string ShippingMethodId { get; set; } = null!;

    public string ShippingMethodDisplayName { get; set; } = null!;

    public string ShippingProviderId { get; set; } = null!;

    public string ShippingProviderServiceCode { get; set; } = null!;

    public int ShippingStatus { get; set; }

    public decimal ShippingTotal { get; set; }

    public decimal ShippingDiscounts { get; set; }

    public string ShippingDiscountDetails { get; set; } = null!;

    public decimal SubTotal { get; set; }

    public decimal TaxTotal { get; set; }

    public DateTime TimeOfOrder { get; set; }

    public string UserEmail { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string StatusCode { get; set; } = null!;

    public string StatusName { get; set; } = null!;

    public string ThirdPartyOrderId { get; set; } = null!;

    public long StoreId { get; set; }

    public decimal ItemsTax { get; set; }

    public decimal ShippingTax { get; set; }

    public decimal ShippingTaxRate { get; set; }

    public decimal AdjustedShippingTotal { get; set; }

    public int UserDeviceType { get; set; }

    public bool IsAbandonedEmailSent { get; set; }

    public bool IsRecurring { get; set; }

    public string UsedCulture { get; set; } = null!;

    public virtual ICollection<Foglala> Foglalas { get; set; } = new List<Foglala>();

    public virtual ICollection<HccLineItem> HccLineItems { get; set; } = new List<HccLineItem>();

    public virtual ICollection<HccOrderCoupon> HccOrderCoupons { get; set; } = new List<HccOrderCoupon>();

    public virtual ICollection<HccOrderNote> HccOrderNotes { get; set; } = new List<HccOrderNote>();

    public virtual ICollection<HccOrderPackage> HccOrderPackages { get; set; } = new List<HccOrderPackage>();

    public virtual ICollection<HccOrderTransaction> HccOrderTransactions { get; set; } = new List<HccOrderTransaction>();

    public virtual ICollection<HccRma> HccRmas { get; set; } = new List<HccRma>();
}
