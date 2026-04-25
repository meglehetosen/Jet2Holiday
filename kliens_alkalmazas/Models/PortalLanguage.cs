using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PortalLanguage
{
    public int PortalLanguageId { get; set; }

    public int PortalId { get; set; }

    public int LanguageId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsPublished { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual Portal Portal { get; set; } = null!;
}
