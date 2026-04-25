using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Authentication
{
    public int AuthenticationId { get; set; }

    public int PackageId { get; set; }

    public string AuthenticationType { get; set; } = null!;

    public bool IsEnabled { get; set; }

    public string SettingsControlSrc { get; set; } = null!;

    public string LoginControlSrc { get; set; } = null!;

    public string LogoffControlSrc { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Package Package { get; set; } = null!;
}
