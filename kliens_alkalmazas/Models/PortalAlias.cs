using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PortalAlias
{
    public int PortalAliasId { get; set; }

    public int PortalId { get; set; }

    public string? Httpalias { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? BrowserType { get; set; }

    public string? Skin { get; set; }

    public string? CultureCode { get; set; }

    public bool IsPrimary { get; set; }

    public virtual Portal Portal { get; set; } = null!;
}
