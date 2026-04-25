using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwContentWorkflowStatePermission
{
    public int WorkflowStatePermissionId { get; set; }

    public int StateId { get; set; }

    public int? PermissionId { get; set; }

    public int? RoleId { get; set; }

    public string? RoleName { get; set; }

    public bool AllowAccess { get; set; }

    public int? UserId { get; set; }

    public string? Username { get; set; }

    public string? DisplayName { get; set; }

    public string? PermissionCode { get; set; }

    public int? ModuleDefId { get; set; }

    public string? PermissionKey { get; set; }

    public string? PermissionName { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }
}
