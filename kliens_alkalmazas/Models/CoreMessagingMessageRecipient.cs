using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class CoreMessagingMessageRecipient
{
    public int RecipientId { get; set; }

    public int MessageId { get; set; }

    public int UserId { get; set; }

    public bool Read { get; set; }

    public bool Archived { get; set; }

    public bool EmailSent { get; set; }

    public DateTime? EmailSentDate { get; set; }

    public Guid? EmailSchedulerInstance { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public bool SendToast { get; set; }

    public virtual CoreMessagingMessage Message { get; set; } = null!;
}
