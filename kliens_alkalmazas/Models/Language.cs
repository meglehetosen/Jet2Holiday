using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Language
{
    public int LanguageId { get; set; }

    public string CultureCode { get; set; } = null!;

    public string CultureName { get; set; } = null!;

    public string? FallbackCulture { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual ICollection<PortalLanguage> PortalLanguages { get; set; } = new List<PortalLanguage>();
}
