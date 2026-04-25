using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwTab
{
    public int TabId { get; set; }

    public int TabOrder { get; set; }

    public int? PortalId { get; set; }

    public string TabName { get; set; } = null!;

    public int? ParentId { get; set; }

    public int Level { get; set; }

    public string TabPath { get; set; } = null!;

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    public Guid? DefaultLanguageGuid { get; set; }

    public Guid LocalizedVersionGuid { get; set; }

    public bool IsVisible { get; set; }

    public bool HasBeenPublished { get; set; }

    public string? IconFile { get; set; }

    public string? IconFileLarge { get; set; }

    public bool DisableLink { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? KeyWords { get; set; }

    public bool IsDeleted { get; set; }

    public string? SkinSrc { get; set; }

    public string? ContainerSrc { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Url { get; set; }

    public string HasChildren { get; set; } = null!;

    public int? RefreshInterval { get; set; }

    public string? PageHeadText { get; set; }

    public bool IsSecure { get; set; }

    public bool PermanentRedirect { get; set; }

    public double SiteMapPriority { get; set; }

    public int? ContentItemId { get; set; }

    public string? Content { get; set; }

    public int? ContentTypeId { get; set; }

    public int? ModuleId { get; set; }

    public string? ContentKey { get; set; }

    public bool? Indexed { get; set; }

    public int? StateId { get; set; }

    public string? CultureCode { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsSystem { get; set; }
}
