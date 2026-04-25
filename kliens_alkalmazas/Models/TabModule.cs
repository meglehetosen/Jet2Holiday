using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class TabModule
{
    public int TabModuleId { get; set; }

    public int TabId { get; set; }

    public int ModuleId { get; set; }

    public string PaneName { get; set; } = null!;

    public int ModuleOrder { get; set; }

    public int CacheTime { get; set; }

    public string? Alignment { get; set; }

    public string? Color { get; set; }

    public string? Border { get; set; }

    public string? IconFile { get; set; }

    public int Visibility { get; set; }

    public string? ContainerSrc { get; set; }

    public bool DisplayTitle { get; set; }

    public bool DisplayPrint { get; set; }

    public bool DisplaySyndicate { get; set; }

    public bool IsWebSlice { get; set; }

    public string? WebSliceTitle { get; set; }

    public DateTime? WebSliceExpiryDate { get; set; }

    public int? WebSliceTtl { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsDeleted { get; set; }

    public string? CacheMethod { get; set; }

    public string? ModuleTitle { get; set; }

    public string? Header { get; set; }

    public string? Footer { get; set; }

    public string? CultureCode { get; set; }

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    public Guid? DefaultLanguageGuid { get; set; }

    public Guid LocalizedVersionGuid { get; set; }

    public virtual Module Module { get; set; } = null!;

    public virtual Tab Tab { get; set; } = null!;

    public virtual ICollection<TabModuleSetting> TabModuleSettings { get; set; } = new List<TabModuleSetting>();
}
