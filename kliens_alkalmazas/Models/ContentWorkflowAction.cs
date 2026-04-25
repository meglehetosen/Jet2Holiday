using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ContentWorkflowAction
{
    public int ActionId { get; set; }

    public int ContentTypeId { get; set; }

    public string ActionType { get; set; } = null!;

    public string ActionSource { get; set; } = null!;

    public virtual ContentType ContentType { get; set; } = null!;
}
