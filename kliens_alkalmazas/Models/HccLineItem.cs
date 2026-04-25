using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccLineItem
{
    public long Id { get; set; }

    public DateTime LastUpdated { get; set; }

    public Guid ProductId { get; set; }

    public string VariantId { get; set; } = null!;

    public int Quantity { get; set; }

    public Guid OrderBvin { get; set; }

    public decimal BasePrice { get; set; }

    public string DiscountDetails { get; set; } = null!;

    public decimal AdjustedPrice { get; set; }

    public decimal ShippingPortion { get; set; }

    public decimal TaxPortion { get; set; }

    public decimal LineTotal { get; set; }

    public string CustomProperties { get; set; } = null!;

    public int QuantityReturned { get; set; }

    public int QuantityShipped { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductShortDescription { get; set; } = null!;

    public string ProductSku { get; set; } = null!;

    public string StatusCode { get; set; } = null!;

    public string StatusName { get; set; } = null!;

    public string SelectionData { get; set; } = null!;

    public long StoreId { get; set; }

    public int IsNonShipping { get; set; }

    public long TaxScheduleId { get; set; }

    public decimal ProductShippingWeight { get; set; }

    public decimal ProductShippingLength { get; set; }

    public decimal ProductShippingWidth { get; set; }

    public decimal ProductShippingHeight { get; set; }

    public string ShipFromAddress { get; set; } = null!;

    public int ShipFromMode { get; set; }

    public string ShipFromNotificationId { get; set; } = null!;

    public bool ShipSeparately { get; set; }

    public decimal ExtraShipCharge { get; set; }

    public bool IsUserSuppliedPrice { get; set; }

    public decimal TaxRate { get; set; }

    public decimal ShippingTaxRate { get; set; }

    public bool IsBundle { get; set; }

    public int QuantityReserved { get; set; }

    public bool IsGiftCard { get; set; }

    public bool IsRecurring { get; set; }

    public int? RecurringInterval { get; set; }

    public int? RecurringIntervalType { get; set; }

    public bool IsRecurringCancelled { get; set; }

    public int ShippingCharge { get; set; }

    public int FreeQuantity { get; set; }

    public string? PromotionIds { get; set; }

    public bool IsUpchargeAllowed { get; set; }

    public virtual HccOrder OrderBvinNavigation { get; set; } = null!;
}
