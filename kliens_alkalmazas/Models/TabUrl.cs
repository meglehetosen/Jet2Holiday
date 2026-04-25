using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class TabUrl
{
    public int TabId { get; set; }

    public int SeqNum { get; set; }

    public string Url { get; set; } = null!;

    public string? QueryString { get; set; }

    public string HttpStatus { get; set; } = null!;

    public string? CultureCode { get; set; }

    public bool IsSystem { get; set; }

    public int? PortalAliasId { get; set; }

    public int? PortalAliasUsage { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Tab Tab { get; set; } = null!;
}
