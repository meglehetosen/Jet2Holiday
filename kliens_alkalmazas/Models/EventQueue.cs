using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class EventQueue
{
    public int EventMessageId { get; set; }

    public string EventName { get; set; } = null!;

    public int Priority { get; set; }

    public string ProcessorType { get; set; } = null!;

    public string ProcessorCommand { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string Sender { get; set; } = null!;

    public string Subscriber { get; set; } = null!;

    public string AuthorizedRoles { get; set; } = null!;

    public string ExceptionMessage { get; set; } = null!;

    public DateTime SentDate { get; set; }

    public DateTime ExpirationDate { get; set; }

    public string Attributes { get; set; } = null!;

    public bool IsComplete { get; set; }
}
