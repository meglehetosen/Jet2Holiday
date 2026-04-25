using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductInventory
{
    public string Bvin { get; set; } = null!;

    public Guid ProductBvin { get; set; }

    public string VariantId { get; set; } = null!;

    public int QuantityOnHand { get; set; }

    public int QuantityReserved { get; set; }

    public int? QuantityAvailableForSale { get; set; }

    public int LowStockPoint { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public int OutOfStockPoint { get; set; }

    public virtual HccProduct ProductBvinNavigation { get; set; } = null!;
}
