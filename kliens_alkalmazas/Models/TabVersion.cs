using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class TabVersion
{
    public int TabVersionId { get; set; }

    public int TabId { get; set; }

    public int Version { get; set; }

    public DateTime TimeStamp { get; set; }

    public bool IsPublished { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public virtual Tab Tab { get; set; } = null!;

    public virtual ICollection<TabVersionDetail> TabVersionDetails { get; set; } = new List<TabVersionDetail>();
}
