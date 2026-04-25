using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public bool IsSuperUser { get; set; }

    public int? AffiliateId { get; set; }

    public string? Email { get; set; }

    public string DisplayName { get; set; } = null!;

    public bool UpdatePassword { get; set; }

    public string? LastIpaddress { get; set; }

    public bool IsDeleted { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public Guid? PasswordResetToken { get; set; }

    public DateTime? PasswordResetExpiration { get; set; }

    public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermissions { get; set; } = new List<ContentWorkflowStatePermission>();

    public virtual ICollection<CoreMessagingSubscription> CoreMessagingSubscriptions { get; set; } = new List<CoreMessagingSubscription>();

    public virtual ICollection<DesktopModulePermission> DesktopModulePermissions { get; set; } = new List<DesktopModulePermission>();

    public virtual ICollection<Foglala> FoglalaHandledByUsers { get; set; } = new List<Foglala>();

    public virtual ICollection<Foglala> FoglalaUsers { get; set; } = new List<Foglala>();

    public virtual ICollection<FolderPermission> FolderPermissions { get; set; } = new List<FolderPermission>();

    public virtual ICollection<ModulePermission> ModulePermissions { get; set; } = new List<ModulePermission>();

    public virtual ICollection<PasswordHistory> PasswordHistories { get; set; } = new List<PasswordHistory>();

    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermissions { get; set; } = new List<PersonaBarMenuPermission>();

    public virtual ICollection<PortalPermission> PortalPermissions { get; set; } = new List<PortalPermission>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Relationship> Relationships { get; set; } = new List<Relationship>();

    public virtual ICollection<TabPermission> TabPermissions { get; set; } = new List<TabPermission>();

    public virtual ICollection<UserAuthentication> UserAuthentications { get; set; } = new List<UserAuthentication>();

    public virtual ICollection<UserPortal> UserPortals { get; set; } = new List<UserPortal>();

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();

    public virtual ICollection<UserRelationshipPreference> UserRelationshipPreferences { get; set; } = new List<UserRelationshipPreference>();

    public virtual ICollection<UserRelationship> UserRelationshipRelatedUsers { get; set; } = new List<UserRelationship>();

    public virtual ICollection<UserRelationship> UserRelationshipUsers { get; set; } = new List<UserRelationship>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    public virtual ICollection<UsersOnline> UsersOnlines { get; set; } = new List<UsersOnline>();
}
