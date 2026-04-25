using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class CoreMessagingNotificationTypeAction
{
    public int NotificationTypeActionId { get; set; }

    public int NotificationTypeId { get; set; }

    public string NameResourceKey { get; set; } = null!;

    public string? DescriptionResourceKey { get; set; }

    public string? ConfirmResourceKey { get; set; }

    public int Order { get; set; }

    public string Apicall { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual CoreMessagingNotificationType NotificationType { get; set; } = null!;
}
