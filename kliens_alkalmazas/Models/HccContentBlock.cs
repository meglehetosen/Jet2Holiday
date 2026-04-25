using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccContentBlock
{
    public Guid Bvin { get; set; }

    public Guid ColumnId { get; set; }

    public int SortOrder { get; set; }

    public string ControlName { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public string SerializedSettings { get; set; } = null!;

    public string SerializedLists { get; set; } = null!;

    public virtual HccContentColumn Column { get; set; } = null!;

    public virtual ICollection<HccContentBlockTranslation> HccContentBlockTranslations { get; set; } = new List<HccContentBlockTranslation>();
}
