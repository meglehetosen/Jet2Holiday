using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccAudit
{
    public long Id { get; set; }

    public DateTime TimeStampUtc { get; set; }

    public int SourceModule { get; set; }

    public string ShortName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string UserIdText { get; set; } = null!;

    public int Severity { get; set; }

    public long StoreId { get; set; }
}
