using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductTranslation
{
    public long ProductTranslationId { get; set; }

    public Guid ProductId { get; set; }

    public string Culture { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaTitle { get; set; }

    public string? ShortDescription { get; set; }

    public string? LongDescription { get; set; }

    public string? Keywords { get; set; }

    public string? SitePriceOverrideText { get; set; }

    public string? SmallImageAlternateText { get; set; }

    public string? MediumImageAlternateText { get; set; }

    public string? DescriptionTabs { get; set; }

    public string? HiddenSearchKeywords { get; set; }

    public string? UserPriceLabel { get; set; }

    public virtual HccProduct Product { get; set; } = null!;
}
