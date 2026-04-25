using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccBundledProduct
{
    public long Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid BundledProductId { get; set; }

    public int Quantity { get; set; }

    public string? SelectionData { get; set; }

    public int SortOrder { get; set; }

    public virtual HccProduct Product { get; set; } = null!;
}
