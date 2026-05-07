using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace kliens_alkalmazas.Models;

public partial class Jet2HolidaySqldbContext : DbContext
{
    public Jet2HolidaySqldbContext()
    {
    }

    public Jet2HolidaySqldbContext(DbContextOptions<Jet2HolidaySqldbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnonymousUser> AnonymousUsers { get; set; }

    public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }

    public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; }

    public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }

    public virtual DbSet<AspnetUser> AspnetUsers { get; set; }

    public virtual DbSet<Assembly> Assemblies { get; set; }

    public virtual DbSet<AuthCookie> AuthCookies { get; set; }

    public virtual DbSet<Authentication> Authentications { get; set; }

    public virtual DbSet<CkeSetting> CkeSettings { get; set; }

    public virtual DbSet<ContentItem> ContentItems { get; set; }

    public virtual DbSet<ContentItemsMetaDatum> ContentItemsMetaData { get; set; }

    public virtual DbSet<ContentItemsTag> ContentItemsTags { get; set; }

    public virtual DbSet<ContentType> ContentTypes { get; set; }

    public virtual DbSet<ContentWorkflow> ContentWorkflows { get; set; }

    public virtual DbSet<ContentWorkflowAction> ContentWorkflowActions { get; set; }

    public virtual DbSet<ContentWorkflowLog> ContentWorkflowLogs { get; set; }

    public virtual DbSet<ContentWorkflowSource> ContentWorkflowSources { get; set; }

    public virtual DbSet<ContentWorkflowState> ContentWorkflowStates { get; set; }

    public virtual DbSet<ContentWorkflowStatePermission> ContentWorkflowStatePermissions { get; set; }

    public virtual DbSet<CoreMessagingMessage> CoreMessagingMessages { get; set; }

    public virtual DbSet<CoreMessagingMessageAttachment> CoreMessagingMessageAttachments { get; set; }

    public virtual DbSet<CoreMessagingMessageRecipient> CoreMessagingMessageRecipients { get; set; }

    public virtual DbSet<CoreMessagingNotificationType> CoreMessagingNotificationTypes { get; set; }

    public virtual DbSet<CoreMessagingNotificationTypeAction> CoreMessagingNotificationTypeActions { get; set; }

    public virtual DbSet<CoreMessagingSubscription> CoreMessagingSubscriptions { get; set; }

    public virtual DbSet<CoreMessagingSubscriptionType> CoreMessagingSubscriptionTypes { get; set; }

    public virtual DbSet<CoreMessagingUserPreference> CoreMessagingUserPreferences { get; set; }

    public virtual DbSet<CpCommonA3file> CpCommonA3files { get; set; }

    public virtual DbSet<CpCommonA3folder> CpCommonA3folders { get; set; }

    public virtual DbSet<CrossPortalSetting> CrossPortalSettings { get; set; }

    public virtual DbSet<DesktopModule> DesktopModules { get; set; }

    public virtual DbSet<DesktopModulePermission> DesktopModulePermissions { get; set; }

    public virtual DbSet<DnnBceHelloWorldItem> DnnBceHelloWorldItems { get; set; }

    public virtual DbSet<EventLog> EventLogs { get; set; }

    public virtual DbSet<EventLogConfig> EventLogConfigs { get; set; }

    public virtual DbSet<EventLogType> EventLogTypes { get; set; }

    public virtual DbSet<EventQueue> EventQueues { get; set; }

    public virtual DbSet<Exception> Exceptions { get; set; }

    public virtual DbSet<ExceptionEvent> ExceptionEvents { get; set; }

    public virtual DbSet<ExportImportCheckpoint> ExportImportCheckpoints { get; set; }

    public virtual DbSet<ExportImportJob> ExportImportJobs { get; set; }

    public virtual DbSet<ExportImportJobLog> ExportImportJobLogs { get; set; }

    public virtual DbSet<ExportImportSetting> ExportImportSettings { get; set; }

    public virtual DbSet<ExtensionUrlProvider> ExtensionUrlProviders { get; set; }

    public virtual DbSet<ExtensionUrlProviderConfiguration> ExtensionUrlProviderConfigurations { get; set; }

    public virtual DbSet<ExtensionUrlProviderSetting> ExtensionUrlProviderSettings { get; set; }

    public virtual DbSet<ExtensionUrlProviderTab> ExtensionUrlProviderTabs { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<FileVersion> FileVersions { get; set; }

    public virtual DbSet<Foglala> Foglalas { get; set; }

    public virtual DbSet<Folder> Folders { get; set; }

    public virtual DbSet<FolderMapping> FolderMappings { get; set; }

    public virtual DbSet<FolderMappingsSetting> FolderMappingsSettings { get; set; }

    public virtual DbSet<FolderPermission> FolderPermissions { get; set; }

    public virtual DbSet<HccAddress> HccAddresses { get; set; }

    public virtual DbSet<HccAffiliate> HccAffiliates { get; set; }

    public virtual DbSet<HccAffiliatePayment> HccAffiliatePayments { get; set; }

    public virtual DbSet<HccAffiliateReferral> HccAffiliateReferrals { get; set; }

    public virtual DbSet<HccAnalyticsEvent> HccAnalyticsEvents { get; set; }

    public virtual DbSet<HccApiKey> HccApiKeys { get; set; }

    public virtual DbSet<HccAudit> HccAudits { get; set; }

    public virtual DbSet<HccAuthToken> HccAuthTokens { get; set; }

    public virtual DbSet<HccBundledProduct> HccBundledProducts { get; set; }

    public virtual DbSet<HccCatalogRole> HccCatalogRoles { get; set; }

    public virtual DbSet<HccCategory> HccCategories { get; set; }

    public virtual DbSet<HccCategoryTranslation> HccCategoryTranslations { get; set; }

    public virtual DbSet<HccCategoryXproperty> HccCategoryXproperties { get; set; }

    public virtual DbSet<HccContentBlock> HccContentBlocks { get; set; }

    public virtual DbSet<HccContentBlockTranslation> HccContentBlockTranslations { get; set; }

    public virtual DbSet<HccContentColumn> HccContentColumns { get; set; }

    public virtual DbSet<HccCountry> HccCountries { get; set; }

    public virtual DbSet<HccCountryTranslation> HccCountryTranslations { get; set; }

    public virtual DbSet<HccCustomUrl> HccCustomUrls { get; set; }

    public virtual DbSet<HccFraud> HccFrauds { get; set; }

    public virtual DbSet<HccGiftCard> HccGiftCards { get; set; }

    public virtual DbSet<HccHtmlTemplate> HccHtmlTemplates { get; set; }

    public virtual DbSet<HccHtmlTemplateTranslation> HccHtmlTemplateTranslations { get; set; }

    public virtual DbSet<HccLineItem> HccLineItems { get; set; }

    public virtual DbSet<HccMailingList> HccMailingLists { get; set; }

    public virtual DbSet<HccMailingListMember> HccMailingListMembers { get; set; }

    public virtual DbSet<HccManufacturer> HccManufacturers { get; set; }

    public virtual DbSet<HccMembershipProductType> HccMembershipProductTypes { get; set; }

    public virtual DbSet<HccNews> HccNews { get; set; }

    public virtual DbSet<HccOrder> HccOrders { get; set; }

    public virtual DbSet<HccOrderCoupon> HccOrderCoupons { get; set; }

    public virtual DbSet<HccOrderNote> HccOrderNotes { get; set; }

    public virtual DbSet<HccOrderPackage> HccOrderPackages { get; set; }

    public virtual DbSet<HccOrderTransaction> HccOrderTransactions { get; set; }

    public virtual DbSet<HccPriceGroup> HccPriceGroups { get; set; }

    public virtual DbSet<HccProduct> HccProducts { get; set; }

    public virtual DbSet<HccProductFile> HccProductFiles { get; set; }

    public virtual DbSet<HccProductFileXproduct> HccProductFileXproducts { get; set; }

    public virtual DbSet<HccProductImage> HccProductImages { get; set; }

    public virtual DbSet<HccProductInventory> HccProductInventories { get; set; }

    public virtual DbSet<HccProductOption> HccProductOptions { get; set; }

    public virtual DbSet<HccProductOptionItemTranslation> HccProductOptionItemTranslations { get; set; }

    public virtual DbSet<HccProductOptionTranslation> HccProductOptionTranslations { get; set; }

    public virtual DbSet<HccProductOptionsItem> HccProductOptionsItems { get; set; }

    public virtual DbSet<HccProductProperty> HccProductProperties { get; set; }

    public virtual DbSet<HccProductPropertyChoice> HccProductPropertyChoices { get; set; }

    public virtual DbSet<HccProductPropertyChoiceTranslation> HccProductPropertyChoiceTranslations { get; set; }

    public virtual DbSet<HccProductPropertyTranslation> HccProductPropertyTranslations { get; set; }

    public virtual DbSet<HccProductPropertyValue> HccProductPropertyValues { get; set; }

    public virtual DbSet<HccProductPropertyValueTranslation> HccProductPropertyValueTranslations { get; set; }

    public virtual DbSet<HccProductRelationship> HccProductRelationships { get; set; }

    public virtual DbSet<HccProductReview> HccProductReviews { get; set; }

    public virtual DbSet<HccProductTranslation> HccProductTranslations { get; set; }

    public virtual DbSet<HccProductType> HccProductTypes { get; set; }

    public virtual DbSet<HccProductTypeTranslation> HccProductTypeTranslations { get; set; }

    public virtual DbSet<HccProductTypeXproductProperty> HccProductTypeXproductProperties { get; set; }

    public virtual DbSet<HccProductVolumeDiscount> HccProductVolumeDiscounts { get; set; }

    public virtual DbSet<HccProductXcategory> HccProductXcategories { get; set; }

    public virtual DbSet<HccProductXoption> HccProductXoptions { get; set; }

    public virtual DbSet<HccPromotion> HccPromotions { get; set; }

    public virtual DbSet<HccPromotionTranslation> HccPromotionTranslations { get; set; }

    public virtual DbSet<HccQueuedTask> HccQueuedTasks { get; set; }

    public virtual DbSet<HccRegion> HccRegions { get; set; }

    public virtual DbSet<HccRegionTranslation> HccRegionTranslations { get; set; }

    public virtual DbSet<HccRewardsPoint> HccRewardsPoints { get; set; }

    public virtual DbSet<HccRma> HccRmas { get; set; }

    public virtual DbSet<HccRmaitem> HccRmaitems { get; set; }

    public virtual DbSet<HccSearchLexicon> HccSearchLexicons { get; set; }

    public virtual DbSet<HccSearchObject> HccSearchObjects { get; set; }

    public virtual DbSet<HccSearchObjectWord> HccSearchObjectWords { get; set; }

    public virtual DbSet<HccSearchQuery> HccSearchQueries { get; set; }

    public virtual DbSet<HccShippingMethod> HccShippingMethods { get; set; }

    public virtual DbSet<HccShippingMethodTranslation> HccShippingMethodTranslations { get; set; }

    public virtual DbSet<HccShippingZone> HccShippingZones { get; set; }

    public virtual DbSet<HccStore> HccStores { get; set; }

    public virtual DbSet<HccStoreDomain> HccStoreDomains { get; set; }

    public virtual DbSet<HccStoreSetting> HccStoreSettings { get; set; }

    public virtual DbSet<HccStoreSettingsTranslation> HccStoreSettingsTranslations { get; set; }

    public virtual DbSet<HccStoresXuser> HccStoresXusers { get; set; }

    public virtual DbSet<HccTaxSchedule> HccTaxSchedules { get; set; }

    public virtual DbSet<HccTaxis> HccTaxes { get; set; }

    public virtual DbSet<HccUser> HccUsers { get; set; }

    public virtual DbSet<HccUserAccount> HccUserAccounts { get; set; }

    public virtual DbSet<HccUserQuestion> HccUserQuestions { get; set; }

    public virtual DbSet<HccUserXcontact> HccUserXcontacts { get; set; }

    public virtual DbSet<HccUsgeoDatum> HccUsgeoData { get; set; }

    public virtual DbSet<HccVariant> HccVariants { get; set; }

    public virtual DbSet<HccVendor> HccVendors { get; set; }

    public virtual DbSet<HccWishListItem> HccWishListItems { get; set; }

    public virtual DbSet<HostSetting> HostSettings { get; set; }

    public virtual DbSet<HtmlText> HtmlTexts { get; set; }

    public virtual DbSet<HtmlTextLog> HtmlTextLogs { get; set; }

    public virtual DbSet<HtmlTextUser> HtmlTextUsers { get; set; }

    public virtual DbSet<Ipfilter> Ipfilters { get; set; }

    public virtual DbSet<JavaScriptLibrary> JavaScriptLibraries { get; set; }

    public virtual DbSet<Journal> Journals { get; set; }

    public virtual DbSet<JournalAccess> JournalAccesses { get; set; }

    public virtual DbSet<JournalComment> JournalComments { get; set; }

    public virtual DbSet<JournalDatum> JournalData { get; set; }

    public virtual DbSet<JournalSecurity> JournalSecurities { get; set; }

    public virtual DbSet<JournalType> JournalTypes { get; set; }

    public virtual DbSet<JournalTypeFilter> JournalTypeFilters { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LanguagePack> LanguagePacks { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<MessagingMessage> MessagingMessages { get; set; }

    public virtual DbSet<MetaData> MetaData { get; set; }

    public virtual DbSet<MobilePreviewProfile> MobilePreviewProfiles { get; set; }

    public virtual DbSet<MobileRedirection> MobileRedirections { get; set; }

    public virtual DbSet<MobileRedirectionRule> MobileRedirectionRules { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<ModuleControl> ModuleControls { get; set; }

    public virtual DbSet<ModuleDefinition> ModuleDefinitions { get; set; }

    public virtual DbSet<ModulePermission> ModulePermissions { get; set; }

    public virtual DbSet<ModuleSetting> ModuleSettings { get; set; }

    public virtual DbSet<OutputCache> OutputCaches { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<PackageDependency> PackageDependencies { get; set; }

    public virtual DbSet<PackageType> PackageTypes { get; set; }

    public virtual DbSet<PasswordHistory> PasswordHistories { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PersonaBarExtension> PersonaBarExtensions { get; set; }

    public virtual DbSet<PersonaBarMenu> PersonaBarMenus { get; set; }

    public virtual DbSet<PersonaBarMenuDefaultPermission> PersonaBarMenuDefaultPermissions { get; set; }

    public virtual DbSet<PersonaBarMenuPermission> PersonaBarMenuPermissions { get; set; }

    public virtual DbSet<PersonaBarPermission> PersonaBarPermissions { get; set; }

    public virtual DbSet<Portal> Portals { get; set; }

    public virtual DbSet<PortalAlias> PortalAliases { get; set; }

    public virtual DbSet<PortalDesktopModule> PortalDesktopModules { get; set; }

    public virtual DbSet<PortalGroup> PortalGroups { get; set; }

    public virtual DbSet<PortalLanguage> PortalLanguages { get; set; }

    public virtual DbSet<PortalLocalization> PortalLocalizations { get; set; }

    public virtual DbSet<PortalPermission> PortalPermissions { get; set; }

    public virtual DbSet<PortalSetting> PortalSettings { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<ProfilePropertyDefinition> ProfilePropertyDefinitions { get; set; }

    public virtual DbSet<RedirectMessage> RedirectMessages { get; set; }

    public virtual DbSet<Relationship> Relationships { get; set; }

    public virtual DbSet<RelationshipType> RelationshipTypes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleGroup> RoleGroups { get; set; }

    public virtual DbSet<RoleSetting> RoleSettings { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleHistory> ScheduleHistories { get; set; }

    public virtual DbSet<ScheduleItemSetting> ScheduleItemSettings { get; set; }

    public virtual DbSet<SearchCommonWord> SearchCommonWords { get; set; }

    public virtual DbSet<SearchDeletedItem> SearchDeletedItems { get; set; }

    public virtual DbSet<SearchIndexer> SearchIndexers { get; set; }

    public virtual DbSet<SearchStopWord> SearchStopWords { get; set; }

    public virtual DbSet<SearchType> SearchTypes { get; set; }

    public virtual DbSet<SiteLog> SiteLogs { get; set; }

    public virtual DbSet<Skin> Skins { get; set; }

    public virtual DbSet<SkinControl> SkinControls { get; set; }

    public virtual DbSet<SkinPackage> SkinPackages { get; set; }

    public virtual DbSet<Sqlquery> Sqlqueries { get; set; }

    public virtual DbSet<SynonymsGroup> SynonymsGroups { get; set; }

    public virtual DbSet<SystemMessage> SystemMessages { get; set; }

    public virtual DbSet<Tab> Tabs { get; set; }

    public virtual DbSet<TabAliasSkin> TabAliasSkins { get; set; }

    public virtual DbSet<TabModule> TabModules { get; set; }

    public virtual DbSet<TabModuleSetting> TabModuleSettings { get; set; }

    public virtual DbSet<TabPermission> TabPermissions { get; set; }

    public virtual DbSet<TabSetting> TabSettings { get; set; }

    public virtual DbSet<TabUrl> TabUrls { get; set; }

    public virtual DbSet<TabVersion> TabVersions { get; set; }

    public virtual DbSet<TabVersionDetail> TabVersionDetails { get; set; }

    public virtual DbSet<TaxonomyScopeType> TaxonomyScopeTypes { get; set; }

    public virtual DbSet<TaxonomyTerm> TaxonomyTerms { get; set; }

    public virtual DbSet<TaxonomyVocabulary> TaxonomyVocabularies { get; set; }

    public virtual DbSet<TaxonomyVocabularyType> TaxonomyVocabularyTypes { get; set; }

    public virtual DbSet<Url> Urls { get; set; }

    public virtual DbSet<UrlLog> UrlLogs { get; set; }

    public virtual DbSet<UrlTracking> UrlTrackings { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAuthentication> UserAuthentications { get; set; }

    public virtual DbSet<UserPortal> UserPortals { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

    public virtual DbSet<UserRelationship> UserRelationships { get; set; }

    public virtual DbSet<UserRelationshipPreference> UserRelationshipPreferences { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UsersOnline> UsersOnlines { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }

    public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; }

    public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }

    public virtual DbSet<VwContentWorkflowStatePermission> VwContentWorkflowStatePermissions { get; set; }

    public virtual DbSet<VwContentWorkflowUsage> VwContentWorkflowUsages { get; set; }

    public virtual DbSet<VwCoreMessagingMessage> VwCoreMessagingMessages { get; set; }

    public virtual DbSet<VwDesktopModule> VwDesktopModules { get; set; }

    public virtual DbSet<VwDesktopModulePermission> VwDesktopModulePermissions { get; set; }

    public virtual DbSet<VwEventLog> VwEventLogs { get; set; }

    public virtual DbSet<VwExtensionUrlProvider> VwExtensionUrlProviders { get; set; }

    public virtual DbSet<VwFile> VwFiles { get; set; }

    public virtual DbSet<VwFolderPermission> VwFolderPermissions { get; set; }

    public virtual DbSet<VwList> VwLists { get; set; }

    public virtual DbSet<VwMasterPortal> VwMasterPortals { get; set; }

    public virtual DbSet<VwMessagesForDispatch> VwMessagesForDispatches { get; set; }

    public virtual DbSet<VwModule> VwModules { get; set; }

    public virtual DbSet<VwModulePermission> VwModulePermissions { get; set; }

    public virtual DbSet<VwPersonaBarMenuPermission> VwPersonaBarMenuPermissions { get; set; }

    public virtual DbSet<VwPortal> VwPortals { get; set; }

    public virtual DbSet<VwPortalPermission> VwPortalPermissions { get; set; }

    public virtual DbSet<VwPortalsDefaultLanguage> VwPortalsDefaultLanguages { get; set; }

    public virtual DbSet<VwProfile> VwProfiles { get; set; }

    public virtual DbSet<VwPublishedFile> VwPublishedFiles { get; set; }

    public virtual DbSet<VwTab> VwTabs { get; set; }

    public virtual DbSet<VwTabModule> VwTabModules { get; set; }

    public virtual DbSet<VwTabPermission> VwTabPermissions { get; set; }

    public virtual DbSet<VwUser> VwUsers { get; set; }

    public virtual DbSet<VwUserRole> VwUserRoles { get; set; }

    public virtual DbSet<WebServer> WebServers { get; set; }

    public virtual DbSet<Workflow> Workflows { get; set; }

    public virtual DbSet<WorkflowState> WorkflowStates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=INFOREND07\\SQLEXPRESS;Initial Catalog=Jet2HolidaySQLdb;Persist Security Info=True;User ID=Jet2HolidaySQLUser;Password=legyen5os@;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnonymousUser>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.PortalId });

            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UserID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastActiveDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TabId).HasColumnName("TabID");

            entity.HasOne(d => d.Portal).WithMany(p => p.AnonymousUsers)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_AnonymousUsers_Portals");
        });

        modelBuilder.Entity<AspnetApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId)
                .HasName("PK__aspnet_A__C93A4C98B71B327D")
                .IsClustered(false);

            entity.ToTable("aspnet_Applications");

            entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_A__17477DE4CE67EFDB").IsUnique();

            entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_A__309103312CF4FF4E").IsUnique();

            entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index").IsClustered();

            entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ApplicationName).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspnetMembership>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_M__1788CC4DDF58B0F1")
                .IsClustered(false);

            entity.ToTable("aspnet_Membership");

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index").IsClustered();

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredEmail).HasMaxLength(256);
            entity.Property(e => e.MobilePin)
                .HasMaxLength(16)
                .HasColumnName("MobilePIN");
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordAnswer).HasMaxLength(128);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.PasswordSalt).HasMaxLength(128);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetMemberships)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__Appli__3F1C4B12");

            entity.HasOne(d => d.User).WithOne(p => p.AspnetMembership)
                .HasForeignKey<AspnetMembership>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__UserI__40106F4B");
        });

        modelBuilder.Entity<AspnetSchemaVersion>(entity =>
        {
            entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion }).HasName("PK__aspnet_S__5A1E6BC1B095EE22");

            entity.ToTable("aspnet_SchemaVersions");

            entity.Property(e => e.Feature).HasMaxLength(128);
            entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
        });

        modelBuilder.Entity<AspnetUser>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_U__1788CC4D6E4731AF")
                .IsClustered(false);

            entity.ToTable("aspnet_Users");

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate }, "aspnet_Users_Index2");

            entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredUserName).HasMaxLength(256);
            entity.Property(e => e.MobileAlias)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetUsers)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Us__Appli__2EE5E349");
        });

        modelBuilder.Entity<Assembly>(entity =>
        {
            entity.HasKey(e => e.AssemblyId).HasName("PK_PackageAssemblies");

            entity.Property(e => e.AssemblyId).HasColumnName("AssemblyID");
            entity.Property(e => e.AssemblyName).HasMaxLength(250);
            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.Version).HasMaxLength(20);

            entity.HasOne(d => d.Package).WithMany(p => p.Assemblies)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PackageAssemblies_PackageAssemblies");
        });

        modelBuilder.Entity<AuthCookie>(entity =>
        {
            entity.HasKey(e => e.CookieId);

            entity.HasIndex(e => e.CookieValue, "IX_AuthCookies_CookieValue").IsUnique();

            entity.Property(e => e.CookieValue).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ExpiresOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Authentication>(entity =>
        {
            entity.ToTable("Authentication");

            entity.Property(e => e.AuthenticationId).HasColumnName("AuthenticationID");
            entity.Property(e => e.AuthenticationType).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LoginControlSrc).HasMaxLength(250);
            entity.Property(e => e.LogoffControlSrc).HasMaxLength(250);
            entity.Property(e => e.PackageId)
                .HasDefaultValue(-1)
                .HasColumnName("PackageID");
            entity.Property(e => e.SettingsControlSrc).HasMaxLength(250);

            entity.HasOne(d => d.Package).WithMany(p => p.Authentications)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK_Authentication_Packages");
        });

        modelBuilder.Entity<CkeSetting>(entity =>
        {
            entity.HasKey(e => e.SettingName);

            entity.ToTable("CKE_Settings");

            entity.Property(e => e.SettingName).HasMaxLength(300);
            entity.Property(e => e.SettingValue).HasColumnType("ntext");
        });

        modelBuilder.Entity<ContentItem>(entity =>
        {
            entity.HasIndex(e => e.TabId, "IX_ContentItems_TabID");

            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.ContentKey).HasMaxLength(250);
            entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.TabId).HasColumnName("TabID");

            entity.HasOne(d => d.ContentType).WithMany(p => p.ContentItems)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContentItems_ContentTypes");

            entity.HasOne(d => d.State).WithMany(p => p.ContentItems)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_ContentItems_ContentWorkflowStates");
        });

        modelBuilder.Entity<ContentItemsMetaDatum>(entity =>
        {
            entity.HasKey(e => e.ContentItemMetaDataId).HasName("PK_Content_MetaData");

            entity.ToTable("ContentItems_MetaData");

            entity.HasIndex(e => e.ContentItemId, "IX_ContentItems_MetaData_ContentItemId");

            entity.HasIndex(e => new { e.ContentItemId, e.MetaDataId }, "IX_ContentItems_MetaData_MetaDataID");

            entity.Property(e => e.ContentItemMetaDataId).HasColumnName("ContentItemMetaDataID");
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.MetaDataId).HasColumnName("MetaDataID");

            entity.HasOne(d => d.ContentItem).WithMany(p => p.ContentItemsMetaData)
                .HasForeignKey(d => d.ContentItemId)
                .HasConstraintName("FK_ContentItems_MetaData_ContentItems");

            entity.HasOne(d => d.MetaData).WithMany(p => p.ContentItemsMetaData)
                .HasForeignKey(d => d.MetaDataId)
                .HasConstraintName("FK_ContentItems_MetaDataMetaData");
        });

        modelBuilder.Entity<ContentItemsTag>(entity =>
        {
            entity.HasKey(e => e.ContentItemTagId);

            entity.ToTable("ContentItems_Tags");

            entity.HasIndex(e => new { e.ContentItemId, e.TermId }, "IX_ContentItems_Tags").IsUnique();

            entity.HasIndex(e => e.TermId, "IX_ContentItems_Tags_TermID");

            entity.Property(e => e.ContentItemTagId).HasColumnName("ContentItemTagID");
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.TermId).HasColumnName("TermID");

            entity.HasOne(d => d.ContentItem).WithMany(p => p.ContentItemsTags)
                .HasForeignKey(d => d.ContentItemId)
                .HasConstraintName("FK_ContentItems_Tags_ContentItems");

            entity.HasOne(d => d.Term).WithMany(p => p.ContentItemsTags)
                .HasForeignKey(d => d.TermId)
                .HasConstraintName("FK_ContentItems_Tags_Taxonomy_Terms");
        });

        modelBuilder.Entity<ContentType>(entity =>
        {
            entity.HasIndex(e => e.ContentType1, "IX_ContentTypes_ContentType").IsUnique();

            entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");
            entity.Property(e => e.ContentType1)
                .HasMaxLength(100)
                .HasColumnName("ContentType");
        });

        modelBuilder.Entity<ContentWorkflow>(entity =>
        {
            entity.HasKey(e => e.WorkflowId);

            entity.HasIndex(e => new { e.PortalId, e.WorkflowName }, "IX_ContentWorkflows").IsUnique();

            entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.StartAfterCreating).HasDefaultValue(true);
            entity.Property(e => e.StartAfterEditing).HasDefaultValue(true);
            entity.Property(e => e.WorkflowKey)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.WorkflowName).HasMaxLength(40);
        });

        modelBuilder.Entity<ContentWorkflowAction>(entity =>
        {
            entity.HasKey(e => e.ActionId);

            entity.HasIndex(e => new { e.ContentTypeId, e.ActionType }, "ContentTypeId_ActionType").IsUnique();

            entity.Property(e => e.ActionSource).HasMaxLength(256);
            entity.Property(e => e.ActionType).HasMaxLength(50);

            entity.HasOne(d => d.ContentType).WithMany(p => p.ContentWorkflowActions)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("FK_ContentWorkflowActions_ContentTypes");
        });

        modelBuilder.Entity<ContentWorkflowLog>(entity =>
        {
            entity.HasKey(e => e.WorkflowLogId);

            entity.HasIndex(e => e.ContentItemId, "IX_ContentWorkflowLogs_ContentItemId");

            entity.Property(e => e.WorkflowLogId).HasColumnName("WorkflowLogID");
            entity.Property(e => e.Action).HasMaxLength(40);
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Type).HasDefaultValue(-1);
            entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

            entity.HasOne(d => d.ContentItem).WithMany(p => p.ContentWorkflowLogs)
                .HasForeignKey(d => d.ContentItemId)
                .HasConstraintName("FK_ContentWorkflowLogs_ContentItems");

            entity.HasOne(d => d.Workflow).WithMany(p => p.ContentWorkflowLogs)
                .HasForeignKey(d => d.WorkflowId)
                .HasConstraintName("FK_ContentWorkflowLogs_ContentWorkflows");
        });

        modelBuilder.Entity<ContentWorkflowSource>(entity =>
        {
            entity.HasKey(e => e.SourceId);

            entity.HasIndex(e => new { e.WorkflowId, e.SourceName }, "IX_ContentWorkflowSources").IsUnique();

            entity.Property(e => e.SourceId).HasColumnName("SourceID");
            entity.Property(e => e.SourceName).HasMaxLength(20);
            entity.Property(e => e.SourceType).HasMaxLength(250);
            entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

            entity.HasOne(d => d.Workflow).WithMany(p => p.ContentWorkflowSources)
                .HasForeignKey(d => d.WorkflowId)
                .HasConstraintName("FK_ContentWorkflowSources_ContentWorkflows");
        });

        modelBuilder.Entity<ContentWorkflowState>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.HasIndex(e => new { e.WorkflowId, e.StateName }, "IX_ContentWorkflowStates").IsUnique();

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.OnCompleteMessageBody)
                .HasMaxLength(1024)
                .HasDefaultValue("");
            entity.Property(e => e.OnCompleteMessageSubject)
                .HasMaxLength(256)
                .HasDefaultValue("");
            entity.Property(e => e.OnDiscardMessageBody)
                .HasMaxLength(1024)
                .HasDefaultValue("");
            entity.Property(e => e.OnDiscardMessageSubject)
                .HasMaxLength(256)
                .HasDefaultValue("");
            entity.Property(e => e.SendNotification).HasDefaultValue(true);
            entity.Property(e => e.SendNotificationToAdministrators).HasDefaultValue(true);
            entity.Property(e => e.StateName).HasMaxLength(40);
            entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

            entity.HasOne(d => d.Workflow).WithMany(p => p.ContentWorkflowStates)
                .HasForeignKey(d => d.WorkflowId)
                .HasConstraintName("FK_ContentWorkflowStates_ContentWorkflows");
        });

        modelBuilder.Entity<ContentWorkflowStatePermission>(entity =>
        {
            entity.HasKey(e => e.WorkflowStatePermissionId);

            entity.ToTable("ContentWorkflowStatePermission");

            entity.HasIndex(e => new { e.StateId, e.PermissionId, e.RoleId, e.UserId }, "IX_ContentWorkflowStatePermission").IsUnique();

            entity.Property(e => e.WorkflowStatePermissionId).HasColumnName("WorkflowStatePermissionID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Permission).WithMany(p => p.ContentWorkflowStatePermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK_ContentWorkflowStatePermission_Permission");

            entity.HasOne(d => d.State).WithMany(p => p.ContentWorkflowStatePermissions)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_ContentWorkflowStatePermission_ContentWorkflowStates");

            entity.HasOne(d => d.User).WithMany(p => p.ContentWorkflowStatePermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ContentWorkflowStatePermission_Users");
        });

        modelBuilder.Entity<CoreMessagingMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId);

            entity.ToTable("CoreMessaging_Messages");

            entity.HasIndex(e => new { e.MessageId, e.PortalId, e.NotificationTypeId, e.ExpirationDate }, "IX_CoreMessaging_Messages_Send_MessageID_PortalID_NotificationTypeID_ExpirationDate")
                .IsUnique()
                .IsDescending(false, false, false, true);

            entity.HasIndex(e => new { e.SenderUserId, e.CreatedOnDate }, "IX_CoreMessaging_Messages_SenderUserID").IsDescending(false, true);

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.Context).HasMaxLength(200);
            entity.Property(e => e.ConversationId).HasColumnName("ConversationID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.From).HasMaxLength(200);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.SenderUserId).HasColumnName("SenderUserID");
            entity.Property(e => e.Subject).HasMaxLength(400);
            entity.Property(e => e.To).HasMaxLength(2000);

            entity.HasOne(d => d.NotificationType).WithMany(p => p.CoreMessagingMessages)
                .HasForeignKey(d => d.NotificationTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CoreMessaging_Messages_CoreMessaging_NotificationTypes");
        });

        modelBuilder.Entity<CoreMessagingMessageAttachment>(entity =>
        {
            entity.HasKey(e => e.MessageAttachmentId);

            entity.ToTable("CoreMessaging_MessageAttachments");

            entity.HasIndex(e => e.MessageId, "IX_CoreMessaging_MessageAttachments_MessageID");

            entity.Property(e => e.MessageAttachmentId).HasColumnName("MessageAttachmentID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.FileId).HasColumnName("FileID");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.MessageId).HasColumnName("MessageID");

            entity.HasOne(d => d.Message).WithMany(p => p.CoreMessagingMessageAttachments)
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("FK_CoreMessaging_MessageAttachments_CoreMessaging_Messages");
        });

        modelBuilder.Entity<CoreMessagingMessageRecipient>(entity =>
        {
            entity.HasKey(e => e.RecipientId);

            entity.ToTable("CoreMessaging_MessageRecipients");

            entity.HasIndex(e => new { e.EmailSchedulerInstance, e.UserId, e.RecipientId }, "IX_CoreMessaging_MessageRecipients_ForDispatch")
                .IsUnique()
                .HasFilter("([EmailSent]=(0) AND [Read]=(0) AND [Archived]=(0))");

            entity.HasIndex(e => new { e.UserId, e.Read, e.Archived }, "IX_CoreMessaging_MessageRecipients_UserID").IsDescending(false, true, false);

            entity.HasIndex(e => new { e.MessageId, e.UserId, e.Read, e.SendToast }, "IX_CoreMessaging_MessageRecipients_UserID_MessageID_Read_SendToast").IsUnique();

            entity.Property(e => e.RecipientId).HasColumnName("RecipientID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.EmailSentDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Message).WithMany(p => p.CoreMessagingMessageRecipients)
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("FK_CoreMessaging_MessageRecipients_CoreMessaging_Messages");
        });

        modelBuilder.Entity<CoreMessagingNotificationType>(entity =>
        {
            entity.HasKey(e => e.NotificationTypeId);

            entity.ToTable("CoreMessaging_NotificationTypes");

            entity.HasIndex(e => e.Name, "IX_CoreMessaging_NotificationTypes").IsUnique();

            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Ttl).HasColumnName("TTL");

            entity.HasOne(d => d.DesktopModule).WithMany(p => p.CoreMessagingNotificationTypes)
                .HasForeignKey(d => d.DesktopModuleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CoreMessaging_NotificationTypes_DesktopModules");
        });

        modelBuilder.Entity<CoreMessagingNotificationTypeAction>(entity =>
        {
            entity.HasKey(e => e.NotificationTypeActionId);

            entity.ToTable("CoreMessaging_NotificationTypeActions");

            entity.HasIndex(e => e.NotificationTypeId, "IX_CoreMessaging_NotificationTypeActions");

            entity.Property(e => e.NotificationTypeActionId).HasColumnName("NotificationTypeActionID");
            entity.Property(e => e.Apicall)
                .HasMaxLength(500)
                .HasColumnName("APICall");
            entity.Property(e => e.ConfirmResourceKey).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DescriptionResourceKey).HasMaxLength(100);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.NameResourceKey).HasMaxLength(100);
            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");

            entity.HasOne(d => d.NotificationType).WithMany(p => p.CoreMessagingNotificationTypeActions)
                .HasForeignKey(d => d.NotificationTypeId)
                .HasConstraintName("FK_CoreMessaging_NotificationTypeActions_CoreMessaging_NotificationTypes");
        });

        modelBuilder.Entity<CoreMessagingSubscription>(entity =>
        {
            entity.HasKey(e => e.SubscriptionId);

            entity.ToTable("CoreMessaging_Subscriptions");

            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ObjectKey).HasMaxLength(255);

            entity.HasOne(d => d.Module).WithMany(p => p.CoreMessagingSubscriptions)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CoreMessaging_Subscriptions_Modules");

            entity.HasOne(d => d.Portal).WithMany(p => p.CoreMessagingSubscriptions)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CoreMessaging_Subscriptions_Portals");

            entity.HasOne(d => d.SubscriptionType).WithMany(p => p.CoreMessagingSubscriptions)
                .HasForeignKey(d => d.SubscriptionTypeId)
                .HasConstraintName("FK_CoreMessaging_Subscriptions_Subscriptions_Type");

            entity.HasOne(d => d.User).WithMany(p => p.CoreMessagingSubscriptions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_CoreMessaging_Subscriptions_Users");
        });

        modelBuilder.Entity<CoreMessagingSubscriptionType>(entity =>
        {
            entity.HasKey(e => e.SubscriptionTypeId);

            entity.ToTable("CoreMessaging_SubscriptionTypes");

            entity.HasIndex(e => e.SubscriptionName, "IX_CoreMessaging_SubscriptionTypes_SubscriptionName").IsUnique();

            entity.Property(e => e.FriendlyName).HasMaxLength(50);
            entity.Property(e => e.SubscriptionName).HasMaxLength(50);
        });

        modelBuilder.Entity<CoreMessagingUserPreference>(entity =>
        {
            entity.HasKey(e => e.UserPreferenceId);

            entity.ToTable("CoreMessaging_UserPreferences");
        });

        modelBuilder.Entity<CpCommonA3file>(entity =>
        {
            entity.ToTable("CP_Common_A3File");

            entity.Property(e => e.A3key)
                .HasMaxLength(200)
                .HasColumnName("A3Key");
            entity.Property(e => e.Bucket).HasMaxLength(200);
            entity.Property(e => e.ContentType).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Duration)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Extension).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Folder).WithMany(p => p.CpCommonA3files)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("FK_CP_Common_A3File_CP_Common_A3Folder");
        });

        modelBuilder.Entity<CpCommonA3folder>(entity =>
        {
            entity.ToTable("CP_Common_A3Folder");

            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Portal).WithMany(p => p.CpCommonA3folders)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_CP_Common_A3Folder_Portals");
        });

        modelBuilder.Entity<CrossPortalSetting>(entity =>
        {
            entity.HasKey(e => new { e.PortalId, e.SettingName }).HasName("PK_CrossArticle_PortalSetting");

            entity.ToTable("CrossPortalSetting");

            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.SettingName).HasMaxLength(300);
            entity.Property(e => e.SettingValue).HasMaxLength(2000);

            entity.HasOne(d => d.Portal).WithMany(p => p.CrossPortalSettings)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_CrossPortalSetting_Portals");
        });

        modelBuilder.Entity<DesktopModule>(entity =>
        {
            entity.HasIndex(e => e.FriendlyName, "IX_DesktopModules_FriendlyName");

            entity.HasIndex(e => e.ModuleName, "IX_DesktopModules_ModuleName").IsUnique();

            entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");
            entity.Property(e => e.AdminPage).HasMaxLength(128);
            entity.Property(e => e.BusinessControllerClass).HasMaxLength(200);
            entity.Property(e => e.CompatibleVersions).HasMaxLength(500);
            entity.Property(e => e.ContentItemId).HasDefaultValue(-1);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Dependencies).HasMaxLength(400);
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.FolderName).HasMaxLength(128);
            entity.Property(e => e.FriendlyName).HasMaxLength(128);
            entity.Property(e => e.HostPage).HasMaxLength(128);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleName).HasMaxLength(128);
            entity.Property(e => e.PackageId)
                .HasDefaultValue(-1)
                .HasColumnName("PackageID");
            entity.Property(e => e.Permissions).HasMaxLength(400);
            entity.Property(e => e.Version).HasMaxLength(50);

            entity.HasOne(d => d.Package).WithMany(p => p.DesktopModules)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK_DesktopModules_Packages");
        });

        modelBuilder.Entity<DesktopModulePermission>(entity =>
        {
            entity.ToTable("DesktopModulePermission");

            entity.HasIndex(e => new { e.PortalDesktopModuleId, e.PermissionId, e.RoleId, e.UserId }, "IX_DesktopModulePermission_DesktopModules").IsUnique();

            entity.HasIndex(e => new { e.RoleId, e.PortalDesktopModuleId, e.PermissionId }, "IX_DesktopModulePermission_Roles")
                .IsUnique()
                .HasFilter("([RoleID] IS NOT NULL)");

            entity.HasIndex(e => new { e.UserId, e.PortalDesktopModuleId, e.PermissionId }, "IX_DesktopModulePermission_Users")
                .IsUnique()
                .HasFilter("([UserID] IS NOT NULL)");

            entity.Property(e => e.DesktopModulePermissionId).HasColumnName("DesktopModulePermissionID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.PortalDesktopModuleId).HasColumnName("PortalDesktopModuleID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Permission).WithMany(p => p.DesktopModulePermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK_DesktopModulePermission_Permission");

            entity.HasOne(d => d.PortalDesktopModule).WithMany(p => p.DesktopModulePermissions)
                .HasForeignKey(d => d.PortalDesktopModuleId)
                .HasConstraintName("FK_DesktopModulePermission_PortalDesktopModules");

            entity.HasOne(d => d.Role).WithMany(p => p.DesktopModulePermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_DesktopModulePermission_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.DesktopModulePermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DesktopModulePermission_Users");
        });

        modelBuilder.Entity<DnnBceHelloWorldItem>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.ToTable("Dnn_Bce_HelloWorld_Items");

            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EventLog>(entity =>
        {
            entity.HasKey(e => e.LogEventId).HasName("PK_EventLogMaster");

            entity.ToTable("EventLog");

            entity.HasIndex(e => new { e.LogConfigId, e.LogNotificationPending, e.LogCreateDate }, "IX_EventLog_LogConfigID");

            entity.HasIndex(e => e.LogCreateDate, "IX_EventLog_LogCreateDate");

            entity.HasIndex(e => e.LogGuid, "IX_EventLog_LogGUID");

            entity.HasIndex(e => new { e.LogTypeKey, e.LogPortalId }, "IX_EventLog_LogType");

            entity.Property(e => e.LogEventId).HasColumnName("LogEventID");
            entity.Property(e => e.ExceptionHash)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LogConfigId).HasColumnName("LogConfigID");
            entity.Property(e => e.LogCreateDate).HasColumnType("datetime");
            entity.Property(e => e.LogGuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("LogGUID");
            entity.Property(e => e.LogPortalId).HasColumnName("LogPortalID");
            entity.Property(e => e.LogPortalName).HasMaxLength(100);
            entity.Property(e => e.LogProperties).HasColumnType("xml");
            entity.Property(e => e.LogServerName).HasMaxLength(50);
            entity.Property(e => e.LogTypeKey).HasMaxLength(35);
            entity.Property(e => e.LogUserId).HasColumnName("LogUserID");
            entity.Property(e => e.LogUserName).HasMaxLength(50);

            entity.HasOne(d => d.LogConfig).WithMany(p => p.EventLogs)
                .HasForeignKey(d => d.LogConfigId)
                .HasConstraintName("FK_EventLog_EventLogConfig");

            entity.HasOne(d => d.LogTypeKeyNavigation).WithMany(p => p.EventLogs)
                .HasForeignKey(d => d.LogTypeKey)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EventLog_EventLogTypes");
        });

        modelBuilder.Entity<EventLogConfig>(entity =>
        {
            entity.ToTable("EventLogConfig");

            entity.HasIndex(e => new { e.LogTypeKey, e.LogTypePortalId }, "IX_LogTypeKey_LogTypePortalID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LogTypeKey).HasMaxLength(35);
            entity.Property(e => e.LogTypePortalId).HasColumnName("LogTypePortalID");
            entity.Property(e => e.MailFromAddress).HasMaxLength(50);
            entity.Property(e => e.MailToAddress).HasMaxLength(50);

            entity.HasOne(d => d.LogTypeKeyNavigation).WithMany(p => p.EventLogConfigs)
                .HasForeignKey(d => d.LogTypeKey)
                .HasConstraintName("FK_EventLogConfig_EventLogTypes");
        });

        modelBuilder.Entity<EventLogType>(entity =>
        {
            entity.HasKey(e => e.LogTypeKey);

            entity.Property(e => e.LogTypeKey).HasMaxLength(35);
            entity.Property(e => e.LogTypeCssclass)
                .HasMaxLength(40)
                .HasColumnName("LogTypeCSSClass");
            entity.Property(e => e.LogTypeDescription).HasMaxLength(128);
            entity.Property(e => e.LogTypeFriendlyName).HasMaxLength(50);
            entity.Property(e => e.LogTypeOwner).HasMaxLength(100);
        });

        modelBuilder.Entity<EventQueue>(entity =>
        {
            entity.HasKey(e => e.EventMessageId);

            entity.ToTable("EventQueue");

            entity.Property(e => e.EventMessageId).HasColumnName("EventMessageID");
            entity.Property(e => e.Attributes).HasColumnType("ntext");
            entity.Property(e => e.AuthorizedRoles).HasMaxLength(250);
            entity.Property(e => e.Body).HasMaxLength(250);
            entity.Property(e => e.EventName).HasMaxLength(100);
            entity.Property(e => e.ExceptionMessage).HasMaxLength(250);
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessorCommand).HasMaxLength(250);
            entity.Property(e => e.ProcessorType).HasMaxLength(250);
            entity.Property(e => e.Sender).HasMaxLength(250);
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.Subscriber).HasMaxLength(100);
        });

        modelBuilder.Entity<Exception>(entity =>
        {
            entity.HasKey(e => e.ExceptionHash);

            entity.Property(e => e.ExceptionHash)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InnerMessage).HasMaxLength(500);
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(500);
        });

        modelBuilder.Entity<ExceptionEvent>(entity =>
        {
            entity.HasKey(e => e.LogEventId);

            entity.Property(e => e.LogEventId)
                .ValueGeneratedNever()
                .HasColumnName("LogEventID");
            entity.Property(e => e.AssemblyVersion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RawUrl).HasMaxLength(260);
            entity.Property(e => e.Referrer).HasMaxLength(260);
            entity.Property(e => e.UserAgent).HasMaxLength(260);

            entity.HasOne(d => d.LogEvent).WithOne(p => p.ExceptionEvent)
                .HasForeignKey<ExceptionEvent>(d => d.LogEventId)
                .HasConstraintName("FK_ExceptionEvents_LogEventId");
        });

        modelBuilder.Entity<ExportImportCheckpoint>(entity =>
        {
            entity.HasKey(e => e.CheckpointId);

            entity.HasIndex(e => e.Category, "IX_ExportImportCheckpoints_Category");

            entity.HasIndex(e => new { e.Category, e.AssemblyName, e.JobId }, "IX_ExportImportCheckpoints_Composite").IsUnique();

            entity.HasIndex(e => e.JobId, "IX_ExportImportCheckpoints_JobId");

            entity.Property(e => e.AssemblyName).HasMaxLength(200);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Completed).HasDefaultValue(false);
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Job).WithMany(p => p.ExportImportCheckpoints)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_ExportImportCheckpoints_JobId");
        });

        modelBuilder.Entity<ExportImportJob>(entity =>
        {
            entity.HasKey(e => e.JobId);

            entity.HasIndex(e => e.CreatedOnDate, "IX_ExportImportJobs_CreatedOn");

            entity.HasIndex(e => e.JobStatus, "IX_ExportImportJobs_JobStatus");

            entity.HasIndex(e => e.JobType, "IX_ExportImportJobs_JobType");

            entity.Property(e => e.CompletedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Directory).HasMaxLength(100);
            entity.Property(e => e.LastModifiedOnDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ExportImportJobLog>(entity =>
        {
            entity.HasKey(e => e.JobLogId);

            entity.HasIndex(e => e.JobId, "IX_ExportImportJobLogs_JobId");

            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Value).HasMaxLength(255);

            entity.HasOne(d => d.Job).WithMany(p => p.ExportImportJobLogs)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_ExportImportJobLogs_JobId");
        });

        modelBuilder.Entity<ExportImportSetting>(entity =>
        {
            entity.HasKey(e => e.SettingName);

            entity.Property(e => e.SettingName).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExtensionUrlProvider>(entity =>
        {
            entity.Property(e => e.ExtensionUrlProviderId).HasColumnName("ExtensionUrlProviderID");
            entity.Property(e => e.ProviderName).HasMaxLength(150);
            entity.Property(e => e.ProviderType).HasMaxLength(1000);
            entity.Property(e => e.SettingsControlSrc).HasMaxLength(1000);
        });

        modelBuilder.Entity<ExtensionUrlProviderConfiguration>(entity =>
        {
            entity.HasKey(e => new { e.ExtensionUrlProviderId, e.PortalId });

            entity.ToTable("ExtensionUrlProviderConfiguration");

            entity.Property(e => e.ExtensionUrlProviderId).HasColumnName("ExtensionUrlProviderID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
        });

        modelBuilder.Entity<ExtensionUrlProviderSetting>(entity =>
        {
            entity.HasKey(e => new { e.ExtensionUrlProviderId, e.PortalId, e.SettingName });

            entity.ToTable("ExtensionUrlProviderSetting");

            entity.Property(e => e.ExtensionUrlProviderId).HasColumnName("ExtensionUrlProviderID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.SettingName).HasMaxLength(100);
            entity.Property(e => e.SettingValue).HasMaxLength(2000);
        });

        modelBuilder.Entity<ExtensionUrlProviderTab>(entity =>
        {
            entity.HasKey(e => new { e.ExtensionUrlProviderId, e.PortalId, e.TabId });

            entity.ToTable("ExtensionUrlProviderTab");

            entity.Property(e => e.ExtensionUrlProviderId).HasColumnName("ExtensionUrlProviderID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.TabId).HasColumnName("TabID");
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity.HasKey(e => e.FileId).HasName("PK_File");

            entity.HasIndex(e => e.ContentItemId, "IX_Files_ContentID").HasFilter("([ContentItemId] IS NOT NULL)");

            entity.HasIndex(e => e.FileId, "IX_Files_FileID").HasFilter("([ContentItemId] IS NOT NULL)");

            entity.HasIndex(e => new { e.FolderId, e.FileName }, "IX_Files_FolderId_FileName");

            entity.HasIndex(e => new { e.PortalId, e.FolderId, e.FileName }, "IX_Files_PortalID").IsUnique();

            entity.HasIndex(e => e.UniqueId, "IX_Files_UniqueId").IsUnique();

            entity.Property(e => e.Content).HasColumnType("image");
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.ContentType).HasMaxLength(200);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Extension).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(246);
            entity.Property(e => e.Folder)
                .HasMaxLength(246)
                .HasComputedColumnSql("([dbo].[GetFileFolderFunc]([FolderID]))", false);
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.HasBeenPublished).HasDefaultValue(true);
            entity.Property(e => e.LastModificationTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PublishedVersion).HasDefaultValue(1);
            entity.Property(e => e.Sha1hash)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SHA1Hash");
            entity.Property(e => e.StartDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Title).HasMaxLength(256);
            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ContentItem).WithMany(p => p.Files)
                .HasForeignKey(d => d.ContentItemId)
                .HasConstraintName("FK_Files_ContentItems");

            entity.HasOne(d => d.FolderNavigation).WithMany(p => p.Files)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("FK_Files_Folders");

            entity.HasOne(d => d.Portal).WithMany(p => p.Files)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_Files_Portals");
        });

        modelBuilder.Entity<FileVersion>(entity =>
        {
            entity.HasKey(e => new { e.FileId, e.Version });

            entity.Property(e => e.Content).HasColumnType("image");
            entity.Property(e => e.ContentType).HasMaxLength(200);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Extension).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(246);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Sha1hash)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SHA1Hash");

            entity.HasOne(d => d.File).WithMany(p => p.FileVersions)
                .HasForeignKey(d => d.FileId)
                .HasConstraintName("FK_FileVersions_Files");
        });

        modelBuilder.Entity<Foglala>(entity =>
        {
            entity.HasKey(e => e.FoglalasId).HasName("PK__Foglalas__5BAF4B09008B6FF0");

            entity.HasIndex(e => e.BookingReference, "UX_Foglalas_BookingReference")
                .IsUnique()
                .HasFilter("([BookingReference] IS NOT NULL)");

            entity.Property(e => e.BookingReference).HasMaxLength(50);
            entity.Property(e => e.CancellationReason).HasMaxLength(255);
            entity.Property(e => e.EjszakakSzama).HasComputedColumnSql("(datediff(day,[ErkezesDatum],[TavozasDatum]))", true);
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasDefaultValue("");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LetrehozasDatuma)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Lokacio).HasMaxLength(150);
            entity.Property(e => e.Nev)
                .HasMaxLength(150)
                .HasDefaultValue("");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValue("Confirmed");
            entity.Property(e => e.Telefon).HasMaxLength(30);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.HandledByUser).WithMany(p => p.FoglalaHandledByUsers)
                .HasForeignKey(d => d.HandledByUserId)
                .HasConstraintName("FK__Foglalas__Handle__24C84789");

            entity.HasOne(d => d.OrderBvinNavigation).WithMany(p => p.Foglalas)
                .HasForeignKey(d => d.OrderBvin)
                .HasConstraintName("FK_Foglalas_hccOrder");

            entity.HasOne(d => d.ProductBvinNavigation).WithMany(p => p.Foglalas)
                .HasForeignKey(d => d.ProductBvin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Foglalas_Product");

            entity.HasOne(d => d.User).WithMany(p => p.FoglalaUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Foglalas_Users");
        });

        modelBuilder.Entity<Folder>(entity =>
        {
            entity.HasIndex(e => new { e.PortalId, e.FolderPath }, "IX_FolderPath").IsUnique();

            entity.HasIndex(e => e.FolderId, "IX_Folders_FolderID").IsUnique();

            entity.HasIndex(e => new { e.PortalId, e.ParentId, e.FolderPath }, "IX_Folders_ParentID");

            entity.HasIndex(e => e.UniqueId, "IX_Folders_UniqueId").IsUnique();

            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.FolderMappingId).HasColumnName("FolderMappingID");
            entity.Property(e => e.FolderPath).HasMaxLength(300);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MappedPath).HasMaxLength(300);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

            entity.HasOne(d => d.FolderMapping).WithMany(p => p.Folders)
                .HasForeignKey(d => d.FolderMappingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Folders_FolderMappings");

            entity.HasOne(d => d.Portal).WithMany(p => p.Folders)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Folders_Portals");

            entity.HasOne(d => d.Workflow).WithMany(p => p.Folders)
                .HasForeignKey(d => d.WorkflowId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Folders_ContentWorkflows");
        });

        modelBuilder.Entity<FolderMapping>(entity =>
        {
            entity.HasIndex(e => new { e.PortalId, e.MappingName }, "IX_FolderMappings").IsUnique();

            entity.Property(e => e.FolderMappingId).HasColumnName("FolderMappingID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.FolderProviderType).HasMaxLength(50);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.MappingName).HasMaxLength(50);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");

            entity.HasOne(d => d.Portal).WithMany(p => p.FolderMappings)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FolderMappings_Portals");
        });

        modelBuilder.Entity<FolderMappingsSetting>(entity =>
        {
            entity.HasKey(e => new { e.FolderMappingId, e.SettingName });

            entity.Property(e => e.FolderMappingId).HasColumnName("FolderMappingID");
            entity.Property(e => e.SettingName).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.SettingValue).HasMaxLength(2000);

            entity.HasOne(d => d.FolderMapping).WithMany(p => p.FolderMappingsSettings)
                .HasForeignKey(d => d.FolderMappingId)
                .HasConstraintName("FK_FolderMappingsSettings_FolderMappings");
        });

        modelBuilder.Entity<FolderPermission>(entity =>
        {
            entity.ToTable("FolderPermission");

            entity.HasIndex(e => new { e.FolderId, e.PermissionId, e.RoleId, e.UserId }, "IX_FolderPermission_Folders").IsUnique();

            entity.HasIndex(e => e.FolderId, "IX_FolderPermission_Modules");

            entity.HasIndex(e => e.PermissionId, "IX_FolderPermission_Permission");

            entity.HasIndex(e => new { e.RoleId, e.FolderId, e.PermissionId }, "IX_FolderPermission_Roles")
                .IsUnique()
                .HasFilter("([RoleID] IS NOT NULL)");

            entity.HasIndex(e => new { e.UserId, e.FolderId, e.PermissionId }, "IX_FolderPermission_Users")
                .IsUnique()
                .HasFilter("([UserID] IS NOT NULL)");

            entity.Property(e => e.FolderPermissionId).HasColumnName("FolderPermissionID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Folder).WithMany(p => p.FolderPermissions)
                .HasForeignKey(d => d.FolderId)
                .HasConstraintName("FK_FolderPermission_Folders");

            entity.HasOne(d => d.Permission).WithMany(p => p.FolderPermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK_FolderPermission_Permission");

            entity.HasOne(d => d.Role).WithMany(p => p.FolderPermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_FolderPermission_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.FolderPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FolderPermission_Users");
        });

        modelBuilder.Entity<HccAddress>(entity =>
        {
            entity.HasKey(e => e.Bvin).IsClustered(false);

            entity.ToTable("hcc_Address");

            entity.HasIndex(e => e.Id, "IX_hcc_Address")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.StoreId, "IX_hcc_Address_StoreId");

            entity.HasIndex(e => e.AddressType, "IX_hcc_Address_Type");

            entity.Property(e => e.Bvin)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("bvin");
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Company).HasMaxLength(255);
            entity.Property(e => e.CountryBvin)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.CountryName).HasMaxLength(255);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Line1).HasMaxLength(255);
            entity.Property(e => e.Line2).HasMaxLength(255);
            entity.Property(e => e.Line3).HasMaxLength(255);
            entity.Property(e => e.MiddleInitial).HasMaxLength(1);
            entity.Property(e => e.NickName).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(50);
            entity.Property(e => e.RegionBvin)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.RegionName).HasMaxLength(255);
            entity.Property(e => e.UserBvin)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.WebSiteUrl).HasMaxLength(255);
        });

        modelBuilder.Entity<HccAffiliate>(entity =>
        {
            entity.ToTable("hcc_Affiliate");

            entity.HasIndex(e => e.AffiliateId, "IX_hcc_Affiliate").IsUnique();

            entity.Property(e => e.AffiliateId)
                .HasMaxLength(50)
                .HasColumnName("AffiliateID");
            entity.Property(e => e.CommissionAmount).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DriversLicenseNumber).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.ReferralId)
                .HasMaxLength(50)
                .HasColumnName("ReferralID");
            entity.Property(e => e.TaxId)
                .HasMaxLength(100)
                .HasColumnName("TaxID");
            entity.Property(e => e.WebSiteUrl)
                .HasMaxLength(1000)
                .HasColumnName("WebSiteURL");
        });

        modelBuilder.Entity<HccAffiliatePayment>(entity =>
        {
            entity.ToTable("hcc_AffiliatePayments");

            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");

            entity.HasOne(d => d.Affiliate).WithMany(p => p.HccAffiliatePayments)
                .HasForeignKey(d => d.AffiliateId)
                .HasConstraintName("FK_hcc_AffiliatePayments_hcc_Affiliate");
        });

        modelBuilder.Entity<HccAffiliateReferral>(entity =>
        {
            entity.ToTable("hcc_AffiliateReferral");

            entity.Property(e => e.Referrerurl)
                .HasMaxLength(1000)
                .HasColumnName("referrerurl");
            entity.Property(e => e.TimeOfReferralUtc)
                .HasDefaultValueSql("('20130101')")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Affiliate).WithMany(p => p.HccAffiliateReferrals)
                .HasForeignKey(d => d.AffiliateId)
                .HasConstraintName("FK_hcc_AffiliateReferral_hcc_Affiliate");
        });

        modelBuilder.Entity<HccAnalyticsEvent>(entity =>
        {
            entity.HasKey(e => e.AnalyticsEventId);

            entity.ToTable("hcc_AnalyticsEvents");

            entity.HasIndex(e => new { e.StoreId, e.ObjectId, e.ShoppingSessionGuid }, "IX_hcc_AnalyticsEvents");

            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<HccApiKey>(entity =>
        {
            entity.ToTable("hcc_ApiKeys");

            entity.HasIndex(e => e.StoreId, "IX_hcc_ApiKeys_StoreId");

            entity.Property(e => e.ApiKey).HasMaxLength(100);
        });

        modelBuilder.Entity<HccAudit>(entity =>
        {
            entity.ToTable("hcc_Audit");

            entity.Property(e => e.ShortName).HasMaxLength(255);
            entity.Property(e => e.TimeStampUtc).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.UserIdText)
                .HasMaxLength(255)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<HccAuthToken>(entity =>
        {
            entity.ToTable("hcc_AuthTokens");

            entity.Property(e => e.Expires).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p.HccAuthTokens)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_AuthTokens_hcc_UserAccounts");
        });

        modelBuilder.Entity<HccBundledProduct>(entity =>
        {
            entity.ToTable("hcc_BundledProducts");

            entity.HasOne(d => d.Product).WithMany(p => p.HccBundledProducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_hcc_BundledProducts_hcc_Product");
        });

        modelBuilder.Entity<HccCatalogRole>(entity =>
        {
            entity.HasKey(e => e.CatalogRoleId);

            entity.ToTable("hcc_CatalogRoles");

            entity.Property(e => e.RoleName).HasMaxLength(250);

            entity.HasOne(d => d.Category).WithMany(p => p.HccCatalogRoles)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_hcc_CatalogRoles_hcc_Category");

            entity.HasOne(d => d.Product).WithMany(p => p.HccCatalogRoles)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_hcc_CatalogRoles_hcc_Product");

            entity.HasOne(d => d.ProductType).WithMany(p => p.HccCatalogRoles)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_hcc_CatalogRoles_hcc_ProductType");
        });

        modelBuilder.Entity<HccCategory>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_Category");

            entity.HasIndex(e => e.ParentId, "IX_hcc_Category");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.BannerImageUrl)
                .HasMaxLength(512)
                .HasColumnName("BannerImageURL");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomPageUrl)
                .HasMaxLength(512)
                .HasColumnName("CustomPageURL");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(512)
                .HasColumnName("ImageURL");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.PostContentColumnId).HasMaxLength(50);
            entity.Property(e => e.PreContentColumnId).HasMaxLength(50);
            entity.Property(e => e.ShowTitle).HasDefaultValue(1);
            entity.Property(e => e.TemplateName).HasMaxLength(512);
        });

        modelBuilder.Entity<HccCategoryTranslation>(entity =>
        {
            entity.HasKey(e => e.CategoryTranslationId);

            entity.ToTable("hcc_CategoryTranslations");

            entity.HasIndex(e => new { e.CategoryId, e.Culture }, "UK_hcc_CategoryTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.Description).HasColumnType("ntext");
            entity.Property(e => e.MetaDescription).HasMaxLength(255);
            entity.Property(e => e.MetaKeywords).HasMaxLength(255);
            entity.Property(e => e.MetaTitle).HasMaxLength(512);
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.Category).WithMany(p => p.HccCategoryTranslations)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_hcc_CategoryTranslations_hcc_Category");
        });

        modelBuilder.Entity<HccCategoryXproperty>(entity =>
        {
            entity.ToTable("hcc_CategoryXProperty");

            entity.Property(e => e.CategoryId).HasMaxLength(36);
            entity.Property(e => e.FilterName).HasMaxLength(255);
        });

        modelBuilder.Entity<HccContentBlock>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_ContentBlock");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.ColumnId).HasColumnName("ColumnID");
            entity.Property(e => e.ControlName).HasMaxLength(512);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.SerializedLists)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.SerializedSettings)
                .HasDefaultValue("")
                .HasColumnType("ntext");

            entity.HasOne(d => d.Column).WithMany(p => p.HccContentBlocks)
                .HasForeignKey(d => d.ColumnId)
                .HasConstraintName("FK_hcc_ContentBlock_hcc_ContentColumn");
        });

        modelBuilder.Entity<HccContentBlockTranslation>(entity =>
        {
            entity.HasKey(e => e.ContentBlockTranslationId);

            entity.ToTable("hcc_ContentBlockTranslations");

            entity.HasIndex(e => new { e.ContentBlockId, e.Culture }, "UK_hcc_ContentBlockTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.TextSettings).HasColumnType("ntext");

            entity.HasOne(d => d.ContentBlock).WithMany(p => p.HccContentBlockTranslations)
                .HasForeignKey(d => d.ContentBlockId)
                .HasConstraintName("FK_hcc_ContentBlockTranslations_hcc_ContentBlock");
        });

        modelBuilder.Entity<HccContentColumn>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_ContentColumn");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.DisplayName).HasMaxLength(512);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
        });

        modelBuilder.Entity<HccCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId);

            entity.ToTable("hcc_Countries");

            entity.Property(e => e.CountryId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.IsoAlpha3).HasMaxLength(10);
            entity.Property(e => e.IsoCode).HasMaxLength(10);
            entity.Property(e => e.IsoNumeric).HasMaxLength(10);
            entity.Property(e => e.PostalCodeValidationRegex).HasMaxLength(10);
            entity.Property(e => e.SystemName).HasMaxLength(255);
        });

        modelBuilder.Entity<HccCountryTranslation>(entity =>
        {
            entity.HasKey(e => e.CountryTranslationId);

            entity.ToTable("hcc_CountryTranslations");

            entity.HasIndex(e => new { e.CountryId, e.Culture }, "IX_hcc_CountryTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.DisplayName).HasMaxLength(255);

            entity.HasOne(d => d.Country).WithMany(p => p.HccCountryTranslations)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_hcc_CountryTranslations_hcc_Countries");
        });

        modelBuilder.Entity<HccCustomUrl>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_CustomUrl");

            entity.HasIndex(e => e.SystemData, "IX_hcc_CustomUrl");

            entity.Property(e => e.Bvin)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("bvin");
            entity.Property(e => e.IsPermanentRedirect).HasDefaultValue(true);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.SystemData).HasMaxLength(50);
        });

        modelBuilder.Entity<HccFraud>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_Fraud");

            entity.Property(e => e.Bvin)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("bvin");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.RuleValue).HasMaxLength(255);
        });

        modelBuilder.Entity<HccGiftCard>(entity =>
        {
            entity.HasKey(e => e.GiftCardId);

            entity.ToTable("hcc_GiftCard");

            entity.HasIndex(e => e.CardNumber, "UK_hcc_GiftCard").IsUnique();

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.CardNumber).HasMaxLength(50);
            entity.Property(e => e.ExpirationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.IssueDateUtc).HasColumnType("datetime");
            entity.Property(e => e.RecipientEmail).HasMaxLength(255);
            entity.Property(e => e.RecipientName).HasMaxLength(255);
            entity.Property(e => e.UsedAmount).HasColumnType("decimal(18, 10)");
        });

        modelBuilder.Entity<HccHtmlTemplate>(entity =>
        {
            entity.ToTable("hcc_HtmlTemplates");

            entity.HasIndex(e => e.StoreId, "IX_hcc_HtmlTemplates_StoreId");

            entity.Property(e => e.DisplayName).HasMaxLength(255);
            entity.Property(e => e.FromEmail).HasMaxLength(255);
            entity.Property(e => e.LastUpdatedUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<HccHtmlTemplateTranslation>(entity =>
        {
            entity.HasKey(e => e.HtmlTemplateTranslationId);

            entity.ToTable("hcc_HtmlTemplateTranslations");

            entity.HasIndex(e => new { e.HtmlTemplateId, e.Culture }, "UK_hcc_HtmlTemplateTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.Subject).HasMaxLength(1024);

            entity.HasOne(d => d.HtmlTemplate).WithMany(p => p.HccHtmlTemplateTranslations)
                .HasForeignKey(d => d.HtmlTemplateId)
                .HasConstraintName("FK_hcc_HtmlTemplateTranslations_hcc_HtmlTemplates");
        });

        modelBuilder.Entity<HccLineItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_LineItem_Id");

            entity.ToTable("hcc_LineItem");

            entity.HasIndex(e => e.OrderBvin, "IX_hcc_LineItem_1");

            entity.Property(e => e.AdjustedPrice).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.BasePrice).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.CustomProperties)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.DiscountDetails).HasDefaultValue("");
            entity.Property(e => e.ExtraShipCharge).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.IsNonShipping).HasDefaultValueSql("('')");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LineTotal).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductShippingHeight).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.ProductShippingLength).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.ProductShippingWeight).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.ProductShippingWidth).HasColumnType("numeric(10, 4)");
            entity.Property(e => e.ProductSku).HasMaxLength(50);
            entity.Property(e => e.PromotionIds).HasMaxLength(500);
            entity.Property(e => e.SelectionData).HasDefaultValue("");
            entity.Property(e => e.ShipFromAddress).HasDefaultValue("");
            entity.Property(e => e.ShipFromMode).HasDefaultValue(1);
            entity.Property(e => e.ShipFromNotificationId)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.ShippingCharge).HasDefaultValue(1);
            entity.Property(e => e.ShippingPortion).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.ShippingTaxRate).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.StatusCode)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.StatusName)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.TaxPortion).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.TaxScheduleId).HasDefaultValueSql("('')");
            entity.Property(e => e.VariantId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasDefaultValue("");

            entity.HasOne(d => d.OrderBvinNavigation).WithMany(p => p.HccLineItems)
                .HasForeignKey(d => d.OrderBvin)
                .HasConstraintName("FK_hcc_LineItem_hcc_LineItem");
        });

        modelBuilder.Entity<HccMailingList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_MailingList_1");

            entity.ToTable("hcc_MailingList");

            entity.Property(e => e.LastUpdatedUtc)
                .HasDefaultValueSql("('20130101')")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<HccMailingListMember>(entity =>
        {
            entity.ToTable("hcc_MailingListMember");

            entity.Property(e => e.EmailAddress).HasMaxLength(255);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.LastUpdatedUtc)
                .HasDefaultValueSql("('20130101')")
                .HasColumnType("datetime");
            entity.Property(e => e.ListId).HasColumnName("ListID");

            entity.HasOne(d => d.List).WithMany(p => p.HccMailingListMembers)
                .HasForeignKey(d => d.ListId)
                .HasConstraintName("FK_hcc_MailingListMember_hcc_MailingList");
        });

        modelBuilder.Entity<HccManufacturer>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_Manufacturer");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.Address).HasColumnType("ntext");
            entity.Property(e => e.DisplayName).HasMaxLength(255);
            entity.Property(e => e.DropShipEmailTemplateId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress).HasMaxLength(255);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
        });

        modelBuilder.Entity<HccMembershipProductType>(entity =>
        {
            entity.HasKey(e => e.ProductTypeBvin);

            entity.ToTable("hcc_MembershipProductType");

            entity.Property(e => e.ProductTypeBvin).ValueGeneratedNever();
            entity.Property(e => e.RoleName).HasMaxLength(250);

            entity.HasOne(d => d.ProductTypeBvinNavigation).WithOne(p => p.HccMembershipProductType)
                .HasForeignKey<HccMembershipProductType>(d => d.ProductTypeBvin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_MembershipProductType_hcc_ProductType");
        });

        modelBuilder.Entity<HccNews>(entity =>
        {
            entity.ToTable("hcc_News");

            entity.Property(e => e.TimeStampUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<HccOrder>(entity =>
        {
            entity.HasKey(e => e.Bvin).IsClustered(false);

            entity.ToTable("hcc_Order");

            entity.HasIndex(e => e.Id, "IX_hcc_Order")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.OrderNumber, "IX_hcc_Order_OrderNumber");

            entity.HasIndex(e => e.StoreId, "IX_hcc_Order_StoreId");

            entity.HasIndex(e => e.TimeOfOrder, "IX_hcc_Order_TimeOfOrder");

            entity.HasIndex(e => e.UserId, "IX_hcc_Order_UserId");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.AdjustedShippingTotal).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.BillingAddress).HasColumnType("ntext");
            entity.Property(e => e.CustomProperties)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.FraudScore)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.HandlingTotal).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Instructions).HasDefaultValue("");
            entity.Property(e => e.ItemsTax).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.OrderDiscountDetails).HasDefaultValue("");
            entity.Property(e => e.OrderDiscounts).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.ShippingAddress)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.ShippingDiscountDetails).HasDefaultValue("");
            entity.Property(e => e.ShippingDiscounts).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.ShippingMethodDisplayName)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.ShippingMethodId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ShippingProviderId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ShippingProviderServiceCode)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.ShippingTax).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.ShippingTaxRate).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.ShippingTotal).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.StatusCode)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.StatusName)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.TaxTotal).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.ThirdPartyOrderId)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.TimeOfOrder).HasColumnType("datetime");
            entity.Property(e => e.UsedCulture).HasMaxLength(10);
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HccOrderCoupon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_OrderCoupon_1");

            entity.ToTable("hcc_OrderCoupon");

            entity.HasIndex(e => e.OrderBvin, "IX_hcc_OrderCoupon_OrderBvin");

            entity.Property(e => e.CouponCode).HasMaxLength(50);
            entity.Property(e => e.LastUpdatedUtc).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasDefaultValue("");

            entity.HasOne(d => d.OrderBvinNavigation).WithMany(p => p.HccOrderCoupons)
                .HasForeignKey(d => d.OrderBvin)
                .HasConstraintName("FK_hcc_OrderCoupon_hcc_Order");
        });

        modelBuilder.Entity<HccOrderNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_OrderNote_1");

            entity.ToTable("hcc_OrderNote");

            entity.HasIndex(e => e.OrderId, "IX_hcc_OrderNote");

            entity.Property(e => e.AuditDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedUtc).HasColumnType("datetime");

            entity.HasOne(d => d.Order).WithMany(p => p.HccOrderNotes)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_hcc_OrderNote_hcc_Order");
        });

        modelBuilder.Entity<HccOrderPackage>(entity =>
        {
            entity.ToTable("hcc_OrderPackage");

            entity.HasIndex(e => e.OrderId, "IX_hcc_OrderPackage_OrderId");

            entity.Property(e => e.CustomProperties)
                .HasDefaultValue("n''")
                .HasColumnType("ntext");
            entity.Property(e => e.EstimatedShippingCost).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LastUpdatedUtc)
                .HasDefaultValueSql("('20130101')")
                .HasColumnType("datetime");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ShipDateUtc).HasColumnType("datetime");
            entity.Property(e => e.ShippingMethodId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.ShippingProviderId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.ShippingProviderServiceCode).HasMaxLength(255);
            entity.Property(e => e.TrackingNumber).HasMaxLength(255);
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Order).WithMany(p => p.HccOrderPackages)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_hcc_OrderPackage_hcc_Order");
        });

        modelBuilder.Entity<HccOrderTransaction>(entity =>
        {
            entity.ToTable("hcc_OrderTransactions");

            entity.HasIndex(e => e.OrderId, "IX_hcc_OrderTransactions_OrderId");

            entity.HasIndex(e => e.StoreId, "IX_hcc_OrderTransactions_StoreId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AdditionalSettings)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.CheckNumber)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.CompanyAccountNumber)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.CreditCard).HasColumnType("ntext");
            entity.Property(e => e.GiftCard).HasColumnType("ntext");
            entity.Property(e => e.LinkedToTransaction).HasMaxLength(50);
            entity.Property(e => e.Messages)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.MethodId).HasMaxLength(50);
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.RefNum1).HasMaxLength(255);
            entity.Property(e => e.RefNum2).HasMaxLength(255);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");

            entity.HasOne(d => d.Order).WithMany(p => p.HccOrderTransactions)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_hcc_OrderTransactions_hcc_Order");

            entity.HasOne(d => d.Store).WithMany(p => p.HccOrderTransactions)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_OrderTransactions_hcc_Stores");
        });

        modelBuilder.Entity<HccPriceGroup>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_PriceGroup");

            entity.Property(e => e.Bvin)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("bvin");
            entity.Property(e => e.AdjustmentAmount).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<HccProduct>(entity =>
        {
            entity.HasKey(e => e.Bvin).IsClustered(false);

            entity.ToTable("hcc_Product");

            entity.HasIndex(e => e.ManufacturerId, "IX_hcc_Product_ManufacturerId");

            entity.HasIndex(e => new { e.Status, e.Bvin }, "IX_hcc_Product_Status");

            entity.HasIndex(e => e.VendorId, "IX_hcc_Product_VendorId");

            entity.HasIndex(e => e.Id, "IX_hcc_Product_id")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => new { e.StoreId, e.Sku }, "UK_hcc_Product").IsUnique();

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomProperties).HasDefaultValue("");
            entity.Property(e => e.ExtraShipFee).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.GiftWrapPrice).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ImageFileMedium).HasMaxLength(512);
            entity.Property(e => e.ImageFileSmall).HasMaxLength(512);
            entity.Property(e => e.IsAvailableForSale).HasDefaultValue(true);
            entity.Property(e => e.IsSearchable).HasDefaultValue(true);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.ListPrice).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");
            entity.Property(e => e.PostContentColumnId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.PreContentColumnId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.RewriteUrl).HasDefaultValue("");
            entity.Property(e => e.ShippingCharge).HasDefaultValue(1);
            entity.Property(e => e.ShippingHeight).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.ShippingLength).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.ShippingWeight).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.ShippingWidth).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.SiteCost).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.SitePrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("SKU");
            entity.Property(e => e.TaxClass)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.TemplateName).HasMaxLength(512);
            entity.Property(e => e.UpchargeAmount)
                .HasDefaultValue(3m)
                .HasColumnType("decimal(18, 10)");
            entity.Property(e => e.UpchargeUnit)
                .HasMaxLength(255)
                .HasDefaultValue("1")
                .HasColumnName("UpchargeUnit ");
            entity.Property(e => e.VendorId).HasColumnName("VendorID");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.HccProducts)
                .HasForeignKey(d => d.ManufacturerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_hcc_Product_hcc_Manufacturer");

            entity.HasOne(d => d.ProductType).WithMany(p => p.HccProducts)
                .HasForeignKey(d => d.ProductTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_hcc_Product_hcc_ProductType");

            entity.HasOne(d => d.Vendor).WithMany(p => p.HccProducts)
                .HasForeignKey(d => d.VendorId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_hcc_Product_hcc_Vendor");
        });

        modelBuilder.Entity<HccProductFile>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_ProductFile");

            entity.HasIndex(e => new { e.FileName, e.ShortDescription }, "IX_hcc_ProductFile").IsUnique();

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.ShortDescription).HasMaxLength(100);
        });

        modelBuilder.Entity<HccProductFileXproduct>(entity =>
        {
            entity.ToTable("hcc_ProductFileXProduct");

            entity.HasIndex(e => e.ProductFileId, "IX_hcc_ProductFileXProduct");

            entity.HasIndex(e => new { e.ProductFileId, e.ProductId }, "IX_hcc_ProductFileXProduct_1").IsUnique();

            entity.HasIndex(e => e.ProductId, "IX_hcc_ProductFileXProduct_2");

            entity.Property(e => e.LastUpdated).HasColumnType("datetime");

            entity.HasOne(d => d.ProductFile).WithMany(p => p.HccProductFileXproducts)
                .HasForeignKey(d => d.ProductFileId)
                .HasConstraintName("FK_hcc_ProductFileXProduct_hcc_ProductFile");

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductFileXproducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_hcc_ProductFileXProduct_hcc_Product");
        });

        modelBuilder.Entity<HccProductImage>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_ProductImage");

            entity.HasIndex(e => e.ProductId, "IX_hcc_ProductImage");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SortOrder).HasDefaultValue(-1);

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductImages)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_hcc_ProductImage_hcc_Product");
        });

        modelBuilder.Entity<HccProductInventory>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_ProductInventory");

            entity.HasIndex(e => e.ProductBvin, "IX_hcc_ProductInventory");

            entity.Property(e => e.Bvin)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("bvin");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.QuantityAvailableForSale).HasComputedColumnSql("([QuantityOnHand]-[QuantityReserved])", true);
            entity.Property(e => e.VariantId).HasDefaultValue("");

            entity.HasOne(d => d.ProductBvinNavigation).WithMany(p => p.HccProductInventories)
                .HasForeignKey(d => d.ProductBvin)
                .HasConstraintName("FK_hcc_ProductInventory_hcc_Product");
        });

        modelBuilder.Entity<HccProductOption>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_ProductOptions");

            entity.HasIndex(e => e.StoreId, "IX_hcc_ProductOptions_StoreID");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
        });

        modelBuilder.Entity<HccProductOptionItemTranslation>(entity =>
        {
            entity.HasKey(e => e.ProductOptionItemTranslationId);

            entity.ToTable("hcc_ProductOptionItemTranslations");

            entity.HasIndex(e => new { e.ProductOptionItemId, e.Culture }, "UK_hcc_ProductOptionItemTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.ProductOptionItem).WithMany(p => p.HccProductOptionItemTranslations)
                .HasForeignKey(d => d.ProductOptionItemId)
                .HasConstraintName("FK_hcc_ProductOptionItemTranslations_hcc_ProductOptionsItems");
        });

        modelBuilder.Entity<HccProductOptionTranslation>(entity =>
        {
            entity.HasKey(e => e.ProductOptionTranslationId);

            entity.ToTable("hcc_ProductOptionTranslations");

            entity.HasIndex(e => new { e.ProductOptionId, e.Culture }, "UK_hcc_ProductOptionTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.ProductOption).WithMany(p => p.HccProductOptionTranslations)
                .HasForeignKey(d => d.ProductOptionId)
                .HasConstraintName("FK_hcc_ProductOptionTranslations_hcc_ProductOptions");
        });

        modelBuilder.Entity<HccProductOptionsItem>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_ProductOptionsItems");

            entity.HasIndex(e => e.OptionBvin, "IX_hcc_ProductOptionsItems");

            entity.HasIndex(e => e.StoreId, "IX_hcc_ProductOptionsItems_1");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.WeightAdjustment).HasColumnType("decimal(18, 10)");

            entity.HasOne(d => d.OptionBvinNavigation).WithMany(p => p.HccProductOptionsItems)
                .HasForeignKey(d => d.OptionBvin)
                .HasConstraintName("FK_hcc_ProductOptionsItems_hcc_ProductOptions");
        });

        modelBuilder.Entity<HccProductProperty>(entity =>
        {
            entity.ToTable("hcc_ProductProperty");

            entity.Property(e => e.CultureCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("en-US");
            entity.Property(e => e.DefaultValue).HasColumnType("ntext");
            entity.Property(e => e.DisplayOnSite).HasDefaultValue(1);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.PropertyName).HasMaxLength(512);
        });

        modelBuilder.Entity<HccProductPropertyChoice>(entity =>
        {
            entity.ToTable("hcc_ProductPropertyChoice");

            entity.HasIndex(e => e.PropertyId, "IX_hcc_ProductPropertyChoice");

            entity.Property(e => e.ChoiceName).HasMaxLength(512);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.SortOrder).HasDefaultValue(-1);

            entity.HasOne(d => d.Property).WithMany(p => p.HccProductPropertyChoices)
                .HasForeignKey(d => d.PropertyId)
                .HasConstraintName("FK_hcc_ProductPropertyChoice_hcc_ProductProperty");
        });

        modelBuilder.Entity<HccProductPropertyChoiceTranslation>(entity =>
        {
            entity.HasKey(e => e.ProductPropertyChoiceTranslationId);

            entity.ToTable("hcc_ProductPropertyChoiceTranslations");

            entity.HasIndex(e => new { e.ProductPropertyChoiceId, e.Culture }, "IX_hcc_ProductPropertyChoiceTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.DisplayName).HasMaxLength(512);

            entity.HasOne(d => d.ProductPropertyChoice).WithMany(p => p.HccProductPropertyChoiceTranslations)
                .HasForeignKey(d => d.ProductPropertyChoiceId)
                .HasConstraintName("FK_hcc_ProductPropertyChoiceTranslations_hcc_ProductPropertyChoice");
        });

        modelBuilder.Entity<HccProductPropertyTranslation>(entity =>
        {
            entity.HasKey(e => e.ProductPropertyTranslationId);

            entity.ToTable("hcc_ProductPropertyTranslations");

            entity.HasIndex(e => new { e.ProductPropertyId, e.Culture }, "UK_hcc_ProductPropertyTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.DisplayName).HasMaxLength(512);

            entity.HasOne(d => d.ProductProperty).WithMany(p => p.HccProductPropertyTranslations)
                .HasForeignKey(d => d.ProductPropertyId)
                .HasConstraintName("FK_hcc_ProductPropertyTranslations_hcc_ProductProperty");
        });

        modelBuilder.Entity<HccProductPropertyValue>(entity =>
        {
            entity.ToTable("hcc_ProductPropertyValue");

            entity.HasIndex(e => e.ProductBvin, "IX_hcc_ProductPropertyValue_1");

            entity.HasIndex(e => e.PropertyId, "IX_hcc_ProductPropertyValue_2");

            entity.HasOne(d => d.ProductBvinNavigation).WithMany(p => p.HccProductPropertyValues)
                .HasForeignKey(d => d.ProductBvin)
                .HasConstraintName("FK_hcc_ProductPropertyValue_hcc_Product");

            entity.HasOne(d => d.Property).WithMany(p => p.HccProductPropertyValues)
                .HasForeignKey(d => d.PropertyId)
                .HasConstraintName("FK_hcc_ProductPropertyValue_hcc_ProductProperty");
        });

        modelBuilder.Entity<HccProductPropertyValueTranslation>(entity =>
        {
            entity.HasKey(e => e.ProductPropertyValueTranslationId);

            entity.ToTable("hcc_ProductPropertyValueTranslations");

            entity.HasIndex(e => new { e.ProductPropertyValueId, e.Culture }, "IX_hcc_ProductPropertyValueTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);

            entity.HasOne(d => d.ProductPropertyValue).WithMany(p => p.HccProductPropertyValueTranslations)
                .HasForeignKey(d => d.ProductPropertyValueId)
                .HasConstraintName("FK_hcc_ProductPropertyValueTranslations_hcc_ProductPropertyValue");
        });

        modelBuilder.Entity<HccProductRelationship>(entity =>
        {
            entity.ToTable("hcc_ProductRelationships");

            entity.HasIndex(e => e.ProductId, "IX_hcc_ProductRelationships_ProductId");

            entity.HasIndex(e => e.RelatedProductId, "IX_hcc_ProductRelationships_RelatedProductId");

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductRelationships)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_hcc_ProductRelationships_hcc_Product");
        });

        modelBuilder.Entity<HccProductReview>(entity =>
        {
            entity.HasKey(e => e.Bvin).IsClustered(false);

            entity.ToTable("hcc_ProductReview");

            entity.HasIndex(e => e.Id, "IX_hcc_ProductReview").IsUnique();

            entity.HasIndex(e => e.ProductId, "IX_hcc_ProductReview_ProductId").IsClustered();

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdated");
            entity.Property(e => e.ReviewDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("UserID");

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductReviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_hcc_ProductReview_hcc_Product");
        });

        modelBuilder.Entity<HccProductTranslation>(entity =>
        {
            entity.HasKey(e => e.ProductTranslationId);

            entity.ToTable("hcc_ProductTranslations");

            entity.HasIndex(e => new { e.ProductId, e.Culture }, "UK_hcc_ProductTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.DescriptionTabs).HasColumnType("ntext");
            entity.Property(e => e.MediumImageAlternateText).HasMaxLength(255);
            entity.Property(e => e.MetaDescription).HasMaxLength(255);
            entity.Property(e => e.MetaKeywords).HasMaxLength(255);
            entity.Property(e => e.MetaTitle).HasMaxLength(512);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ShortDescription).HasMaxLength(512);
            entity.Property(e => e.SitePriceOverrideText).HasMaxLength(255);
            entity.Property(e => e.SmallImageAlternateText).HasMaxLength(255);
            entity.Property(e => e.UserPriceLabel).HasMaxLength(4000);

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductTranslations)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_hcc_ProductTranslations_hcc_Product");
        });

        modelBuilder.Entity<HccProductType>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_ProductType");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.TemplateName).HasMaxLength(500);
        });

        modelBuilder.Entity<HccProductTypeTranslation>(entity =>
        {
            entity.HasKey(e => e.ProductTypeTranslationId);

            entity.ToTable("hcc_ProductTypeTranslations");

            entity.HasIndex(e => new { e.ProductTypeId, e.Culture }, "UK_hcc_ProductTypeTranslations").IsUnique();

            entity.Property(e => e.Culture)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ProductTypeName).HasMaxLength(512);

            entity.HasOne(d => d.ProductType).WithMany(p => p.HccProductTypeTranslations)
                .HasForeignKey(d => d.ProductTypeId)
                .HasConstraintName("FK_hcc_ProductTypeTranslations_hcc_ProductType");
        });

        modelBuilder.Entity<HccProductTypeXproductProperty>(entity =>
        {
            entity.ToTable("hcc_ProductTypeXProductProperty");

            entity.HasIndex(e => e.ProductTypeBvin, "IX_hcc_ProductTypeXProductProperty_ProductTypeBvin");

            entity.HasIndex(e => e.PropertyId, "IX_hcc_ProductTypeXProductProperty_PropertyId");

            entity.HasIndex(e => e.StoreId, "IX_hcc_ProductTypeXProductProperty_StoreId");

            entity.Property(e => e.SortOrder).HasDefaultValue(1);

            entity.HasOne(d => d.ProductTypeBvinNavigation).WithMany(p => p.HccProductTypeXproductProperties)
                .HasForeignKey(d => d.ProductTypeBvin)
                .HasConstraintName("FK_hcc_ProductTypeProperties_hcc_ProductType");

            entity.HasOne(d => d.Property).WithMany(p => p.HccProductTypeXproductProperties)
                .HasForeignKey(d => d.PropertyId)
                .HasConstraintName("FK_hcc_ProductTypeXProductProperty_hcc_ProductProperty");
        });

        modelBuilder.Entity<HccProductVolumeDiscount>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_ProductVolumeDiscounts");

            entity.HasIndex(e => e.ProductId, "IX_hcc_ProductVolumeDiscounts");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.Amount).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Qty).HasDefaultValue(1);

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductVolumeDiscounts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_hcc_ProductVolumeDiscounts_hcc_Product");
        });

        modelBuilder.Entity<HccProductXcategory>(entity =>
        {
            entity.ToTable("hcc_ProductXCategory");

            entity.HasIndex(e => new { e.ProductId, e.CategoryId }, "IX_hcc_ProductXCategory_1").IsUnique();

            entity.HasIndex(e => e.CategoryId, "IX_hcc_ProductXCategory_2");

            entity.HasOne(d => d.Category).WithMany(p => p.HccProductXcategories)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_hcc_ProductXCategory_hcc_Category");

            entity.HasOne(d => d.Product).WithMany(p => p.HccProductXcategories)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_hcc_ProductXCategory_hcc_Product");
        });

        modelBuilder.Entity<HccProductXoption>(entity =>
        {
            entity.ToTable("hcc_ProductXOption");

            entity.HasIndex(e => e.OptionBvin, "IX_hcc_ProductXOption_OptionBvin");

            entity.HasIndex(e => e.ProductBvin, "IX_hcc_ProductXOption_ProductBvin");

            entity.HasOne(d => d.OptionBvinNavigation).WithMany(p => p.HccProductXoptions)
                .HasForeignKey(d => d.OptionBvin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_ProductXOption_hcc_ProductOptions");

            entity.HasOne(d => d.ProductBvinNavigation).WithMany(p => p.HccProductXoptions)
                .HasForeignKey(d => d.ProductBvin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_ProductXOption_hcc_Product");
        });

        modelBuilder.Entity<HccPromotion>(entity =>
        {
            entity.ToTable("hcc_Promotions");

            entity.HasIndex(e => e.IsEnabled, "IX_hcc_Promotions_IsEnabled");

            entity.HasIndex(e => e.Mode, "IX_hcc_Promotions_Mode");

            entity.HasIndex(e => e.StoreId, "IX_hcc_Promotions_StoreId");

            entity.Property(e => e.ActionsXml).HasDefaultValue("");
            entity.Property(e => e.EndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedUtc).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.QualificationsXml).HasDefaultValue("");
            entity.Property(e => e.StartDateUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<HccPromotionTranslation>(entity =>
        {
            entity.HasKey(e => e.PromotionTranslationId);

            entity.ToTable("hcc_PromotionTranslations");

            entity.HasIndex(e => new { e.PromotionId, e.Culture }, "UK_hcc_PromotionTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.CustomerDescription).HasMaxLength(255);

            entity.HasOne(d => d.Promotion).WithMany(p => p.HccPromotionTranslations)
                .HasForeignKey(d => d.PromotionId)
                .HasConstraintName("FK_hcc_PromotionTranslations_hcc_Promotions");
        });

        modelBuilder.Entity<HccQueuedTask>(entity =>
        {
            entity.ToTable("hcc_QueuedTasks");

            entity.HasIndex(e => e.Status, "IX_hcc_QueuedTasks_Status");

            entity.HasIndex(e => e.StoreId, "IX_hcc_QueuedTasks_StoreId");

            entity.Property(e => e.FriendlyName).HasMaxLength(255);
            entity.Property(e => e.StartAtUtc).HasColumnType("datetime");
            entity.Property(e => e.TaskProcessorName).HasMaxLength(255);
        });

        modelBuilder.Entity<HccRegion>(entity =>
        {
            entity.HasKey(e => e.RegionId);

            entity.ToTable("hcc_Regions");

            entity.Property(e => e.RegionId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Abbreviation).HasMaxLength(10);
            entity.Property(e => e.SystemName).HasMaxLength(255);

            entity.HasOne(d => d.Country).WithMany(p => p.HccRegions)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_hcc_Regions_hcc_Countries");
        });

        modelBuilder.Entity<HccRegionTranslation>(entity =>
        {
            entity.HasKey(e => e.RegionTranslationId);

            entity.ToTable("hcc_RegionTranslations");

            entity.HasIndex(e => new { e.RegionId, e.Culture }, "IX_hcc_RegionTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.DisplayName).HasMaxLength(255);

            entity.HasOne(d => d.Region).WithMany(p => p.HccRegionTranslations)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_hcc_RegionTranslations_hcc_Regions");
        });

        modelBuilder.Entity<HccRewardsPoint>(entity =>
        {
            entity.ToTable("hcc_RewardsPoints");

            entity.HasIndex(e => e.UserId, "IX_hcc_RewardsPoints");

            entity.HasIndex(e => e.StoreId, "IX_hcc_RewardsPoints_1");

            entity.Property(e => e.TransactionTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<HccRma>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_RMA");

            entity.HasIndex(e => e.OrderBvin, "IX_hcc_RMA_OrderBvin");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.DateOfReturn)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(150);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Number).ValueGeneratedOnAdd();
            entity.Property(e => e.PhoneNumber).HasMaxLength(30);

            entity.HasOne(d => d.OrderBvinNavigation).WithMany(p => p.HccRmas)
                .HasForeignKey(d => d.OrderBvin)
                .HasConstraintName("FK_hcc_RMA_hcc_Order");
        });

        modelBuilder.Entity<HccRmaitem>(entity =>
        {
            entity.HasKey(e => e.Bvin).IsClustered(false);

            entity.ToTable("hcc_RMAItem");

            entity.HasIndex(e => e.Bvin, "IX_hcc_RMAItem")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => e.Rmabvin, "IX_hcc_RMAItem_1");

            entity.HasIndex(e => e.LineItemBvin, "IX_hcc_RMAItem_LineItemBvin");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.ItemName).HasMaxLength(512);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.ProductClass)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.RefundAmount).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.RefundGiftWrapAmount).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.RefundShippingAmount).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.RefundTaxAmount).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.Rmabvin).HasColumnName("RMABvin");

            entity.HasOne(d => d.RmabvinNavigation).WithMany(p => p.HccRmaitems)
                .HasForeignKey(d => d.Rmabvin)
                .HasConstraintName("FK_hcc_RMAItem_hcc_RMA");
        });

        modelBuilder.Entity<HccSearchLexicon>(entity =>
        {
            entity.ToTable("hcc_SearchLexicon");

            entity.HasIndex(e => new { e.Word, e.Culture }, "IX_hcc_SearchLexicon");

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.Word).HasMaxLength(255);
        });

        modelBuilder.Entity<HccSearchObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_SearchObject");

            entity.ToTable("hcc_SearchObjects");

            entity.Property(e => e.LastIndexUtc)
                .HasDefaultValueSql("(((1)/(1))/(1900))")
                .HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(512);
        });

        modelBuilder.Entity<HccSearchObjectWord>(entity =>
        {
            entity.HasKey(e => new { e.SearchObjectId, e.WordId, e.SiteId });

            entity.ToTable("hcc_SearchObjectWords");

            entity.HasOne(d => d.SearchObject).WithMany(p => p.HccSearchObjectWords)
                .HasForeignKey(d => d.SearchObjectId)
                .HasConstraintName("FK_hcc_SearchObjectWords_hcc_SearchObjects");

            entity.HasOne(d => d.Word).WithMany(p => p.HccSearchObjectWords)
                .HasForeignKey(d => d.WordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_SearchObjectWords_hcc_SearchLexicon");
        });

        modelBuilder.Entity<HccSearchQuery>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_SearchQuery");

            entity.Property(e => e.Bvin)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("bvin");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.ShopperId)
                .HasMaxLength(36)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HccShippingMethod>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_ShippingMethod");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.Adjustment).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Settings)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.ShippingProviderId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.VisibilityAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<HccShippingMethodTranslation>(entity =>
        {
            entity.HasKey(e => e.ShippingMethodTranslationId);

            entity.ToTable("hcc_ShippingMethodTranslations");

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.ShippingMethod).WithMany(p => p.HccShippingMethodTranslations)
                .HasForeignKey(d => d.ShippingMethodId)
                .HasConstraintName("FK_hcc_ShippingMethodTranslations_hcc_ShippingMethodTranslations");
        });

        modelBuilder.Entity<HccShippingZone>(entity =>
        {
            entity.ToTable("hcc_ShippingZones");

            entity.Property(e => e.Areas)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Store).WithMany(p => p.HccShippingZones)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_ShippingZones_hcc_Stores");
        });

        modelBuilder.Entity<HccStore>(entity =>
        {
            entity.ToTable("hcc_Stores");

            entity.Property(e => e.CustomUrl)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.StoreName).HasMaxLength(255);
        });

        modelBuilder.Entity<HccStoreDomain>(entity =>
        {
            entity.ToTable("hcc_StoreDomains");

            entity.HasIndex(e => e.DomainName, "IX_hcc_StoreDomains_DomainName");

            entity.HasIndex(e => e.StoreId, "IX_hcc_StoreDomains_StoreId");

            entity.Property(e => e.DomainName).HasMaxLength(255);
        });

        modelBuilder.Entity<HccStoreSetting>(entity =>
        {
            entity.ToTable("hcc_StoreSettings");

            entity.HasIndex(e => e.StoreId, "IX_hcc_StoreSettings_StoreId");

            entity.Property(e => e.SettingName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Store).WithMany(p => p.HccStoreSettings)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_hcc_StoreSettings_hcc_Stores");
        });

        modelBuilder.Entity<HccStoreSettingsTranslation>(entity =>
        {
            entity.HasKey(e => e.StoreSettingsTranslationId);

            entity.ToTable("hcc_StoreSettingsTranslations");

            entity.HasIndex(e => new { e.StoreSettingsId, e.Culture }, "UK_hcc_StoreSettingsTranslations").IsUnique();

            entity.Property(e => e.Culture).HasMaxLength(10);

            entity.HasOne(d => d.StoreSettings).WithMany(p => p.HccStoreSettingsTranslations)
                .HasForeignKey(d => d.StoreSettingsId)
                .HasConstraintName("FK_hcc_StoreSettingsTranslations_hcc_StoreSettings");
        });

        modelBuilder.Entity<HccStoresXuser>(entity =>
        {
            entity.ToTable("hcc_StoresXUsers");

            entity.HasIndex(e => e.StoreId, "IX_hcc_StoresXUsers_StoreId");

            entity.HasIndex(e => e.UserId, "IX_hcc_StoresXUsers_UserId");

            entity.Property(e => e.AccessMode).HasDefaultValue(1);

            entity.HasOne(d => d.Store).WithMany(p => p.HccStoresXusers)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_StoresXUsers_hcc_Stores");

            entity.HasOne(d => d.User).WithMany(p => p.HccStoresXusers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_StoresXUsers_hcc_UserAccounts");
        });

        modelBuilder.Entity<HccTaxSchedule>(entity =>
        {
            entity.ToTable("hcc_TaxSchedules");

            entity.Property(e => e.DefaultRate).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.DefaultShippingRate).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Store).WithMany(p => p.HccTaxSchedules)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_TaxSchedules_hcc_Stores");
        });

        modelBuilder.Entity<HccTaxis>(entity =>
        {
            entity.ToTable("hcc_Taxes");

            entity.Property(e => e.CountryName).HasMaxLength(255);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.Rate).HasColumnType("numeric(18, 10)");
            entity.Property(e => e.RegionName).HasMaxLength(255);
            entity.Property(e => e.ShippingRate).HasColumnType("numeric(18, 10)");

            entity.HasOne(d => d.Store).WithMany(p => p.HccTaxes)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_Taxes_hcc_Stores");

            entity.HasOne(d => d.TaxSchedule).WithMany(p => p.HccTaxes)
                .HasForeignKey(d => d.TaxScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_Taxes_hcc_TaxSchedules");
        });

        modelBuilder.Entity<HccUser>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_User");

            entity.Property(e => e.Bvin)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("bvin");
            entity.Property(e => e.AddressBook).HasColumnType("ntext");
            entity.Property(e => e.BillingAddress).HasDefaultValue("");
            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.LockedUntil).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Phones).HasDefaultValue("");
            entity.Property(e => e.PricingGroup)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.Salt).HasMaxLength(50);
            entity.Property(e => e.ShippingAddress).HasDefaultValue("");
        });

        modelBuilder.Entity<HccUserAccount>(entity =>
        {
            entity.ToTable("hcc_UserAccounts");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.ResetKey)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Salt)
                .HasMaxLength(50)
                .HasDefaultValue("");
            entity.Property(e => e.Statuscode)
                .HasDefaultValue(1)
                .HasColumnName("statuscode");
        });

        modelBuilder.Entity<HccUserQuestion>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_UserQuestions");

            entity.Property(e => e.Bvin)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("bvin");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.QuestionName).HasMaxLength(50);
        });

        modelBuilder.Entity<HccUserXcontact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_hcc_UserXAffiliate");

            entity.ToTable("hcc_UserXContact");

            entity.HasIndex(e => e.ContactId, "IX_hcc_UserXContact_ContactId");

            entity.HasIndex(e => e.StoreId, "IX_hcc_UserXContact_StoreId");

            entity.HasIndex(e => e.UserId, "IX_hcc_UserXContact_UserId");

            entity.Property(e => e.ContactId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.HccUserXcontacts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_hcc_UserXAffiliate_hcc_User");
        });

        modelBuilder.Entity<HccUsgeoDatum>(entity =>
        {
            entity.HasKey(e => e.Zip);

            entity.ToTable("hcc_USGeoData");

            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.County)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ZipType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HccVariant>(entity =>
        {
            entity.HasKey(e => e.Bvin)
                .HasName("PK_hcc_Variant")
                .IsClustered(false);

            entity.ToTable("hcc_Variants");

            entity.HasIndex(e => new { e.Bvin, e.ProductId, e.StoreId }, "IX_hcc_Variants_BvinProductStore");

            entity.HasIndex(e => new { e.ProductId, e.StoreId }, "IX_hcc_Variants_ProductIdClustered").IsClustered();

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.CustomProperty).HasDefaultValue("");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.Sku).HasMaxLength(255);

            entity.HasOne(d => d.Product).WithMany(p => p.HccVariants)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_hcc_Variants_hcc_Product");
        });

        modelBuilder.Entity<HccVendor>(entity =>
        {
            entity.HasKey(e => e.Bvin);

            entity.ToTable("hcc_Vendor");

            entity.Property(e => e.Bvin)
                .ValueGeneratedNever()
                .HasColumnName("bvin");
            entity.Property(e => e.Address).HasColumnType("ntext");
            entity.Property(e => e.DisplayName).HasMaxLength(255);
            entity.Property(e => e.DropShipEmailTemplateId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress).HasMaxLength(255);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
        });

        modelBuilder.Entity<HccWishListItem>(entity =>
        {
            entity.ToTable("hcc_WishListItems");

            entity.HasIndex(e => e.CustomerId, "IX_hcc_WishListItems_CustomerId");

            entity.HasIndex(e => e.StoreId, "IX_hcc_WishListItems_StoreId");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(36)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");

            entity.HasOne(d => d.Product).WithMany(p => p.HccWishListItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_hcc_WishListItems_hcc_Product");
        });

        modelBuilder.Entity<HostSetting>(entity =>
        {
            entity.HasKey(e => e.SettingName);

            entity.Property(e => e.SettingName).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<HtmlText>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.ToTable("HtmlText");

            entity.HasIndex(e => new { e.ModuleId, e.Version }, "IX_HtmlText_ModuleID_Version");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.Content).HasColumnType("ntext");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.Summary).HasColumnType("ntext");

            entity.HasOne(d => d.Module).WithMany(p => p.HtmlTexts)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_HtmlText_Modules");

            entity.HasOne(d => d.State).WithMany(p => p.HtmlTexts)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_HtmlText_WorkflowStates");
        });

        modelBuilder.Entity<HtmlTextLog>(entity =>
        {
            entity.ToTable("HtmlTextLog");

            entity.HasIndex(e => e.ItemId, "IX_HtmlTextLog_ItemID");

            entity.Property(e => e.HtmlTextLogId).HasColumnName("HtmlTextLogID");
            entity.Property(e => e.Comment).HasMaxLength(4000);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.StateId).HasColumnName("StateID");

            entity.HasOne(d => d.Item).WithMany(p => p.HtmlTextLogs)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_HtmlTextLog_HtmlText");

            entity.HasOne(d => d.State).WithMany(p => p.HtmlTextLogs)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HtmlTextLog_WorkflowStates");
        });

        modelBuilder.Entity<HtmlTextUser>(entity =>
        {
            entity.Property(e => e.HtmlTextUserId).HasColumnName("HtmlTextUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Item).WithMany(p => p.HtmlTextUsers)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_HtmlTextUsers_HtmlText");
        });

        modelBuilder.Entity<Ipfilter>(entity =>
        {
            entity.ToTable("IPFilter");

            entity.Property(e => e.IpfilterId).HasColumnName("IPFilterID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.SubnetMask).HasMaxLength(50);
        });

        modelBuilder.Entity<JavaScriptLibrary>(entity =>
        {
            entity.HasKey(e => e.JavaScriptLibraryId).HasName("PK_JavaScriptLIbraries");

            entity.Property(e => e.JavaScriptLibraryId).HasColumnName("JavaScriptLibraryID");
            entity.Property(e => e.Cdnpath)
                .HasMaxLength(250)
                .HasColumnName("CDNPath");
            entity.Property(e => e.FileName).HasMaxLength(100);
            entity.Property(e => e.LibraryName).HasMaxLength(200);
            entity.Property(e => e.ObjectName).HasMaxLength(100);
            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.Version).HasMaxLength(50);

            entity.HasOne(d => d.Package).WithMany(p => p.JavaScriptLibraries)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK_JavaScriptLibrariesPackages");
        });

        modelBuilder.Entity<Journal>(entity =>
        {
            entity.ToTable("Journal");

            entity.HasIndex(e => e.ContentItemId, "IX_Journal_ContentItemId");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateUpdated).HasColumnType("datetime");
            entity.Property(e => e.GroupId).HasDefaultValue(-1);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .HasColumnName("ImageURL");
            entity.Property(e => e.ItemData).HasMaxLength(2000);
            entity.Property(e => e.ObjectKey).HasMaxLength(255);
            entity.Property(e => e.ProfileId).HasDefaultValue(-1);
            entity.Property(e => e.Summary).HasMaxLength(2000);
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.JournalType).WithMany(p => p.Journals)
                .HasForeignKey(d => d.JournalTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Journal_JournalTypes");
        });

        modelBuilder.Entity<JournalAccess>(entity =>
        {
            entity.ToTable("Journal_Access");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<JournalComment>(entity =>
        {
            entity.HasKey(e => e.CommentId);

            entity.ToTable("Journal_Comments");

            entity.Property(e => e.Comment).HasMaxLength(2000);
            entity.Property(e => e.CommentXml)
                .HasColumnType("xml")
                .HasColumnName("CommentXML");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateUpdated).HasColumnType("datetime");

            entity.HasOne(d => d.Journal).WithMany(p => p.JournalComments)
                .HasForeignKey(d => d.JournalId)
                .HasConstraintName("FK_JournalComments_Journal");
        });

        modelBuilder.Entity<JournalDatum>(entity =>
        {
            entity.HasKey(e => e.JournalDataId);

            entity.ToTable("Journal_Data");

            entity.Property(e => e.JournalXml)
                .HasColumnType("xml")
                .HasColumnName("JournalXML");

            entity.HasOne(d => d.Journal).WithMany(p => p.JournalData)
                .HasForeignKey(d => d.JournalId)
                .HasConstraintName("FK_Journal_Data_Journal");
        });

        modelBuilder.Entity<JournalSecurity>(entity =>
        {
            entity.ToTable("Journal_Security");

            entity.HasIndex(e => new { e.JournalId, e.SecurityKey }, "IX_Journal_Security").IsUnique();

            entity.Property(e => e.SecurityKey).HasMaxLength(50);
        });

        modelBuilder.Entity<JournalType>(entity =>
        {
            entity.HasKey(e => e.JournalTypeId).HasName("PK_JournalTypes");

            entity.ToTable("Journal_Types");

            entity.Property(e => e.JournalTypeId).ValueGeneratedNever();
            entity.Property(e => e.AppliesToGroup).HasDefaultValue(true);
            entity.Property(e => e.AppliesToProfile).HasDefaultValue(true);
            entity.Property(e => e.AppliesToStream).HasDefaultValue(true);
            entity.Property(e => e.EnableComments).HasDefaultValue(true);
            entity.Property(e => e.Icon)
                .HasMaxLength(25)
                .HasColumnName("icon");
            entity.Property(e => e.IsEnabled).HasDefaultValue(true);
            entity.Property(e => e.JournalType1)
                .HasMaxLength(25)
                .HasColumnName("JournalType");
            entity.Property(e => e.PortalId).HasDefaultValue(-1);
        });

        modelBuilder.Entity<JournalTypeFilter>(entity =>
        {
            entity.ToTable("Journal_TypeFilters");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasIndex(e => e.CultureCode, "IX_Languages").IsUnique();

            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(50);
            entity.Property(e => e.CultureName).HasMaxLength(200);
            entity.Property(e => e.FallbackCulture).HasMaxLength(50);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LanguagePack>(entity =>
        {
            entity.HasIndex(e => new { e.LanguageId, e.PackageId }, "IX_LanguagePacks").IsUnique();

            entity.Property(e => e.LanguagePackId).HasColumnName("LanguagePackID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DependentPackageId).HasColumnName("DependentPackageID");
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PackageId).HasColumnName("PackageID");

            entity.HasOne(d => d.Package).WithMany(p => p.LanguagePacks)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK_LanguagePacks_Packages");
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => e.EntryId);

            entity.HasIndex(e => new { e.ListName, e.ParentId }, "IX_Lists_ListName_ParentID");

            entity.HasIndex(e => new { e.PortalId, e.ListName, e.Value, e.Text, e.ParentId }, "IX_Lists_ListName_Value_Text_ParentID").IsUnique();

            entity.HasIndex(e => new { e.PortalId, e.ParentId, e.ListName, e.Value }, "IX_Lists_ParentID").IsUnique();

            entity.HasIndex(e => new { e.PortalId, e.ParentId, e.ListName, e.SortOrder }, "IX_Lists_SortOrder");

            entity.Property(e => e.EntryId).HasColumnName("EntryID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DefinitionId).HasColumnName("DefinitionID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ListName).HasMaxLength(50);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.PortalId)
                .HasDefaultValue(-1)
                .HasColumnName("PortalID");
            entity.Property(e => e.Text).HasMaxLength(150);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<MessagingMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId);

            entity.ToTable("Messaging_Messages");

            entity.HasIndex(e => new { e.EmailSent, e.EmailSchedulerInstance, e.Status, e.Date }, "IX_Messaging_Messages_EmailSent_EmailSchedulerInstance_Status").IsDescending(false, false, false, true);

            entity.HasIndex(e => new { e.FromUserId, e.Status, e.Date }, "IX_Messaging_Messages_FromUserID_Status").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.ToUserId, e.Status, e.SkipPortal, e.Date }, "IX_Messaging_Messages_ToUserID_Status_SkipPortal").IsDescending(false, false, false, true);

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.EmailSentDate).HasColumnType("datetime");
            entity.Property(e => e.FromUserId).HasColumnName("FromUserID");
            entity.Property(e => e.FromUserName).HasMaxLength(50);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.ToRoleId).HasColumnName("ToRoleID");
            entity.Property(e => e.ToUserId).HasColumnName("ToUserID");
            entity.Property(e => e.ToUserName).HasMaxLength(50);
        });

        modelBuilder.Entity<MetaData>(entity =>
        {
            entity.HasIndex(e => e.MetaDataName, "IX_MetaData_MetaDataName").IsUnique();

            entity.Property(e => e.MetaDataId).HasColumnName("MetaDataID");
            entity.Property(e => e.MetaDataDescription).HasMaxLength(2500);
            entity.Property(e => e.MetaDataName).HasMaxLength(100);
        });

        modelBuilder.Entity<MobilePreviewProfile>(entity =>
        {
            entity.ToTable("Mobile_PreviewProfiles");

            entity.HasIndex(e => e.SortOrder, "IX_Mobile_PreviewProfiles_SortOrder");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UserAgent).HasMaxLength(260);

            entity.HasOne(d => d.Portal).WithMany(p => p.MobilePreviewProfiles)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_Mobile_PreviewProfiles_Portals");
        });

        modelBuilder.Entity<MobileRedirection>(entity =>
        {
            entity.ToTable("Mobile_Redirections");

            entity.HasIndex(e => e.SortOrder, "IX_Mobile_Redirections_SortOrder");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.TargetValue).HasMaxLength(260);

            entity.HasOne(d => d.Portal).WithMany(p => p.MobileRedirections)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_Mobile_Redirections_Portals");
        });

        modelBuilder.Entity<MobileRedirectionRule>(entity =>
        {
            entity.ToTable("Mobile_RedirectionRules");

            entity.Property(e => e.Capability).HasMaxLength(50);
            entity.Property(e => e.Expression).HasMaxLength(50);

            entity.HasOne(d => d.Redirection).WithMany(p => p.MobileRedirectionRules)
                .HasForeignKey(d => d.RedirectionId)
                .HasConstraintName("FK_Mobile_RedirectionRules_Mobile_Redirections");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasIndex(e => new { e.ModuleDefId, e.ModuleId }, "IX_Modules_ModuleDefId");

            entity.HasIndex(e => e.PortalId, "IX_Modules_PortalId");

            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsShareable).HasDefaultValue(true);
            entity.Property(e => e.IsShareableViewOnly).HasDefaultValue(true);
            entity.Property(e => e.LastContentModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.ContentItem).WithMany(p => p.Modules)
                .HasForeignKey(d => d.ContentItemId)
                .HasConstraintName("FK_Modules_ContentItems");

            entity.HasOne(d => d.ModuleDef).WithMany(p => p.Modules)
                .HasForeignKey(d => d.ModuleDefId)
                .HasConstraintName("FK_Modules_ModuleDefinitions");
        });

        modelBuilder.Entity<ModuleControl>(entity =>
        {
            entity.HasIndex(e => new { e.ModuleDefId, e.ControlKey, e.ControlSrc }, "IX_ModuleControls").IsUnique();

            entity.HasIndex(e => new { e.ControlKey, e.ViewOrder }, "IX_ModuleControls_ControlKey_ViewOrder");

            entity.Property(e => e.ModuleControlId).HasColumnName("ModuleControlID");
            entity.Property(e => e.ControlKey).HasMaxLength(50);
            entity.Property(e => e.ControlSrc).HasMaxLength(256);
            entity.Property(e => e.ControlTitle).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.HelpUrl).HasMaxLength(200);
            entity.Property(e => e.IconFile).HasMaxLength(100);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");

            entity.HasOne(d => d.ModuleDef).WithMany(p => p.ModuleControls)
                .HasForeignKey(d => d.ModuleDefId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ModuleControls_ModuleDefinitions");
        });

        modelBuilder.Entity<ModuleDefinition>(entity =>
        {
            entity.HasKey(e => e.ModuleDefId);

            entity.HasIndex(e => e.DefinitionName, "IX_ModuleDefinitions").IsUnique();

            entity.HasIndex(e => e.DesktopModuleId, "IX_ModuleDefinitions_1");

            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DefinitionName).HasMaxLength(128);
            entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");
            entity.Property(e => e.FriendlyName).HasMaxLength(128);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

            entity.HasOne(d => d.DesktopModule).WithMany(p => p.ModuleDefinitions)
                .HasForeignKey(d => d.DesktopModuleId)
                .HasConstraintName("FK_ModuleDefinitions_DesktopModules");
        });

        modelBuilder.Entity<ModulePermission>(entity =>
        {
            entity.ToTable("ModulePermission");

            entity.HasIndex(e => new { e.ModuleId, e.PermissionId, e.PortalId, e.RoleId, e.UserId }, "IX_ModulePermission_Modules").IsUnique();

            entity.HasIndex(e => e.PermissionId, "IX_ModulePermission_Permission");

            entity.HasIndex(e => e.PortalId, "IX_ModulePermission_Portal");

            entity.HasIndex(e => new { e.RoleId, e.ModuleId, e.PermissionId, e.PortalId }, "IX_ModulePermission_Roles")
                .IsUnique()
                .HasFilter("([RoleID] IS NOT NULL)");

            entity.HasIndex(e => new { e.UserId, e.ModuleId, e.PermissionId, e.PortalId }, "IX_ModulePermission_Users")
                .IsUnique()
                .HasFilter("([UserID] IS NOT NULL)");

            entity.Property(e => e.ModulePermissionId).HasColumnName("ModulePermissionID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Module).WithMany(p => p.ModulePermissions)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_ModulePermission_Modules");

            entity.HasOne(d => d.Permission).WithMany(p => p.ModulePermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK_ModulePermission_Permission");

            entity.HasOne(d => d.Role).WithMany(p => p.ModulePermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_ModulePermission_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.ModulePermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ModulePermission_Users");
        });

        modelBuilder.Entity<ModuleSetting>(entity =>
        {
            entity.HasKey(e => new { e.ModuleId, e.SettingName });

            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.SettingName).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

            entity.HasOne(d => d.Module).WithMany(p => p.ModuleSettings)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_ModuleSettings_Modules");
        });

        modelBuilder.Entity<OutputCache>(entity =>
        {
            entity.HasKey(e => e.CacheKey);

            entity.ToTable("OutputCache");

            entity.Property(e => e.CacheKey)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.Expiration).HasColumnType("datetime");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasIndex(e => new { e.Owner, e.Name, e.PackageType, e.PortalId, e.Version }, "IX_Packages").IsUnique();

            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FolderName).HasMaxLength(128);
            entity.Property(e => e.FriendlyName).HasMaxLength(250);
            entity.Property(e => e.IconFile).HasMaxLength(100);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.License).HasColumnType("ntext");
            entity.Property(e => e.Manifest).HasColumnType("ntext");
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.Organization).HasMaxLength(100);
            entity.Property(e => e.Owner).HasMaxLength(100);
            entity.Property(e => e.PackageType).HasMaxLength(100);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.ReleaseNotes).HasColumnType("ntext");
            entity.Property(e => e.Url).HasMaxLength(250);
            entity.Property(e => e.Version).HasMaxLength(50);

            entity.HasOne(d => d.PackageTypeNavigation).WithMany(p => p.Packages)
                .HasForeignKey(d => d.PackageType)
                .HasConstraintName("FK_Packages_PackageTypes");
        });

        modelBuilder.Entity<PackageDependency>(entity =>
        {
            entity.Property(e => e.PackageDependencyId).HasColumnName("PackageDependencyID");
            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.PackageName).HasMaxLength(128);
            entity.Property(e => e.Version).HasMaxLength(50);

            entity.HasOne(d => d.Package).WithMany(p => p.PackageDependencies)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK_PackageDependencies_Packages");
        });

        modelBuilder.Entity<PackageType>(entity =>
        {
            entity.HasKey(e => e.PackageType1).HasName("PK_PackageTypes_1");

            entity.Property(e => e.PackageType1)
                .HasMaxLength(100)
                .HasColumnName("PackageType");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EditorControlSrc).HasMaxLength(250);
        });

        modelBuilder.Entity<PasswordHistory>(entity =>
        {
            entity.ToTable("PasswordHistory");

            entity.Property(e => e.PasswordHistoryId).HasColumnName("PasswordHistoryID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordSalt).HasMaxLength(128);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.PasswordHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_PasswordHistory_Users");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.ToTable("Permission");

            entity.HasIndex(e => new { e.PermissionCode, e.ModuleDefId, e.PermissionKey }, "IX_Permission").IsUnique();

            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.PermissionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ViewOrder).HasDefaultValue(9999);
        });

        modelBuilder.Entity<PersonaBarExtension>(entity =>
        {
            entity.HasKey(e => e.ExtensionId);

            entity.HasIndex(e => e.Identifier, "IX_PersonaBarExtensions").IsUnique();

            entity.Property(e => e.Container).HasMaxLength(50);
            entity.Property(e => e.Controller).HasMaxLength(260);
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.FolderName).HasMaxLength(50);
            entity.Property(e => e.Identifier).HasMaxLength(50);
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Path).HasMaxLength(260);

            entity.HasOne(d => d.Menu).WithMany(p => p.PersonaBarExtensions)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("FK_PersonaBarExtensions_MenuId");
        });

        modelBuilder.Entity<PersonaBarMenu>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.ToTable("PersonaBarMenu");

            entity.HasIndex(e => e.Identifier, "IX_PersonaBarMenu").IsUnique();

            entity.Property(e => e.Controller).HasMaxLength(260);
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CssClass).HasMaxLength(50);
            entity.Property(e => e.FolderName).HasMaxLength(50);
            entity.Property(e => e.IconFile).HasMaxLength(260);
            entity.Property(e => e.Identifier).HasMaxLength(50);
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Link).HasMaxLength(260);
            entity.Property(e => e.ModuleName).HasMaxLength(50);
            entity.Property(e => e.Path).HasMaxLength(260);
            entity.Property(e => e.ResourceKey).HasMaxLength(50);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_PersonaBarMenu_ParentId");
        });

        modelBuilder.Entity<PersonaBarMenuDefaultPermission>(entity =>
        {
            entity.HasIndex(e => e.MenuId, "IX_PersonaBarMenuDefaultPermissions").IsUnique();

            entity.Property(e => e.RoleNames).HasMaxLength(1024);

            entity.HasOne(d => d.Menu).WithOne(p => p.PersonaBarMenuDefaultPermission)
                .HasForeignKey<PersonaBarMenuDefaultPermission>(d => d.MenuId)
                .HasConstraintName("FK_PersonaBarMenuDefaultPermissions_MenuId");
        });

        modelBuilder.Entity<PersonaBarMenuPermission>(entity =>
        {
            entity.HasKey(e => e.MenuPermissionId);

            entity.ToTable("PersonaBarMenuPermission");

            entity.HasIndex(e => new { e.PortalId, e.MenuId, e.PermissionId, e.UserId, e.RoleId }, "IX_PersonaBarMenuPermission").IsUnique();

            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

            entity.HasOne(d => d.Menu).WithMany(p => p.PersonaBarMenuPermissions)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("FK_PersonaBarMenuPermission_MenuId");

            entity.HasOne(d => d.Permission).WithMany(p => p.PersonaBarMenuPermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK_PersonaBarMenuPermission_Permission");

            entity.HasOne(d => d.Portal).WithMany(p => p.PersonaBarMenuPermissions)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PersonaBarMenuPermission_Portals");

            entity.HasOne(d => d.Role).WithMany(p => p.PersonaBarMenuPermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_PersonaBarMenuPermission_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.PersonaBarMenuPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PersonaBarMenuPermission_Users");
        });

        modelBuilder.Entity<PersonaBarPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId);

            entity.ToTable("PersonaBarPermission");

            entity.HasIndex(e => new { e.MenuId, e.PermissionKey }, "IX_PersonaBarPermissionScope").IsUnique();

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PermissionKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ViewOrder).HasDefaultValue(9999);

            entity.HasOne(d => d.Menu).WithMany(p => p.PersonaBarPermissions)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("FK_PersonaBarPermission_MenuId");
        });

        modelBuilder.Entity<Portal>(entity =>
        {
            entity.HasIndex(e => e.AdministratorId, "IX_Portals_AdministratorId");

            entity.HasIndex(e => e.DefaultLanguage, "IX_Portals_DefaultLanguage");

            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DefaultLanguage)
                .HasMaxLength(10)
                .HasDefaultValue("en-US");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.Guid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("GUID");
            entity.Property(e => e.HomeDirectory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.HostFee).HasColumnType("money");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentProcessor).HasMaxLength(50);
            entity.Property(e => e.PortalGroupId).HasColumnName("PortalGroupID");
            entity.Property(e => e.ProcessorPassword).HasMaxLength(100);
            entity.Property(e => e.ProcessorUserId).HasMaxLength(50);
            entity.Property(e => e.TimezoneOffset).HasDefaultValue(-8);
        });

        modelBuilder.Entity<PortalAlias>(entity =>
        {
            entity.ToTable("PortalAlias");

            entity.HasIndex(e => e.Httpalias, "IX_PortalAlias").IsUnique();

            entity.Property(e => e.PortalAliasId).HasColumnName("PortalAliasID");
            entity.Property(e => e.BrowserType).HasMaxLength(10);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.Httpalias)
                .HasMaxLength(200)
                .HasColumnName("HTTPAlias");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.Skin).HasMaxLength(100);

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalAliases)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_PortalAlias_Portals");
        });

        modelBuilder.Entity<PortalDesktopModule>(entity =>
        {
            entity.HasIndex(e => new { e.PortalId, e.DesktopModuleId }, "IX_PortalDesktopModules").IsUnique();

            entity.Property(e => e.PortalDesktopModuleId).HasColumnName("PortalDesktopModuleID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");

            entity.HasOne(d => d.DesktopModule).WithMany(p => p.PortalDesktopModules)
                .HasForeignKey(d => d.DesktopModuleId)
                .HasConstraintName("FK_PortalDesktopModules_DesktopModules");

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalDesktopModules)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_PortalDesktopModules_Portals");
        });

        modelBuilder.Entity<PortalGroup>(entity =>
        {
            entity.HasKey(e => e.PortalGroupId).HasName("PK_PortalGroup");

            entity.Property(e => e.PortalGroupId).HasColumnName("PortalGroupID");
            entity.Property(e => e.AuthenticationDomain).HasMaxLength(200);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.MasterPortalId).HasColumnName("MasterPortalID");
            entity.Property(e => e.PortalGroupDescription).HasMaxLength(2000);
            entity.Property(e => e.PortalGroupName).HasMaxLength(100);
        });

        modelBuilder.Entity<PortalLanguage>(entity =>
        {
            entity.HasIndex(e => new { e.PortalId, e.LanguageId }, "IX_PortalLanguages").IsUnique();

            entity.Property(e => e.PortalLanguageId).HasColumnName("PortalLanguageID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");

            entity.HasOne(d => d.Language).WithMany(p => p.PortalLanguages)
                .HasForeignKey(d => d.LanguageId)
                .HasConstraintName("FK_PortalLanguages_PortalLanguages");

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalLanguages)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_PortalLanguages_Portals");
        });

        modelBuilder.Entity<PortalLocalization>(entity =>
        {
            entity.HasKey(e => new { e.PortalId, e.CultureCode });

            entity.ToTable("PortalLocalization");

            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.BackgroundFile).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.FooterText).HasMaxLength(100);
            entity.Property(e => e.KeyWords).HasMaxLength(500);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LogoFile).HasMaxLength(50);
            entity.Property(e => e.PortalName).HasMaxLength(128);

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalLocalizations)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_PortalLocalization_Portals");
        });

        modelBuilder.Entity<PortalPermission>(entity =>
        {
            entity.ToTable("PortalPermission");

            entity.HasIndex(e => e.PermissionId, "IX_PortalPermission_Permission");

            entity.HasIndex(e => new { e.PortalId, e.PermissionId, e.RoleId, e.UserId }, "IX_PortalPermission_Portals").IsUnique();

            entity.HasIndex(e => new { e.RoleId, e.PortalId, e.PermissionId }, "IX_PortalPermission_Roles")
                .IsUnique()
                .HasFilter("([RoleID] IS NOT NULL)");

            entity.HasIndex(e => new { e.UserId, e.PortalId, e.PermissionId }, "IX_PortalPermission_Users")
                .IsUnique()
                .HasFilter("([UserID] IS NOT NULL)");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Permission).WithMany(p => p.PortalPermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK_PortalPermission_PermissionId");

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalPermissions)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_PortalPermission_PortalId");

            entity.HasOne(d => d.Role).WithMany(p => p.PortalPermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PortalPermission_RoleId");

            entity.HasOne(d => d.User).WithMany(p => p.PortalPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PortalPermission_UserId");
        });

        modelBuilder.Entity<PortalSetting>(entity =>
        {
            entity.HasKey(e => e.PortalSettingId).IsClustered(false);

            entity.HasIndex(e => new { e.PortalId, e.CultureCode, e.SettingName }, "IX_PortalSettings")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PortalSettingId).HasColumnName("PortalSettingID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.SettingName).HasMaxLength(50);

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalSettings)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_PortalSettings_Portals");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.ToTable("Profile");

            entity.HasIndex(e => new { e.UserId, e.PortalId }, "IX_Profile").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileData).HasColumnType("ntext");

            entity.HasOne(d => d.Portal).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_Profile_Portals");

            entity.HasOne(d => d.User).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Profile_Users");
        });

        modelBuilder.Entity<ProfilePropertyDefinition>(entity =>
        {
            entity.HasKey(e => e.PropertyDefinitionId);

            entity.ToTable("ProfilePropertyDefinition");

            entity.HasIndex(e => new { e.PortalId, e.ModuleDefId, e.PropertyName }, "IX_ProfilePropertyDefinition").IsUnique();

            entity.HasIndex(e => e.PropertyName, "IX_ProfilePropertyDefinition_PropertyName");

            entity.Property(e => e.PropertyDefinitionId).HasColumnName("PropertyDefinitionID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DefaultValue).HasColumnType("ntext");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.PropertyCategory).HasMaxLength(50);
            entity.Property(e => e.PropertyName).HasMaxLength(50);
            entity.Property(e => e.ValidationExpression).HasMaxLength(2000);

            entity.HasOne(d => d.Portal).WithMany(p => p.ProfilePropertyDefinitions)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProfilePropertyDefinition_Portals");
        });

        modelBuilder.Entity<RedirectMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId);

            entity.HasIndex(e => e.CreatedOnDate, "IX_RedirectMessages_CreatedOnDate");

            entity.Property(e => e.MessageId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Relationship>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Relationships_UserID");

            entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.RelationshipTypeId).HasColumnName("RelationshipTypeID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Portal).WithMany(p => p.Relationships)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Relationships_Portals");

            entity.HasOne(d => d.RelationshipType).WithMany(p => p.Relationships)
                .HasForeignKey(d => d.RelationshipTypeId)
                .HasConstraintName("FK_Relationships_RelationshipTypes");

            entity.HasOne(d => d.User).WithMany(p => p.Relationships)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Relationships_Users");
        });

        modelBuilder.Entity<RelationshipType>(entity =>
        {
            entity.Property(e => e.RelationshipTypeId).HasColumnName("RelationshipTypeID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasIndex(e => new { e.PortalId, e.RoleName }, "IX_RoleName").IsUnique();

            entity.HasIndex(e => e.BillingFrequency, "IX_Roles");

            entity.HasIndex(e => new { e.RoleGroupId, e.RoleName }, "IX_Roles_RoleGroup");

            entity.HasIndex(e => new { e.RoleId, e.Status }, "IX_Roles_RoleID_Status").IsUnique();

            entity.HasIndex(e => new { e.PortalId, e.RoleName }, "IX_Roles_RoleName").IsUnique();

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.BillingFrequency)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.IconFile).HasMaxLength(100);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.Rsvpcode)
                .HasMaxLength(50)
                .HasColumnName("RSVPCode");
            entity.Property(e => e.ServiceFee)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.TrialFee).HasColumnType("money");
            entity.Property(e => e.TrialFrequency)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Portal).WithMany(p => p.Roles)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Roles_Portals");

            entity.HasOne(d => d.RoleGroup).WithMany(p => p.Roles)
                .HasForeignKey(d => d.RoleGroupId)
                .HasConstraintName("FK_Roles_RoleGroups");
        });

        modelBuilder.Entity<RoleGroup>(entity =>
        {
            entity.HasIndex(e => new { e.PortalId, e.RoleGroupName }, "IX_RoleGroupName").IsUnique();

            entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.RoleGroupName).HasMaxLength(50);

            entity.HasOne(d => d.Portal).WithMany(p => p.RoleGroups)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_RoleGroups_Portals");
        });

        modelBuilder.Entity<RoleSetting>(entity =>
        {
            entity.Property(e => e.RoleSettingId).HasColumnName("RoleSettingID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.SettingName).HasMaxLength(50);
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.ToTable("Schedule");

            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.AttachToEvent)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.FriendlyName).HasMaxLength(200);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ObjectDependencies)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.RetryTimeLapseMeasurement)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ScheduleStartDate).HasColumnType("datetime");
            entity.Property(e => e.Servers).HasMaxLength(2000);
            entity.Property(e => e.TimeLapseMeasurement)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TypeFullName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ScheduleHistory>(entity =>
        {
            entity.ToTable("ScheduleHistory");

            entity.HasIndex(e => new { e.ScheduleId, e.NextStart }, "IX_ScheduleHistory_NextStart").IsDescending(false, true);

            entity.HasIndex(e => new { e.ScheduleId, e.StartDate }, "IX_ScheduleHistory_StartDate").IsDescending(false, true);

            entity.Property(e => e.ScheduleHistoryId).HasColumnName("ScheduleHistoryID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.LogNotes).HasColumnType("ntext");
            entity.Property(e => e.NextStart).HasColumnType("datetime");
            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.Server).HasMaxLength(150);
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Schedule).WithMany(p => p.ScheduleHistories)
                .HasForeignKey(d => d.ScheduleId)
                .HasConstraintName("FK_ScheduleHistory_Schedule");
        });

        modelBuilder.Entity<ScheduleItemSetting>(entity =>
        {
            entity.HasKey(e => new { e.ScheduleId, e.SettingName });

            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");
            entity.Property(e => e.SettingName).HasMaxLength(50);

            entity.HasOne(d => d.Schedule).WithMany(p => p.ScheduleItemSettings)
                .HasForeignKey(d => d.ScheduleId)
                .HasConstraintName("FK_ScheduleItemSettings_Schedule");
        });

        modelBuilder.Entity<SearchCommonWord>(entity =>
        {
            entity.HasKey(e => e.CommonWordId);

            entity.Property(e => e.CommonWordId).HasColumnName("CommonWordID");
            entity.Property(e => e.CommonWord).HasMaxLength(255);
            entity.Property(e => e.Locale).HasMaxLength(10);
        });

        modelBuilder.Entity<SearchDeletedItem>(entity =>
        {
            entity.HasKey(e => e.SearchDeletedItemsId);

            entity.HasIndex(e => e.DateCreated, "IX_SearchDeletedItems_DateCreated");

            entity.Property(e => e.SearchDeletedItemsId).HasColumnName("SearchDeletedItemsID");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<SearchIndexer>(entity =>
        {
            entity.ToTable("SearchIndexer");

            entity.Property(e => e.SearchIndexerId).HasColumnName("SearchIndexerID");
            entity.Property(e => e.SearchIndexerAssemblyQualifiedName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<SearchStopWord>(entity =>
        {
            entity.HasKey(e => e.StopWordsId);

            entity.Property(e => e.StopWordsId).HasColumnName("StopWordsID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(50);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
        });

        modelBuilder.Entity<SearchType>(entity =>
        {
            entity.Property(e => e.IsPrivate).HasDefaultValue(false);
            entity.Property(e => e.SearchResultClass).HasMaxLength(256);
            entity.Property(e => e.SearchTypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<SiteLog>(entity =>
        {
            entity.ToTable("SiteLog");

            entity.HasIndex(e => e.PortalId, "IX_SiteLog");

            entity.Property(e => e.DateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.Referrer).HasMaxLength(255);
            entity.Property(e => e.Url).HasMaxLength(255);
            entity.Property(e => e.UserAgent).HasMaxLength(255);
            entity.Property(e => e.UserHostAddress).HasMaxLength(255);
            entity.Property(e => e.UserHostName).HasMaxLength(255);

            entity.HasOne(d => d.Portal).WithMany(p => p.SiteLogs)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_SiteLog_Portals");
        });

        modelBuilder.Entity<Skin>(entity =>
        {
            entity.Property(e => e.SkinId).HasColumnName("SkinID");
            entity.Property(e => e.SkinPackageId).HasColumnName("SkinPackageID");
            entity.Property(e => e.SkinSrc).HasMaxLength(250);

            entity.HasOne(d => d.SkinPackage).WithMany(p => p.Skins)
                .HasForeignKey(d => d.SkinPackageId)
                .HasConstraintName("FK_Skins_SkinPackages");
        });

        modelBuilder.Entity<SkinControl>(entity =>
        {
            entity.Property(e => e.SkinControlId).HasColumnName("SkinControlID");
            entity.Property(e => e.ControlKey).HasMaxLength(50);
            entity.Property(e => e.ControlSrc).HasMaxLength(256);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.HelpUrl).HasMaxLength(200);
            entity.Property(e => e.IconFile).HasMaxLength(100);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PackageId)
                .HasDefaultValue(-1)
                .HasColumnName("PackageID");

            entity.HasOne(d => d.Package).WithMany(p => p.SkinControls)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK_SkinControls_Packages");
        });

        modelBuilder.Entity<SkinPackage>(entity =>
        {
            entity.Property(e => e.SkinPackageId).HasColumnName("SkinPackageID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.SkinName).HasMaxLength(50);
            entity.Property(e => e.SkinType).HasMaxLength(20);

            entity.HasOne(d => d.Package).WithMany(p => p.SkinPackages)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("FK_SkinPackages_Packages");
        });

        modelBuilder.Entity<Sqlquery>(entity =>
        {
            entity.HasKey(e => e.QueryId).HasName("PK_SavedQueries");

            entity.ToTable("SQLQueries");

            entity.Property(e => e.ConnectionStringName).HasMaxLength(50);
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<SynonymsGroup>(entity =>
        {
            entity.Property(e => e.SynonymsGroupId).HasColumnName("SynonymsGroupID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(50);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
        });

        modelBuilder.Entity<SystemMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId);

            entity.HasIndex(e => new { e.MessageName, e.PortalId }, "IX_SystemMessages").IsUnique();

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.MessageName).HasMaxLength(50);
            entity.Property(e => e.MessageValue).HasColumnType("ntext");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");

            entity.HasOne(d => d.Portal).WithMany(p => p.SystemMessages)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SystemMessages_Portals");
        });

        modelBuilder.Entity<Tab>(entity =>
        {
            entity.HasIndex(e => e.ContentItemId, "IX_Tabs_ContentID").HasFilter("([ContentItemId] IS NOT NULL)");

            entity.HasIndex(e => new { e.ParentId, e.IsDeleted }, "IX_Tabs_ParentId_IsDeleted");

            entity.HasIndex(e => new { e.PortalId, e.Level, e.ParentId, e.TabOrder, e.IsDeleted }, "IX_Tabs_PortalLevelParentOrder");

            entity.HasIndex(e => e.UniqueId, "IX_Tabs_UniqueId").IsUnique();

            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.ContainerSrc).HasMaxLength(200);
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IconFile).HasMaxLength(255);
            entity.Property(e => e.IconFileLarge).HasMaxLength(255);
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.KeyWords).HasMaxLength(500);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LocalizedVersionGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.SiteMapPriority).HasDefaultValue(0.5);
            entity.Property(e => e.SkinSrc).HasMaxLength(200);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TabName).HasMaxLength(200);
            entity.Property(e => e.TabPath)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Url).HasMaxLength(255);
            entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ContentItem).WithMany(p => p.Tabs)
                .HasForeignKey(d => d.ContentItemId)
                .HasConstraintName("FK_Tabs_ContentItems");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_Tabs_Tabs");

            entity.HasOne(d => d.Portal).WithMany(p => p.Tabs)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Tabs_Portals");
        });

        modelBuilder.Entity<TabAliasSkin>(entity =>
        {
            entity.HasKey(e => e.TabAliasSkinId).HasName("PK_TabAliasSkin");

            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.SkinSrc).HasMaxLength(200);
        });

        modelBuilder.Entity<TabModule>(entity =>
        {
            entity.HasIndex(e => new { e.ModuleId, e.TabId }, "IX_TabModules_ModuleID");

            entity.HasIndex(e => new { e.TabId, e.PaneName, e.ModuleOrder }, "IX_TabModules_ModuleOrder");

            entity.HasIndex(e => new { e.TabId, e.ModuleId }, "IX_TabModules_TabID").IsUnique();

            entity.HasIndex(e => e.UniqueId, "IX_TabModules_UniqueId").IsUnique();

            entity.Property(e => e.TabModuleId).HasColumnName("TabModuleID");
            entity.Property(e => e.Alignment).HasMaxLength(10);
            entity.Property(e => e.Border).HasMaxLength(1);
            entity.Property(e => e.CacheMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Color).HasMaxLength(20);
            entity.Property(e => e.ContainerSrc).HasMaxLength(200);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.DisplayPrint).HasDefaultValue(true);
            entity.Property(e => e.DisplaySyndicate).HasDefaultValue(true);
            entity.Property(e => e.DisplayTitle).HasDefaultValue(true);
            entity.Property(e => e.IconFile).HasMaxLength(100);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LocalizedVersionGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ModuleTitle).HasMaxLength(256);
            entity.Property(e => e.PaneName).HasMaxLength(50);
            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.WebSliceExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.WebSliceTitle).HasMaxLength(256);
            entity.Property(e => e.WebSliceTtl).HasColumnName("WebSliceTTL");

            entity.HasOne(d => d.Module).WithMany(p => p.TabModules)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK_TabModules_Modules");

            entity.HasOne(d => d.Tab).WithMany(p => p.TabModules)
                .HasForeignKey(d => d.TabId)
                .HasConstraintName("FK_TabModules_Tabs");
        });

        modelBuilder.Entity<TabModuleSetting>(entity =>
        {
            entity.HasKey(e => new { e.TabModuleId, e.SettingName });

            entity.Property(e => e.TabModuleId).HasColumnName("TabModuleID");
            entity.Property(e => e.SettingName).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

            entity.HasOne(d => d.TabModule).WithMany(p => p.TabModuleSettings)
                .HasForeignKey(d => d.TabModuleId)
                .HasConstraintName("FK_TabModuleSettings_TabModules");
        });

        modelBuilder.Entity<TabPermission>(entity =>
        {
            entity.ToTable("TabPermission");

            entity.HasIndex(e => e.PermissionId, "IX_TabPermission_Permission");

            entity.HasIndex(e => new { e.RoleId, e.TabId, e.PermissionId }, "IX_TabPermission_Roles")
                .IsUnique()
                .HasFilter("([RoleID] IS NOT NULL)");

            entity.HasIndex(e => new { e.TabId, e.PermissionId, e.RoleId, e.UserId }, "IX_TabPermission_Tabs").IsUnique();

            entity.HasIndex(e => new { e.UserId, e.TabId, e.PermissionId }, "IX_TabPermission_Users")
                .IsUnique()
                .HasFilter("([UserID] IS NOT NULL)");

            entity.Property(e => e.TabPermissionId).HasColumnName("TabPermissionID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Permission).WithMany(p => p.TabPermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK_TabPermission_Permission");

            entity.HasOne(d => d.Role).WithMany(p => p.TabPermissions)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_TabPermission_Roles");

            entity.HasOne(d => d.Tab).WithMany(p => p.TabPermissions)
                .HasForeignKey(d => d.TabId)
                .HasConstraintName("FK_TabPermission_Tabs");

            entity.HasOne(d => d.User).WithMany(p => p.TabPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TabPermission_Users");
        });

        modelBuilder.Entity<TabSetting>(entity =>
        {
            entity.HasKey(e => new { e.TabId, e.SettingName }).IsClustered(false);

            entity.HasIndex(e => new { e.TabId, e.SettingName }, "IX_TabSettings_TabID_SettingName")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.SettingName).HasMaxLength(50);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

            entity.HasOne(d => d.Tab).WithMany(p => p.TabSettings)
                .HasForeignKey(d => d.TabId)
                .HasConstraintName("FK_TabSettings_Tabs");
        });

        modelBuilder.Entity<TabUrl>(entity =>
        {
            entity.HasKey(e => new { e.TabId, e.SeqNum }).HasName("PK_TabRedirect");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(50);
            entity.Property(e => e.HttpStatus).HasMaxLength(50);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.QueryString).HasMaxLength(200);
            entity.Property(e => e.Url).HasMaxLength(200);

            entity.HasOne(d => d.Tab).WithMany(p => p.TabUrls)
                .HasForeignKey(d => d.TabId)
                .HasConstraintName("FK_TabUrls_Tabs");
        });

        modelBuilder.Entity<TabVersion>(entity =>
        {
            entity.HasIndex(e => new { e.TabId, e.Version }, "IX_TabVersions").IsUnique();

            entity.HasIndex(e => e.TabId, "IX_TabVersions_TabId");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");

            entity.HasOne(d => d.Tab).WithMany(p => p.TabVersions)
                .HasForeignKey(d => d.TabId)
                .HasConstraintName("FK_TabVersions_TabId");
        });

        modelBuilder.Entity<TabVersionDetail>(entity =>
        {
            entity.HasIndex(e => e.TabVersionId, "IX_TabVersionDetails_TabVersionId");

            entity.HasIndex(e => new { e.TabVersionId, e.ModuleId }, "IX_TabVersionDetails_Unique(TabVersionId_ModuleId)").IsUnique();

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PaneName).HasMaxLength(50);

            entity.HasOne(d => d.TabVersion).WithMany(p => p.TabVersionDetails)
                .HasForeignKey(d => d.TabVersionId)
                .HasConstraintName("FK_TabVersionDetails_TabVersionId");
        });

        modelBuilder.Entity<TaxonomyScopeType>(entity =>
        {
            entity.HasKey(e => e.ScopeTypeId).HasName("PK_ScopeTypes");

            entity.ToTable("Taxonomy_ScopeTypes");

            entity.Property(e => e.ScopeTypeId).HasColumnName("ScopeTypeID");
            entity.Property(e => e.ScopeType).HasMaxLength(250);
        });

        modelBuilder.Entity<TaxonomyTerm>(entity =>
        {
            entity.HasKey(e => e.TermId);

            entity.ToTable("Taxonomy_Terms");

            entity.Property(e => e.TermId).HasColumnName("TermID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(2500);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.ParentTermId).HasColumnName("ParentTermID");
            entity.Property(e => e.VocabularyId).HasColumnName("VocabularyID");

            entity.HasOne(d => d.ParentTerm).WithMany(p => p.InverseParentTerm)
                .HasForeignKey(d => d.ParentTermId)
                .HasConstraintName("FK_Taxonomy_Terms_Taxonomy_Terms");

            entity.HasOne(d => d.Vocabulary).WithMany(p => p.TaxonomyTerms)
                .HasForeignKey(d => d.VocabularyId)
                .HasConstraintName("FK_Taxonomy_Terms_Taxonomy_Vocabularies");
        });

        modelBuilder.Entity<TaxonomyVocabulary>(entity =>
        {
            entity.HasKey(e => e.VocabularyId).HasName("PK_Taxonomy_Vocabulary");

            entity.ToTable("Taxonomy_Vocabularies");

            entity.Property(e => e.VocabularyId).HasColumnName("VocabularyID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(2500);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.ScopeId).HasColumnName("ScopeID");
            entity.Property(e => e.ScopeTypeId).HasColumnName("ScopeTypeID");
            entity.Property(e => e.VocabularyTypeId).HasColumnName("VocabularyTypeID");

            entity.HasOne(d => d.ScopeType).WithMany(p => p.TaxonomyVocabularies)
                .HasForeignKey(d => d.ScopeTypeId)
                .HasConstraintName("FK_Taxonomy_Vocabularies_Taxonomy_ScopeTypes");

            entity.HasOne(d => d.VocabularyType).WithMany(p => p.TaxonomyVocabularies)
                .HasForeignKey(d => d.VocabularyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Taxonomy_Vocabularies_Taxonomy_VocabularyTypes");
        });

        modelBuilder.Entity<TaxonomyVocabularyType>(entity =>
        {
            entity.HasKey(e => e.VocabularyTypeId).HasName("PK_Taxonomy_VocabularyType");

            entity.ToTable("Taxonomy_VocabularyTypes");

            entity.Property(e => e.VocabularyTypeId).HasColumnName("VocabularyTypeID");
            entity.Property(e => e.VocabularyType).HasMaxLength(50);
        });

        modelBuilder.Entity<Url>(entity =>
        {
            entity.HasIndex(e => new { e.Url1, e.PortalId }, "IX_Urls").IsUnique();

            entity.Property(e => e.UrlId).HasColumnName("UrlID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.Url1)
                .HasMaxLength(255)
                .HasColumnName("Url");

            entity.HasOne(d => d.Portal).WithMany(p => p.Urls)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Urls_Portals");
        });

        modelBuilder.Entity<UrlLog>(entity =>
        {
            entity.ToTable("UrlLog");

            entity.Property(e => e.UrlLogId).HasColumnName("UrlLogID");
            entity.Property(e => e.ClickDate).HasColumnType("datetime");
            entity.Property(e => e.UrlTrackingId).HasColumnName("UrlTrackingID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.UrlTracking).WithMany(p => p.UrlLogs)
                .HasForeignKey(d => d.UrlTrackingId)
                .HasConstraintName("FK_UrlLog_UrlTracking");
        });

        modelBuilder.Entity<UrlTracking>(entity =>
        {
            entity.ToTable("UrlTracking");

            entity.HasIndex(e => new { e.PortalId, e.Url, e.ModuleId }, "IX_UrlTracking").IsUnique();

            entity.HasIndex(e => e.ModuleId, "IX_UrlTracking_ModuleId");

            entity.HasIndex(e => new { e.Url, e.ModuleId }, "IX_UrlTracking_Url_ModuleId");

            entity.Property(e => e.UrlTrackingId).HasColumnName("UrlTrackingID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastClick).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.TrackClicks).HasDefaultValue(true);
            entity.Property(e => e.Url).HasMaxLength(255);
            entity.Property(e => e.UrlType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Portal).WithMany(p => p.UrlTrackings)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UrlTracking_Portals");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Username, "IX_Users").IsUnique();

            entity.HasIndex(e => new { e.DisplayName, e.IsSuperUser, e.IsDeleted }, "IX_Users_DisplayName");

            entity.HasIndex(e => e.Email, "IX_Users_Email");

            entity.HasIndex(e => new { e.FirstName, e.IsSuperUser, e.IsDeleted }, "IX_Users_FirstName").HasFilter("([FirstName] IS NOT NULL AND [FirstName]<>N'')");

            entity.HasIndex(e => new { e.IsDeleted, e.DisplayName }, "IX_Users_IsDeleted_DisplayName");

            entity.HasIndex(e => new { e.IsSuperUser, e.Username }, "IX_Users_IsSuperuser")
                .IsUnique()
                .IsDescending(true, false)
                .HasFilter("([IsSuperUser]=(1))");

            entity.HasIndex(e => e.LastModifiedOnDate, "IX_Users_LastModifiedOnDate").IsDescending();

            entity.HasIndex(e => new { e.LastName, e.IsSuperUser, e.IsDeleted }, "IX_Users_LastName").HasFilter("([LastName] IS NOT NULL AND [LastName]<>N'')");

            entity.HasIndex(e => e.PasswordResetToken, "IX_Users_PasswordResetToken");

            entity.HasIndex(e => new { e.Username, e.UserId }, "IX_Users_UserName_UserID").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(128)
                .HasDefaultValue("");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastIpaddress)
                .HasMaxLength(50)
                .HasColumnName("LastIPAddress");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PasswordResetExpiration).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<UserAuthentication>(entity =>
        {
            entity.ToTable("UserAuthentication");

            entity.HasIndex(e => new { e.UserId, e.AuthenticationType }, "IX_UserAuthentication").IsUnique();

            entity.Property(e => e.UserAuthenticationId).HasColumnName("UserAuthenticationID");
            entity.Property(e => e.AuthenticationToken).HasMaxLength(1000);
            entity.Property(e => e.AuthenticationType).HasMaxLength(100);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserAuthentications)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserAuthentication_Users");
        });

        modelBuilder.Entity<UserPortal>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.PortalId });

            entity.HasIndex(e => e.PortalId, "IX_UserPortals");

            entity.HasIndex(e => new { e.PortalId, e.IsDeleted, e.Authorised, e.UserId }, "IX_UserPortals_PortalId_IsDeleted")
                .IsUnique()
                .IsDescending(false, false, true, false);

            entity.HasIndex(e => e.VanityUrl, "IX_UserPortals_VanityUrl");

            entity.Property(e => e.Authorised).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HasAgreedToTermsOn).HasColumnType("datetime");
            entity.Property(e => e.UserPortalId).ValueGeneratedOnAdd();
            entity.Property(e => e.VanityUrl).HasMaxLength(100);

            entity.HasOne(d => d.Portal).WithMany(p => p.UserPortals)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_UserPortals_Portals");

            entity.HasOne(d => d.User).WithMany(p => p.UserPortals)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserPortals_Users");
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasKey(e => e.ProfileId);

            entity.ToTable("UserProfile");

            entity.HasIndex(e => e.UserId, "IX_UserProfile");

            entity.HasIndex(e => e.LastUpdatedDate, "IX_UserProfile_LastUpdatedDate").IsDescending();

            entity.HasIndex(e => e.PropertyDefinitionId, "IX_UserProfile_PropertyDefinitionID");

            entity.HasIndex(e => new { e.UserId, e.PropertyDefinitionId }, "IX_UserProfile_UserID_PropertyDefinitionID");

            entity.HasIndex(e => new { e.UserId, e.ProfileId }, "IX_UserProfile_Visibility");

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.ExtendedVisibility)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PropertyDefinitionId).HasColumnName("PropertyDefinitionID");
            entity.Property(e => e.PropertyValue).HasMaxLength(3750);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.PropertyDefinition).WithMany(p => p.UserProfiles)
                .HasForeignKey(d => d.PropertyDefinitionId)
                .HasConstraintName("FK_UserProfile_ProfilePropertyDefinition");

            entity.HasOne(d => d.User).WithMany(p => p.UserProfiles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserProfile_Users");
        });

        modelBuilder.Entity<UserRelationship>(entity =>
        {
            entity.HasIndex(e => e.RelatedUserId, "IX_UserRelationships_RelatedUserID");

            entity.HasIndex(e => e.UserId, "IX_UserRelationships_UserID");

            entity.HasIndex(e => new { e.UserId, e.RelatedUserId, e.RelationshipId }, "IX_UserRelationships_UserID_RelatedUserID_RelationshipID").IsUnique();

            entity.Property(e => e.UserRelationshipId).HasColumnName("UserRelationshipID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RelatedUserId).HasColumnName("RelatedUserID");
            entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.RelatedUser).WithMany(p => p.UserRelationshipRelatedUsers)
                .HasForeignKey(d => d.RelatedUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRelationships_Users_OnRelatedUser");

            entity.HasOne(d => d.Relationship).WithMany(p => p.UserRelationships)
                .HasForeignKey(d => d.RelationshipId)
                .HasConstraintName("FK_UserRelationships_Relationships");

            entity.HasOne(d => d.User).WithMany(p => p.UserRelationshipUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRelationships_Users");
        });

        modelBuilder.Entity<UserRelationshipPreference>(entity =>
        {
            entity.HasKey(e => new { e.PreferenceId, e.RelationshipId });

            entity.Property(e => e.PreferenceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PreferenceID");
            entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Relationship).WithMany(p => p.UserRelationshipPreferences)
                .HasForeignKey(d => d.RelationshipId)
                .HasConstraintName("FK_UserRelationshipPreferences_Relationships");

            entity.HasOne(d => d.User).WithMany(p => p.UserRelationshipPreferences)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRelationshipPreferences_Users");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasIndex(e => new { e.RoleId, e.UserId }, "IX_UserRoles_RoleID_UserID").IsUnique();

            entity.HasIndex(e => new { e.RoleId, e.UserId }, "IX_UserRoles_RoleUser").IsUnique();

            entity.HasIndex(e => new { e.Status, e.EffectiveDate }, "IX_UserRoles_Status_EffectiveDate");

            entity.HasIndex(e => new { e.UserId, e.RoleId }, "IX_UserRoles_UserRole").IsUnique();

            entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_UserRoles_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserRoles_Users");
        });

        modelBuilder.Entity<UsersOnline>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.PortalId });

            entity.ToTable("UsersOnline");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.CreationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastActiveDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TabId).HasColumnName("TabID");

            entity.HasOne(d => d.Portal).WithMany(p => p.UsersOnlines)
                .HasForeignKey(d => d.PortalId)
                .HasConstraintName("FK_UsersOnline_Portals");

            entity.HasOne(d => d.User).WithMany(p => p.UsersOnlines)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UsersOnline_Users");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity.ToTable("Version");

            entity.HasIndex(e => new { e.Major, e.Minor, e.Build, e.Increment }, "IX_Version").IsUnique();

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<VwAspnetApplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Applications");

            entity.Property(e => e.ApplicationName).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_MembershipUsers");

            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredEmail).HasMaxLength(256);
            entity.Property(e => e.MobileAlias).HasMaxLength(16);
            entity.Property(e => e.MobilePin)
                .HasMaxLength(16)
                .HasColumnName("MobilePIN");
            entity.Property(e => e.PasswordAnswer).HasMaxLength(128);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Users");

            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredUserName).HasMaxLength(256);
            entity.Property(e => e.MobileAlias).HasMaxLength(16);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwContentWorkflowStatePermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ContentWorkflowStatePermissions");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.PermissionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.PermissionKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Username).HasMaxLength(100);
            entity.Property(e => e.WorkflowStatePermissionId).HasColumnName("WorkflowStatePermissionID");
        });

        modelBuilder.Entity<VwContentWorkflowUsage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ContentWorkflowUsage");

            entity.Property(e => e.ContentType).HasMaxLength(100);
            entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");
        });

        modelBuilder.Entity<VwCoreMessagingMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CoreMessaging_Messages");

            entity.Property(e => e.Context).HasMaxLength(200);
            entity.Property(e => e.ConversationId).HasColumnName("ConversationID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.EmailSentDate).HasColumnType("datetime");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.From).HasMaxLength(200);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.RecipientId).HasColumnName("RecipientID");
            entity.Property(e => e.SenderUserId).HasColumnName("SenderUserID");
            entity.Property(e => e.Subject).HasMaxLength(400);
            entity.Property(e => e.To).HasMaxLength(2000);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwDesktopModule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DesktopModules");

            entity.Property(e => e.AdminPage).HasMaxLength(128);
            entity.Property(e => e.BusinessControllerClass).HasMaxLength(200);
            entity.Property(e => e.CompatibleVersions).HasMaxLength(500);
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.ContentKey).HasMaxLength(250);
            entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Dependencies).HasMaxLength(400);
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");
            entity.Property(e => e.FolderName).HasMaxLength(128);
            entity.Property(e => e.FriendlyName).HasMaxLength(128);
            entity.Property(e => e.HostPage).HasMaxLength(128);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ModuleName).HasMaxLength(128);
            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.Permissions).HasMaxLength(400);
            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.Version).HasMaxLength(8);
        });

        modelBuilder.Entity<VwDesktopModulePermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_DesktopModulePermissions");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DesktopModulePermissionId).HasColumnName("DesktopModulePermissionID");
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.PermissionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.PermissionKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PortalDesktopModuleId).HasColumnName("PortalDesktopModuleID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<VwEventLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_EventLog");

            entity.Property(e => e.AssemblyVersion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExceptionHash)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InnerMessage).HasMaxLength(500);
            entity.Property(e => e.LogConfigId).HasColumnName("LogConfigID");
            entity.Property(e => e.LogCreateDate).HasColumnType("datetime");
            entity.Property(e => e.LogEventId).HasColumnName("LogEventID");
            entity.Property(e => e.LogGuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("LogGUID");
            entity.Property(e => e.LogPortalId).HasColumnName("LogPortalID");
            entity.Property(e => e.LogPortalName).HasMaxLength(100);
            entity.Property(e => e.LogProperties).HasColumnType("xml");
            entity.Property(e => e.LogServerName).HasMaxLength(50);
            entity.Property(e => e.LogTypeKey).HasMaxLength(35);
            entity.Property(e => e.LogUserId).HasColumnName("LogUserID");
            entity.Property(e => e.LogUserName).HasMaxLength(50);
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.RawUrl).HasMaxLength(260);
            entity.Property(e => e.Referrer).HasMaxLength(260);
            entity.Property(e => e.Source).HasMaxLength(500);
            entity.Property(e => e.UserAgent).HasMaxLength(260);
        });

        modelBuilder.Entity<VwExtensionUrlProvider>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ExtensionUrlProviders");

            entity.Property(e => e.ExtensionUrlProviderId).HasColumnName("ExtensionUrlProviderID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.ProviderName).HasMaxLength(150);
        });

        modelBuilder.Entity<VwFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Files");

            entity.Property(e => e.Content).HasColumnType("image");
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.ContentType).HasMaxLength(200);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Extension).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(246);
            entity.Property(e => e.Folder).HasMaxLength(300);
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.FolderMappingId).HasColumnName("FolderMappingID");
            entity.Property(e => e.LastModificationTime).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Sha1hash)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SHA1Hash");
            entity.Property(e => e.Title).HasMaxLength(256);
        });

        modelBuilder.Entity<VwFolderPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_FolderPermissions");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.FolderPath).HasMaxLength(300);
            entity.Property(e => e.FolderPermissionId).HasColumnName("FolderPermissionID");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.PermissionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.PermissionKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<VwList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Lists");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DefinitionId).HasColumnName("DefinitionID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EntryId).HasColumnName("EntryID");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ListName).HasMaxLength(50);
            entity.Property(e => e.Parent).HasMaxLength(2000);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.ParentKey).HasMaxLength(2000);
            entity.Property(e => e.ParentList).HasMaxLength(2000);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.Text).HasMaxLength(150);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<VwMasterPortal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MasterPortals");

            entity.Property(e => e.MasterPortalId).HasColumnName("MasterPortalID");
            entity.Property(e => e.PortalGroupId).HasColumnName("PortalGroupID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
        });

        modelBuilder.Entity<VwMessagesForDispatch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MessagesForDispatch");

            entity.Property(e => e.RecipientId).HasColumnName("RecipientID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwModule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Modules");

            entity.Property(e => e.Alignment).HasMaxLength(10);
            entity.Property(e => e.Border).HasMaxLength(1);
            entity.Property(e => e.BusinessControllerClass).HasMaxLength(200);
            entity.Property(e => e.CacheMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Color).HasMaxLength(20);
            entity.Property(e => e.ContainerSrc).HasMaxLength(200);
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.ContentKey).HasMaxLength(250);
            entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.DefinitionName).HasMaxLength(128);
            entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IconFile).HasMaxLength(546);
            entity.Property(e => e.LastContentModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleControlId).HasColumnName("ModuleControlID");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ModuleTitle).HasMaxLength(256);
            entity.Property(e => e.OwnerPortalId).HasColumnName("OwnerPortalID");
            entity.Property(e => e.PackageId).HasColumnName("PackageID");
            entity.Property(e => e.PaneName).HasMaxLength(50);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.TabEndDate).HasColumnType("datetime");
            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.TabModuleId).HasColumnName("TabModuleID");
            entity.Property(e => e.TabStartDate).HasColumnType("datetime");
            entity.Property(e => e.WebSliceExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.WebSliceTitle).HasMaxLength(256);
            entity.Property(e => e.WebSliceTtl).HasColumnName("WebSliceTTL");
        });

        modelBuilder.Entity<VwModulePermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_ModulePermissions");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ModulePermissionId).HasColumnName("ModulePermissionID");
            entity.Property(e => e.PermissionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.PermissionKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<VwPersonaBarMenuPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PersonaBarMenuPermissions");

            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.PermissionCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PermissionKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<VwPortal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Portals");

            entity.Property(e => e.BackgroundFile).HasMaxLength(546);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DefaultLanguage).HasMaxLength(10);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.FooterText).HasMaxLength(100);
            entity.Property(e => e.Guid).HasColumnName("GUID");
            entity.Property(e => e.HomeDirectory)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HostFee).HasColumnType("money");
            entity.Property(e => e.KeyWords).HasMaxLength(500);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LogoFile).HasMaxLength(546);
            entity.Property(e => e.PaymentProcessor).HasMaxLength(50);
            entity.Property(e => e.PortalGroupId).HasColumnName("PortalGroupID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.PortalName).HasMaxLength(128);
            entity.Property(e => e.ProcessorPassword).HasMaxLength(100);
            entity.Property(e => e.ProcessorUserId).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPortalPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PortalPermissions");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.PermissionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.PermissionKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PortalPermissionId).HasColumnName("PortalPermissionID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<VwPortalsDefaultLanguage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PortalsDefaultLanguage");

            entity.Property(e => e.BackgroundFile).HasMaxLength(546);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DefaultLanguage).HasMaxLength(10);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.FooterText).HasMaxLength(100);
            entity.Property(e => e.Guid).HasColumnName("GUID");
            entity.Property(e => e.HomeDirectory)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HostFee).HasColumnType("money");
            entity.Property(e => e.KeyWords).HasMaxLength(500);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LogoFile).HasMaxLength(546);
            entity.Property(e => e.PaymentProcessor).HasMaxLength(50);
            entity.Property(e => e.PortalGroupId).HasColumnName("PortalGroupID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.PortalName).HasMaxLength(128);
            entity.Property(e => e.ProcessorPassword).HasMaxLength(100);
            entity.Property(e => e.ProcessorUserId).HasMaxLength(50);
        });

        modelBuilder.Entity<VwProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Profile");

            entity.Property(e => e.ExtendedVisibility)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.PropertyDefinitionId).HasColumnName("PropertyDefinitionID");
            entity.Property(e => e.PropertyName).HasMaxLength(50);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VwPublishedFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_PublishedFiles");

            entity.Property(e => e.Content).HasColumnType("image");
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.ContentType).HasMaxLength(200);
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Extension).HasMaxLength(100);
            entity.Property(e => e.FileName).HasMaxLength(246);
            entity.Property(e => e.Folder).HasMaxLength(300);
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.FolderMappingId).HasColumnName("FolderMappingID");
            entity.Property(e => e.LastModificationTime).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Sha1hash)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SHA1Hash");
            entity.Property(e => e.Title).HasMaxLength(256);
        });

        modelBuilder.Entity<VwTab>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Tabs");

            entity.Property(e => e.ContainerSrc).HasMaxLength(200);
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.ContentKey).HasMaxLength(250);
            entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.HasChildren)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.IconFile).HasMaxLength(546);
            entity.Property(e => e.IconFileLarge).HasMaxLength(546);
            entity.Property(e => e.KeyWords).HasMaxLength(500);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.SkinSrc).HasMaxLength(200);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.TabName).HasMaxLength(200);
            entity.Property(e => e.TabPath).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(200);
            entity.Property(e => e.Url).HasMaxLength(255);
        });

        modelBuilder.Entity<VwTabModule>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TabModules");

            entity.Property(e => e.Alignment).HasMaxLength(10);
            entity.Property(e => e.Border).HasMaxLength(1);
            entity.Property(e => e.BusinessControllerClass).HasMaxLength(200);
            entity.Property(e => e.CacheMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Color).HasMaxLength(20);
            entity.Property(e => e.ContainerSrc).HasMaxLength(200);
            entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");
            entity.Property(e => e.ContentKey).HasMaxLength(250);
            entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.CultureCode).HasMaxLength(10);
            entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IconFile).HasMaxLength(546);
            entity.Property(e => e.LastContentModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleControlId).HasColumnName("ModuleControlID");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            entity.Property(e => e.ModuleTitle).HasMaxLength(256);
            entity.Property(e => e.OwnerPortalId).HasColumnName("OwnerPortalID");
            entity.Property(e => e.PaneName).HasMaxLength(50);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.TabModuleId).HasColumnName("TabModuleID");
            entity.Property(e => e.WebSliceExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.WebSliceTitle).HasMaxLength(256);
            entity.Property(e => e.WebSliceTtl).HasColumnName("WebSliceTTL");
        });

        modelBuilder.Entity<VwTabPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_TabPermissions");

            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");
            entity.Property(e => e.PermissionCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.PermissionKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermissionName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.TabPermissionId).HasColumnName("TabPermissionID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<VwUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Users");

            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.HasAgreedToTermsOn).HasColumnType("datetime");
            entity.Property(e => e.LastIpaddress)
                .HasMaxLength(50)
                .HasColumnName("LastIPAddress");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PasswordResetExpiration).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(100);
            entity.Property(e => e.VanityUrl).HasMaxLength(100);
        });

        modelBuilder.Entity<VwUserRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_UserRoles");

            entity.Property(e => e.BillingFrequency)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");
            entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DisplayName).HasMaxLength(128);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.IconFile).HasMaxLength(100);
            entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");
            entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.Rsvpcode)
                .HasMaxLength(50)
                .HasColumnName("RSVPCode");
            entity.Property(e => e.ServiceFee).HasColumnType("money");
            entity.Property(e => e.TrialFee).HasColumnType("money");
            entity.Property(e => e.TrialFrequency)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<WebServer>(entity =>
        {
            entity.HasKey(e => e.ServerId);

            entity.HasIndex(e => new { e.ServerName, e.IisappName }, "IX_WebServers_ServerName").IsUnique();

            entity.Property(e => e.ServerId).HasColumnName("ServerID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.IisappName)
                .HasMaxLength(200)
                .HasDefaultValue("")
                .HasColumnName("IISAppName");
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.ServerGroup).HasMaxLength(200);
            entity.Property(e => e.ServerName).HasMaxLength(50);
            entity.Property(e => e.UniqueId).HasMaxLength(200);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<Workflow>(entity =>
        {
            entity.ToTable("Workflow");

            entity.HasIndex(e => new { e.PortalId, e.WorkflowName }, "IX_Workflow").IsUnique();

            entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.PortalId).HasColumnName("PortalID");
            entity.Property(e => e.WorkflowName).HasMaxLength(50);
        });

        modelBuilder.Entity<WorkflowState>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.HasIndex(e => new { e.WorkflowId, e.StateName }, "IX_WorkflowStates").IsUnique();

            entity.Property(e => e.StateId).HasColumnName("StateID");
            entity.Property(e => e.StateName).HasMaxLength(50);
            entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

            entity.HasOne(d => d.Workflow).WithMany(p => p.WorkflowStates)
                .HasForeignKey(d => d.WorkflowId)
                .HasConstraintName("FK_WorkflowStates_Workflow");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
