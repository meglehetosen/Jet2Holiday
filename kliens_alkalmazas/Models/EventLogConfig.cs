using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class EventLogConfig
{
    public int Id { get; set; }

    public string? LogTypeKey { get; set; }

    public int? LogTypePortalId { get; set; }

    public bool LoggingIsActive { get; set; }

    public int KeepMostRecent { get; set; }

    public bool EmailNotificationIsActive { get; set; }

    public int? NotificationThreshold { get; set; }

    public int? NotificationThresholdTime { get; set; }

    public int? NotificationThresholdTimeType { get; set; }

    public string MailFromAddress { get; set; } = null!;

    public string MailToAddress { get; set; } = null!;

    public virtual ICollection<EventLog> EventLogs { get; set; } = new List<EventLog>();

    public virtual EventLogType? LogTypeKeyNavigation { get; set; }
}
