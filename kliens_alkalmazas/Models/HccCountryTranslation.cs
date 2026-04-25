using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccCountryTranslation
{
    public long CountryTranslationId { get; set; }

    public Guid CountryId { get; set; }

    public string Culture { get; set; } = null!;

    public string? DisplayName { get; set; }

    public virtual HccCountry Country { get; set; } = null!;
}
