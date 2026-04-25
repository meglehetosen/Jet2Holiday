using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class TabAliasSkin
{
    public int TabAliasSkinId { get; set; }

    public int TabId { get; set; }

    public int PortalAliasId { get; set; }

    public string SkinSrc { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }
}
