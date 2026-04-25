using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccOrderNote
{
    public long Id { get; set; }

    public Guid OrderId { get; set; }

    public DateTime AuditDate { get; set; }

    public string Note { get; set; } = null!;

    public bool IsPublic { get; set; }

    public DateTime LastUpdatedUtc { get; set; }

    public long StoreId { get; set; }

    public virtual HccOrder Order { get; set; } = null!;
}
