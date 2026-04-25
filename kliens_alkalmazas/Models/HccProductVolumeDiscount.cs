using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductVolumeDiscount
{
    public Guid Bvin { get; set; }

    public Guid ProductId { get; set; }

    public int Qty { get; set; }

    public int DiscountType { get; set; }

    public decimal Amount { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public virtual HccProduct Product { get; set; } = null!;
}
