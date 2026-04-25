using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class RoleGroup
{
    public int RoleGroupId { get; set; }

    public int PortalId { get; set; }

    public string RoleGroupName { get; set; } = null!;

    public string? Description { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Portal Portal { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
