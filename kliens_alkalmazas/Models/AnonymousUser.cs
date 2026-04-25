using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class AnonymousUser
{
    public string UserId { get; set; } = null!;

    public int PortalId { get; set; }

    public int TabId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime LastActiveDate { get; set; }

    public virtual Portal Portal { get; set; } = null!;
}
