using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductXcategory
{
    public long Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid CategoryId { get; set; }

    public int SortOrder { get; set; }

    public long StoreId { get; set; }

    public virtual HccCategory Category { get; set; } = null!;

    public virtual HccProduct Product { get; set; } = null!;
}
