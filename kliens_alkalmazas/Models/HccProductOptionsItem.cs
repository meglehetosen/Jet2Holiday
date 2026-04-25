using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductOptionsItem
{
    public Guid Bvin { get; set; }

    public long StoreId { get; set; }

    public Guid OptionBvin { get; set; }

    public decimal PriceAdjustment { get; set; }

    public decimal WeightAdjustment { get; set; }

    public bool IsLabel { get; set; }

    public int SortOrder { get; set; }

    public bool IsDefault { get; set; }

    public virtual ICollection<HccProductOptionItemTranslation> HccProductOptionItemTranslations { get; set; } = new List<HccProductOptionItemTranslation>();

    public virtual HccProductOption OptionBvinNavigation { get; set; } = null!;
}
