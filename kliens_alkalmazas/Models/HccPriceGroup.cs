using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccPriceGroup
{
    public string Bvin { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int PricingType { get; set; }

    public decimal AdjustmentAmount { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }
}
