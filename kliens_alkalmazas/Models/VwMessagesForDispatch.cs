using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwMessagesForDispatch
{
    public int UserId { get; set; }

    public int RecipientId { get; set; }

    public Guid? EmailSchedulerInstance { get; set; }

    public int EmailFrequency { get; set; }
}
