using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Permission
{
    public int PermissionId { get; set; }

    public string PermissionCode { get; set; } = null!;

    public int ModuleDefId { get; set; }

    public string PermissionKey { get; set; } = null!;

    public string PermissionName { get; set; } = null!;

    public int ViewOrder { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermissions { get; set; } = new List<ContentWorkflowStatePermission>();

    public virtual ICollection<DesktopModulePermission> DesktopModulePermissions { get; set; } = new List<DesktopModulePermission>();

    public virtual ICollection<FolderPermission> FolderPermissions { get; set; } = new List<FolderPermission>();

    public virtual ICollection<ModulePermission> ModulePermissions { get; set; } = new List<ModulePermission>();

    public virtual ICollection<PortalPermission> PortalPermissions { get; set; } = new List<PortalPermission>();

    public virtual ICollection<TabPermission> TabPermissions { get; set; } = new List<TabPermission>();
}
