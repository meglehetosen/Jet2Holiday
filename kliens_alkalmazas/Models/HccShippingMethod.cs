using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccShippingMethod
{
    public Guid Bvin { get; set; }

    public DateTime LastUpdated { get; set; }

    public decimal Adjustment { get; set; }

    public int AdjustmentType { get; set; }

    public string ShippingProviderId { get; set; } = null!;

    public long StoreId { get; set; }

    public long ZoneId { get; set; }

    public string Settings { get; set; } = null!;

    public int VisibilityMode { get; set; }

    public decimal? VisibilityAmount { get; set; }

    public int SortOrder { get; set; }

    public virtual ICollection<HccShippingMethodTranslation> HccShippingMethodTranslations { get; set; } = new List<HccShippingMethodTranslation>();
}
