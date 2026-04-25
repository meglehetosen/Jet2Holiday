using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccMembershipProductType
{
    public Guid ProductTypeBvin { get; set; }

    public string RoleName { get; set; } = null!;

    public int ExpirationPeriod { get; set; }

    public int ExpirationPeriodType { get; set; }

    public bool Notify { get; set; }

    public virtual HccProductType ProductTypeBvinNavigation { get; set; } = null!;
}
