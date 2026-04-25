using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccCategoryTranslation
{
    public long CategoryTranslationId { get; set; }

    public Guid CategoryId { get; set; }

    public string Culture { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? MetaTitle { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? Keywords { get; set; }

    public virtual HccCategory Category { get; set; } = null!;
}
