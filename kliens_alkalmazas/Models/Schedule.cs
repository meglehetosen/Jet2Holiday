using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Schedule
{
    public int ScheduleId { get; set; }

    public string TypeFullName { get; set; } = null!;

    public int TimeLapse { get; set; }

    public string TimeLapseMeasurement { get; set; } = null!;

    public int RetryTimeLapse { get; set; }

    public string RetryTimeLapseMeasurement { get; set; } = null!;

    public int RetainHistoryNum { get; set; }

    public string AttachToEvent { get; set; } = null!;

    public bool CatchUpEnabled { get; set; }

    public bool Enabled { get; set; }

    public string ObjectDependencies { get; set; } = null!;

    public string? Servers { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? FriendlyName { get; set; }

    public DateTime? ScheduleStartDate { get; set; }

    public virtual ICollection<ScheduleHistory> ScheduleHistories { get; set; } = new List<ScheduleHistory>();

    public virtual ICollection<ScheduleItemSetting> ScheduleItemSettings { get; set; } = new List<ScheduleItemSetting>();
}
