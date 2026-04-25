using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ExtensionUrlProviderSetting
{
    public int ExtensionUrlProviderId { get; set; }

    public int PortalId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;
}
