using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccRegion
{
    public Guid RegionId { get; set; }

    public Guid CountryId { get; set; }

    public string? Abbreviation { get; set; }

    public string? SystemName { get; set; }

    public virtual HccCountry Country { get; set; } = null!;

    public virtual ICollection<HccRegionTranslation> HccRegionTranslations { get; set; } = new List<HccRegionTranslation>();
}
