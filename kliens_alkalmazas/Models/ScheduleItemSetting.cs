using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ScheduleItemSetting
{
    public int ScheduleId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;
}
