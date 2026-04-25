using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccPromotionTranslation
{
    public long PromotionTranslationId { get; set; }

    public long PromotionId { get; set; }

    public string Culture { get; set; } = null!;

    public string? CustomerDescription { get; set; }

    public virtual HccPromotion Promotion { get; set; } = null!;
}
