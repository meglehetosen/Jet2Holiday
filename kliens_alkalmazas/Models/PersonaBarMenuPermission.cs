using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PersonaBarMenuPermission
{
    public int MenuPermissionId { get; set; }

    public int? PortalId { get; set; }

    public int MenuId { get; set; }

    public int PermissionId { get; set; }

    public bool AllowAccess { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual PersonaBarMenu Menu { get; set; } = null!;

    public virtual PersonaBarPermission Permission { get; set; } = null!;

    public virtual Portal? Portal { get; set; }

    public virtual Role? Role { get; set; }

    public virtual User? User { get; set; }
}
