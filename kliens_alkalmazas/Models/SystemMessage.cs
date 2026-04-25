using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class SystemMessage
{
    public int MessageId { get; set; }

    public int? PortalId { get; set; }

    public string MessageName { get; set; } = null!;

    public string MessageValue { get; set; } = null!;

    public virtual Portal? Portal { get; set; }
}
