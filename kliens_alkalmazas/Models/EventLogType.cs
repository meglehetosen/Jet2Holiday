using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class EventLogType
{
    public string LogTypeKey { get; set; } = null!;

    public string LogTypeFriendlyName { get; set; } = null!;

    public string LogTypeDescription { get; set; } = null!;

    public string LogTypeOwner { get; set; } = null!;

    public string LogTypeCssclass { get; set; } = null!;

    public virtual ICollection<EventLogConfig> EventLogConfigs { get; set; } = new List<EventLogConfig>();

    public virtual ICollection<EventLog> EventLogs { get; set; } = new List<EventLog>();
}
