using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccRmaitem
{
    public Guid Bvin { get; set; }

    public Guid Rmabvin { get; set; }

    public long LineItemBvin { get; set; }

    public string ItemName { get; set; } = null!;

    public string ItemDescription { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public bool Replace { get; set; }

    public int Quantity { get; set; }

    public int QuantityReceived { get; set; }

    public int QuantityReturnedToInventory { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public decimal RefundAmount { get; set; }

    public decimal RefundShippingAmount { get; set; }

    public decimal RefundTaxAmount { get; set; }

    public decimal RefundGiftWrapAmount { get; set; }

    public string ProductClass { get; set; } = null!;

    public virtual HccRma RmabvinNavigation { get; set; } = null!;
}
