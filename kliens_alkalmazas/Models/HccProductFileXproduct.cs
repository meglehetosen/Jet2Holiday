using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductFileXproduct
{
    public Guid ProductFileId { get; set; }

    public Guid ProductId { get; set; }

    public int AvailableMinutes { get; set; }

    public int MaxDownloads { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public long Id { get; set; }

    public virtual HccProduct Product { get; set; } = null!;

    public virtual HccProductFile ProductFile { get; set; } = null!;
}
