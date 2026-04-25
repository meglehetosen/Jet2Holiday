using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Url
{
    public int UrlId { get; set; }

    public int? PortalId { get; set; }

    public string Url1 { get; set; } = null!;

    public virtual Portal? Portal { get; set; }
}
