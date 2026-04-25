using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwUserRole
{
    public int UserRoleId { get; set; }

    public int RoleId { get; set; }

    public int UserId { get; set; }

    public int? PortalId { get; set; }

    public string RoleName { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string? Description { get; set; }

    public string DisplayName { get; set; } = null!;

    public string? Email { get; set; }

    public int Status { get; set; }

    public bool IsOwner { get; set; }

    public int SecurityMode { get; set; }

    public decimal? ServiceFee { get; set; }

    public string? BillingFrequency { get; set; }

    public int? TrialPeriod { get; set; }

    public string? TrialFrequency { get; set; }

    public int? BillingPeriod { get; set; }

    public decimal? TrialFee { get; set; }

    public bool IsPublic { get; set; }

    public bool AutoAssignment { get; set; }

    public int? RoleGroupId { get; set; }

    public string? Rsvpcode { get; set; }

    public string? IconFile { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public bool? IsTrialUsed { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsSystemRole { get; set; }
}
