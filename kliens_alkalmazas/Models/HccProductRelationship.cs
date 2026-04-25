using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductRelationship
{
    public long Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid RelatedProductId { get; set; }

    public bool IsSubstitute { get; set; }

    public int SortOrder { get; set; }

    public string MarketingDescription { get; set; } = null!;

    public long StoreId { get; set; }

    public virtual HccProduct Product { get; set; } = null!;
}
