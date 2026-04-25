using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductPropertyValue
{
    public Guid ProductBvin { get; set; }

    public long PropertyId { get; set; }

    public string PropertyValue { get; set; } = null!;

    public long StoreId { get; set; }

    public long Id { get; set; }

    public virtual ICollection<HccProductPropertyValueTranslation> HccProductPropertyValueTranslations { get; set; } = new List<HccProductPropertyValueTranslation>();

    public virtual HccProduct ProductBvinNavigation { get; set; } = null!;

    public virtual HccProductProperty Property { get; set; } = null!;
}
