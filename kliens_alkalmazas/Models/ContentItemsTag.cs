using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ContentItemsTag
{
    public int ContentItemTagId { get; set; }

    public int ContentItemId { get; set; }

    public int TermId { get; set; }

    public virtual ContentItem ContentItem { get; set; } = null!;

    public virtual TaxonomyTerm Term { get; set; } = null!;
}
