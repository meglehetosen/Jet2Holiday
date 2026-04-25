using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PortalLocalization
{
    public int PortalId { get; set; }

    public string CultureCode { get; set; } = null!;

    public string PortalName { get; set; } = null!;

    public string? LogoFile { get; set; }

    public string? FooterText { get; set; }

    public string? Description { get; set; }

    public string? KeyWords { get; set; }

    public string? BackgroundFile { get; set; }

    public int? HomeTabId { get; set; }

    public int? LoginTabId { get; set; }

    public int? UserTabId { get; set; }

    public int? AdminTabId { get; set; }

    public int? SplashTabId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public int? RegisterTabId { get; set; }

    public int? SearchTabId { get; set; }

    public int? Custom404TabId { get; set; }

    public int? Custom500TabId { get; set; }

    public int? TermsTabId { get; set; }

    public int? PrivacyTabId { get; set; }

    public virtual Portal Portal { get; set; } = null!;
}
