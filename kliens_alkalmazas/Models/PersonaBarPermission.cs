using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PersonaBarPermission
{
    public int PermissionId { get; set; }

    public int? MenuId { get; set; }

    public string PermissionKey { get; set; } = null!;

    public string PermissionName { get; set; } = null!;

    public int ViewOrder { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual PersonaBarMenu? Menu { get; set; }

    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermissions { get; set; } = new List<PersonaBarMenuPermission>();
}
