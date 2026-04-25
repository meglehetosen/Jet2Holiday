using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class DesktopModulePermission
{
    public int DesktopModulePermissionId { get; set; }

    public int PortalDesktopModuleId { get; set; }

    public int PermissionId { get; set; }

    public bool AllowAccess { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Permission Permission { get; set; } = null!;

    public virtual PortalDesktopModule PortalDesktopModule { get; set; } = null!;

    public virtual Role? Role { get; set; }

    public virtual User? User { get; set; }
}
