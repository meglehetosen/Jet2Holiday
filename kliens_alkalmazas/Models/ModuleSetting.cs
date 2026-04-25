using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ModuleSetting
{
    public int ModuleId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Module Module { get; set; } = null!;
}
