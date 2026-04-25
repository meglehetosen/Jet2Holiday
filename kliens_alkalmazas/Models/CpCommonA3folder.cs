using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class CpCommonA3folder
{
    public int Id { get; set; }

    public int PortalId { get; set; }

    public int UserId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<CpCommonA3file> CpCommonA3files { get; set; } = new List<CpCommonA3file>();

    public virtual Portal Portal { get; set; } = null!;
}
