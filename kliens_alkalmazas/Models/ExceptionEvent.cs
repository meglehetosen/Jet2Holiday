using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ExceptionEvent
{
    public long LogEventId { get; set; }

    public string AssemblyVersion { get; set; } = null!;

    public int? PortalId { get; set; }

    public int? UserId { get; set; }

    public int? TabId { get; set; }

    public string? RawUrl { get; set; }

    public string? Referrer { get; set; }

    public string? UserAgent { get; set; }

    public virtual EventLog LogEvent { get; set; } = null!;
}
