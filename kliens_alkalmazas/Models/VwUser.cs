using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwUser
{
    public int UserId { get; set; }

    public int? PortalId { get; set; }

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public bool IsSuperUser { get; set; }

    public string? Email { get; set; }

    public string? VanityUrl { get; set; }

    public int? AffiliateId { get; set; }

    public bool IsDeleted { get; set; }

    public bool? RefreshRoles { get; set; }

    public string? LastIpaddress { get; set; }

    public bool UpdatePassword { get; set; }

    public Guid? PasswordResetToken { get; set; }

    public DateTime? PasswordResetExpiration { get; set; }

    public bool? Authorised { get; set; }

    public bool? HasAgreedToTerms { get; set; }

    public DateTime? HasAgreedToTermsOn { get; set; }

    public bool? RequestsRemoval { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }
}
