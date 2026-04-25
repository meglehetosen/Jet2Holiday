using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class CoreMessagingMessage
{
    public int MessageId { get; set; }

    public int? PortalId { get; set; }

    public int? NotificationTypeId { get; set; }

    public string? To { get; set; }

    public string? From { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public int? ConversationId { get; set; }

    public bool? ReplyAllAllowed { get; set; }

    public int? SenderUserId { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public string? Context { get; set; }

    public bool? IncludeDismissAction { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual ICollection<CoreMessagingMessageAttachment> CoreMessagingMessageAttachments { get; set; } = new List<CoreMessagingMessageAttachment>();

    public virtual ICollection<CoreMessagingMessageRecipient> CoreMessagingMessageRecipients { get; set; } = new List<CoreMessagingMessageRecipient>();

    public virtual CoreMessagingNotificationType? NotificationType { get; set; }
}
