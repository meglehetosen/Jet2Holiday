using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class CrossPortalSetting
{
    public int PortalId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public virtual Portal Portal { get; set; } = null!;
}
