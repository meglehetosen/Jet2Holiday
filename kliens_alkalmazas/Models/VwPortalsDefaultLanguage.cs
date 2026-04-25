using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwPortalsDefaultLanguage
{
    public int PortalId { get; set; }

    public int? PortalGroupId { get; set; }

    public string PortalName { get; set; } = null!;

    public string? LogoFile { get; set; }

    public string? FooterText { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int UserRegistration { get; set; }

    public int BannerAdvertising { get; set; }

    public int? AdministratorId { get; set; }

    public string? Currency { get; set; }

    public decimal HostFee { get; set; }

    public int HostSpace { get; set; }

    public int PageQuota { get; set; }

    public int UserQuota { get; set; }

    public int? AdministratorRoleId { get; set; }

    public int? RegisteredRoleId { get; set; }

    public string? Description { get; set; }

    public string? KeyWords { get; set; }

    public string? BackgroundFile { get; set; }

    public Guid Guid { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? ProcessorUserId { get; set; }

    public string? ProcessorPassword { get; set; }

    public int? SiteLogHistory { get; set; }

    public string? Email { get; set; }

    public string DefaultLanguage { get; set; } = null!;

    public int TimezoneOffset { get; set; }

    public int? AdminTabId { get; set; }

    public string HomeDirectory { get; set; } = null!;

    public int? SplashTabId { get; set; }

    public int? HomeTabId { get; set; }

    public int? LoginTabId { get; set; }

    public int? RegisterTabId { get; set; }

    public int? UserTabId { get; set; }

    public int? SearchTabId { get; set; }

    public int? Custom404TabId { get; set; }

    public int? Custom500TabId { get; set; }

    public int? TermsTabId { get; set; }

    public int? PrivacyTabId { get; set; }

    public int? SuperTabId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string CultureCode { get; set; } = null!;
}
