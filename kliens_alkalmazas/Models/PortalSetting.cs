using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PortalSetting
{
    public int PortalSettingId { get; set; }

    public int PortalId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? CultureCode { get; set; }

    public bool IsSecure { get; set; }

    public virtual Portal Portal { get; set; } = null!;
}
