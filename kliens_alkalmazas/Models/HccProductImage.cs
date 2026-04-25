using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductImage
{
    public Guid Bvin { get; set; }

    public Guid ProductId { get; set; }

    public string FileName { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public string AlternateText { get; set; } = null!;

    public int SortOrder { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public virtual HccProduct Product { get; set; } = null!;
}
