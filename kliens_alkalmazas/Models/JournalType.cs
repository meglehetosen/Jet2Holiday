using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class JournalType
{
    public int JournalTypeId { get; set; }

    public string? JournalType1 { get; set; }

    public string? Icon { get; set; }

    public int PortalId { get; set; }

    public bool IsEnabled { get; set; }

    public bool AppliesToProfile { get; set; }

    public bool AppliesToGroup { get; set; }

    public bool AppliesToStream { get; set; }

    public string? Options { get; set; }

    public bool SupportsNotify { get; set; }

    public bool EnableComments { get; set; }

    public virtual ICollection<Journal> Journals { get; set; } = new List<Journal>();
}
