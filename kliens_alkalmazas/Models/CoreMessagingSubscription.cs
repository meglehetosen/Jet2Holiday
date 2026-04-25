using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class CoreMessagingSubscription
{
    public int SubscriptionId { get; set; }

    public int UserId { get; set; }

    public int? PortalId { get; set; }

    public int SubscriptionTypeId { get; set; }

    public string? ObjectKey { get; set; }

    public string? ObjectData { get; set; }

    public string Description { get; set; } = null!;

    public DateTime CreatedOnDate { get; set; }

    public int? ModuleId { get; set; }

    public int? TabId { get; set; }

    public virtual Module? Module { get; set; }

    public virtual Portal? Portal { get; set; }

    public virtual CoreMessagingSubscriptionType SubscriptionType { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
