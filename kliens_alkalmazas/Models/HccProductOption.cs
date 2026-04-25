using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductOption
{
    public Guid Bvin { get; set; }

    public long StoreId { get; set; }

    public int OptionType { get; set; }

    public bool NameIsHidden { get; set; }

    public bool IsVariant { get; set; }

    public bool IsShared { get; set; }

    public string Settings { get; set; } = null!;

    public bool IsColorSwatch { get; set; }

    public virtual ICollection<HccProductOptionTranslation> HccProductOptionTranslations { get; set; } = new List<HccProductOptionTranslation>();

    public virtual ICollection<HccProductOptionsItem> HccProductOptionsItems { get; set; } = new List<HccProductOptionsItem>();

    public virtual ICollection<HccProductXoption> HccProductXoptions { get; set; } = new List<HccProductXoption>();
}
