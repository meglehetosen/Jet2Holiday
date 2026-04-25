using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccStoreSetting
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public virtual ICollection<HccStoreSettingsTranslation> HccStoreSettingsTranslations { get; set; } = new List<HccStoreSettingsTranslation>();

    public virtual HccStore Store { get; set; } = null!;
}
