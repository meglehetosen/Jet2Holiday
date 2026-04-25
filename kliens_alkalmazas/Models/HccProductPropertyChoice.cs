using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductPropertyChoice
{
    public long Id { get; set; }

    public long PropertyId { get; set; }

    public string ChoiceName { get; set; } = null!;

    public int SortOrder { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public virtual ICollection<HccProductPropertyChoiceTranslation> HccProductPropertyChoiceTranslations { get; set; } = new List<HccProductPropertyChoiceTranslation>();

    public virtual HccProductProperty Property { get; set; } = null!;
}
