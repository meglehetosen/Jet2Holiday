using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Portal
{
    public int PortalId { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int UserRegistration { get; set; }

    public int BannerAdvertising { get; set; }

    public int? AdministratorId { get; set; }

    public string? Currency { get; set; }

    public decimal HostFee { get; set; }

    public int HostSpace { get; set; }

    public int? AdministratorRoleId { get; set; }

    public int? RegisteredRoleId { get; set; }

    public Guid Guid { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? ProcessorUserId { get; set; }

    public string? ProcessorPassword { get; set; }

    public int? SiteLogHistory { get; set; }

    public string DefaultLanguage { get; set; } = null!;

    public int TimezoneOffset { get; set; }

    public string HomeDirectory { get; set; } = null!;

    public int PageQuota { get; set; }

    public int UserQuota { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public int? PortalGroupId { get; set; }

    public virtual ICollection<AnonymousUser> AnonymousUsers { get; set; } = new List<AnonymousUser>();

    public virtual ICollection<CoreMessagingSubscription> CoreMessagingSubscriptions { get; set; } = new List<CoreMessagingSubscription>();

    public virtual ICollection<CpCommonA3folder> CpCommonA3folders { get; set; } = new List<CpCommonA3folder>();

    public virtual ICollection<CrossPortalSetting> CrossPortalSettings { get; set; } = new List<CrossPortalSetting>();

    public virtual ICollection<File> Files { get; set; } = new List<File>();

    public virtual ICollection<FolderMapping> FolderMappings { get; set; } = new List<FolderMapping>();

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual ICollection<MobilePreviewProfile> MobilePreviewProfiles { get; set; } = new List<MobilePreviewProfile>();

    public virtual ICollection<MobileRedirection> MobileRedirections { get; set; } = new List<MobileRedirection>();

    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermissions { get; set; } = new List<PersonaBarMenuPermission>();

    public virtual ICollection<PortalAlias> PortalAliases { get; set; } = new List<PortalAlias>();

    public virtual ICollection<PortalDesktopModule> PortalDesktopModules { get; set; } = new List<PortalDesktopModule>();

    public virtual ICollection<PortalLanguage> PortalLanguages { get; set; } = new List<PortalLanguage>();

    public virtual ICollection<PortalLocalization> PortalLocalizations { get; set; } = new List<PortalLocalization>();

    public virtual ICollection<PortalPermission> PortalPermissions { get; set; } = new List<PortalPermission>();

    public virtual ICollection<PortalSetting> PortalSettings { get; set; } = new List<PortalSetting>();

    public virtual ICollection<ProfilePropertyDefinition> ProfilePropertyDefinitions { get; set; } = new List<ProfilePropertyDefinition>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Relationship> Relationships { get; set; } = new List<Relationship>();

    public virtual ICollection<RoleGroup> RoleGroups { get; set; } = new List<RoleGroup>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<SiteLog> SiteLogs { get; set; } = new List<SiteLog>();

    public virtual ICollection<SystemMessage> SystemMessages { get; set; } = new List<SystemMessage>();

    public virtual ICollection<Tab> Tabs { get; set; } = new List<Tab>();

    public virtual ICollection<UrlTracking> UrlTrackings { get; set; } = new List<UrlTracking>();

    public virtual ICollection<Url> Urls { get; set; } = new List<Url>();

    public virtual ICollection<UserPortal> UserPortals { get; set; } = new List<UserPortal>();

    public virtual ICollection<UsersOnline> UsersOnlines { get; set; } = new List<UsersOnline>();
}
