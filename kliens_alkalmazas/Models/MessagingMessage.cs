using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class MessagingMessage
{
    public long MessageId { get; set; }

    public int PortalId { get; set; }

    public int FromUserId { get; set; }

    public string? ToUserName { get; set; }

    public string? FromUserName { get; set; }

    public int? ToUserId { get; set; }

    public int? ToRoleId { get; set; }

    public byte Status { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public DateTime Date { get; set; }

    public Guid Conversation { get; set; }

    public long? ReplyTo { get; set; }

    public bool AllowReply { get; set; }

    public bool SkipPortal { get; set; }

    public bool EmailSent { get; set; }

    public DateTime? EmailSentDate { get; set; }

    public Guid? EmailSchedulerInstance { get; set; }
}
