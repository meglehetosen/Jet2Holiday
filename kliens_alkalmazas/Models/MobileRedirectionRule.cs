using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class MobileRedirectionRule
{
    public int Id { get; set; }

    public int RedirectionId { get; set; }

    public string Capability { get; set; } = null!;

    public string Expression { get; set; } = null!;

    public virtual MobileRedirection Redirection { get; set; } = null!;
}
