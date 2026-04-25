using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccPromotion
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public int Mode { get; set; }

    public DateTime LastUpdatedUtc { get; set; }

    public string Name { get; set; } = null!;

    public DateTime StartDateUtc { get; set; }

    public DateTime EndDateUtc { get; set; }

    public bool IsEnabled { get; set; }

    public string QualificationsXml { get; set; } = null!;

    public string ActionsXml { get; set; } = null!;

    public bool DoNotCombine { get; set; }

    public int SortOrder { get; set; }

    public virtual ICollection<HccPromotionTranslation> HccPromotionTranslations { get; set; } = new List<HccPromotionTranslation>();
}
