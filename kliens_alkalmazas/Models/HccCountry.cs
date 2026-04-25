using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccCountry
{
    public Guid CountryId { get; set; }

    public string? CultureCode { get; set; }

    public string? SystemName { get; set; }

    public string? IsoCode { get; set; }

    public string? IsoAlpha3 { get; set; }

    public string? IsoNumeric { get; set; }

    public string? PostalCodeValidationRegex { get; set; }

    public virtual ICollection<HccCountryTranslation> HccCountryTranslations { get; set; } = new List<HccCountryTranslation>();

    public virtual ICollection<HccRegion> HccRegions { get; set; } = new List<HccRegion>();
}
