using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwModulePermission
{
    public int ModulePermissionId { get; set; }

    public int ModuleId { get; set; }

    public int PortalId { get; set; }

    public int PermissionId { get; set; }

    public int? RoleId { get; set; }

    public string? RoleName { get; set; }

    public bool AllowAccess { get; set; }

    public int? UserId { get; set; }

    public string? Username { get; set; }

    public string? DisplayName { get; set; }

    public string PermissionCode { get; set; } = null!;

    public int ModuleDefId { get; set; }

    public string PermissionKey { get; set; } = null!;

    public string PermissionName { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }
}
