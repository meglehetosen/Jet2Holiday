using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class CoreMessagingNotificationType
{
    public int NotificationTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? Ttl { get; set; }

    public int? DesktopModuleId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsTask { get; set; }

    public virtual ICollection<CoreMessagingMessage> CoreMessagingMessages { get; set; } = new List<CoreMessagingMessage>();

    public virtual ICollection<CoreMessagingNotificationTypeAction> CoreMessagingNotificationTypeActions { get; set; } = new List<CoreMessagingNotificationTypeAction>();

    public virtual DesktopModule? DesktopModule { get; set; }
}
