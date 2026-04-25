using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwExtensionUrlProvider
{
    public int ExtensionUrlProviderId { get; set; }

    public int? PortalId { get; set; }

    public string ProviderName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool RewriteAllUrls { get; set; }

    public bool RedirectAllUrls { get; set; }

    public bool ReplaceAllUrls { get; set; }

    public int? DesktopModuleId { get; set; }
}
