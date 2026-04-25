using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductProperty
{
    public long Id { get; set; }

    public string PropertyName { get; set; } = null!;

    public int DisplayOnSite { get; set; }

    public int DisplayToDropShipper { get; set; }

    public int TypeCode { get; set; }

    public string DefaultValue { get; set; } = null!;

    public string CultureCode { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public bool DisplayOnSearch { get; set; }

    public bool IsLocalizable { get; set; }

    public virtual ICollection<HccProductPropertyChoice> HccProductPropertyChoices { get; set; } = new List<HccProductPropertyChoice>();

    public virtual ICollection<HccProductPropertyTranslation> HccProductPropertyTranslations { get; set; } = new List<HccProductPropertyTranslation>();

    public virtual ICollection<HccProductPropertyValue> HccProductPropertyValues { get; set; } = new List<HccProductPropertyValue>();

    public virtual ICollection<HccProductTypeXproductProperty> HccProductTypeXproductProperties { get; set; } = new List<HccProductTypeXproductProperty>();
}
