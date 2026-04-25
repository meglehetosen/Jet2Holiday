using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class EventLog
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

    public virtual ExceptionEvent? ExceptionEvent { get; set; }

    public virtual EventLogConfig? LogConfig { get; set; }

    public virtual EventLogType LogTypeKeyNavigation { get; set; } = null!;
}
