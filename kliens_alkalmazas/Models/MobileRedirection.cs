using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class MobileRedirection
{
    public int Id { get; set; }

    public int PortalId { get; set; }

    public string Name { get; set; } = null!;

    public int Type { get; set; }

    public int SortOrder { get; set; }

    public int SourceTabId { get; set; }

    public bool IncludeChildTabs { get; set; }

    public int TargetType { get; set; }

    public string TargetValue { get; set; } = null!;

    public bool Enabled { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public virtual ICollection<MobileRedirectionRule> MobileRedirectionRules { get; set; } = new List<MobileRedirectionRule>();

    public virtual Portal Portal { get; set; } = null!;
}
