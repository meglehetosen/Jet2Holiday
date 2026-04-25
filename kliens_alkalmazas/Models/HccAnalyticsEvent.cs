using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccAnalyticsEvent
{
    public long AnalyticsEventId { get; set; }

    public string? UserId { get; set; }

    public Guid? SessionGuid { get; set; }

    public long StoreId { get; set; }

    public string Action { get; set; } = null!;

    public Guid? ObjectId { get; set; }

    public string? AdditionalData { get; set; }

    public DateTime DateTime { get; set; }

    public Guid? ShoppingSessionGuid { get; set; }
}
