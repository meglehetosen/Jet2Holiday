using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class JournalAccess
{
    public int JournalAccessId { get; set; }

    public int JournalTypeId { get; set; }

    public int PortalId { get; set; }

    public string Name { get; set; } = null!;

    public Guid AccessKey { get; set; }

    public bool IsEnabled { get; set; }

    public DateTime DateCreated { get; set; }
}
