using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccVariant
{
    public Guid Bvin { get; set; }

    public Guid ProductId { get; set; }

    public string Sku { get; set; } = null!;

    public decimal Price { get; set; }

    public string SelectionData { get; set; } = null!;

    public long StoreId { get; set; }

    public string CustomProperty { get; set; } = null!;

    public virtual HccProduct Product { get; set; } = null!;
}
