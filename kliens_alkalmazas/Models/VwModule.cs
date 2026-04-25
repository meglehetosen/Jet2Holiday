using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwModule
{
    public int? OwnerPortalId { get; set; }

    public int PackageId { get; set; }

    public int? PortalId { get; set; }

    public int? TabId { get; set; }

    public int? TabModuleId { get; set; }

    public int ModuleId { get; set; }

    public int ModuleDefId { get; set; }

    public int? ModuleOrder { get; set; }

    public string? PaneName { get; set; }

    public string? ModuleTitle { get; set; }

    public int? CacheTime { get; set; }

    public string? CacheMethod { get; set; }

    public string? Alignment { get; set; }

    public string? Color { get; set; }

    public string? Border { get; set; }

    public string? IconFile { get; set; }

    public int? Visibility { get; set; }

    public string? Header { get; set; }

    public string? Footer { get; set; }

    public string? ContainerSrc { get; set; }

    public bool? DisplayTitle { get; set; }

    public bool? DisplayPrint { get; set; }

    public bool? DisplaySyndicate { get; set; }

    public bool? IsWebSlice { get; set; }

    public string? WebSliceTitle { get; set; }

    public DateTime? WebSliceExpiryDate { get; set; }

    public int? WebSliceTtl { get; set; }

    public Guid? UniqueId { get; set; }

    public Guid? VersionGuid { get; set; }

    public Guid? DefaultLanguageGuid { get; set; }

    public Guid? LocalizedVersionGuid { get; set; }

    public string? CultureCode { get; set; }

    public bool AllTabs { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? TabStartDate { get; set; }

    public DateTime? TabEndDate { get; set; }

    public bool? InheritViewPermissions { get; set; }

    public bool IsShareable { get; set; }

    public bool IsShareableViewOnly { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? LastContentModifiedOnDate { get; set; }

    public int DesktopModuleId { get; set; }

    public int DefaultCacheTime { get; set; }

    public string DefinitionName { get; set; } = null!;

    public int ModuleControlId { get; set; }

    public string? BusinessControllerClass { get; set; }

    public bool IsAdmin { get; set; }

    public int SupportedFeatures { get; set; }

    public int? ContentItemId { get; set; }

    public string? Content { get; set; }

    public int? ContentTypeId { get; set; }

    public string? ContentKey { get; set; }

    public bool? Indexed { get; set; }

    public int? StateId { get; set; }

    public bool? IsDeleted { get; set; }

    public bool IsModuleDeleted { get; set; }

    public bool? IsTabDeleted { get; set; }
}
