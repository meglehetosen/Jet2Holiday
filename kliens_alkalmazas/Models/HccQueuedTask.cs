using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccQueuedTask
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string FriendlyName { get; set; } = null!;

    public string TaskProcessorName { get; set; } = null!;

    public Guid TaskProcessorId { get; set; }

    public string Payload { get; set; } = null!;

    public int Status { get; set; }

    public string StatusNotes { get; set; } = null!;

    public DateTime StartAtUtc { get; set; }
}
