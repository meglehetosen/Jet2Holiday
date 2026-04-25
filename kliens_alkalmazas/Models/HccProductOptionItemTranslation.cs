using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductOptionItemTranslation
{
    public long ProductOptionItemTranslationId { get; set; }

    public Guid ProductOptionItemId { get; set; }

    public string Culture { get; set; } = null!;

    public string? Name { get; set; }

    public virtual HccProductOptionsItem ProductOptionItem { get; set; } = null!;
}
