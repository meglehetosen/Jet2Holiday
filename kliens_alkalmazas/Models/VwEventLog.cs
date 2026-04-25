using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwEventLog
{
    public string LogGuid { get; set; } = null!;

    public string LogTypeKey { get; set; } = null!;

    public int? LogConfigId { get; set; }

    public int? LogUserId { get; set; }

    public string? LogUserName { get; set; }

    public int? LogPortalId { get; set; }

    public string? LogPortalName { get; set; }

    public DateTime LogCreateDate { get; set; }

    public string LogServerName { get; set; } = null!;

    public string? LogProperties { get; set; }

    public bool? LogNotificationPending { get; set; }

    public long LogEventId { get; set; }

    public string? ExceptionHash { get; set; }

    public string? AssemblyVersion { get; set; }

    public int? PortalId { get; set; }

    public int? UserId { get; set; }

    public int? TabId { get; set; }

    public string? RawUrl { get; set; }

    public string? Referrer { get; set; }

    public string? UserAgent { get; set; }

    public string? Message { get; set; }

    public string? StackTrace { get; set; }

    public string? InnerMessage { get; set; }

    public string? InnerStackTrace { get; set; }

    public string? Source { get; set; }
}
