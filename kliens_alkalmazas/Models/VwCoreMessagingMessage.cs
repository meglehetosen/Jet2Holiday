using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwCoreMessagingMessage
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

    public int RecipientId { get; set; }

    public int UserId { get; set; }

    public bool Read { get; set; }

    public bool Archived { get; set; }

    public bool EmailSent { get; set; }

    public DateTime? EmailSentDate { get; set; }

    public Guid? EmailSchedulerInstance { get; set; }
}
