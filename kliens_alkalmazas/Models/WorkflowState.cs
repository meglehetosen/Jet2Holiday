using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class WorkflowState
{
    public int StateId { get; set; }

    public int WorkflowId { get; set; }

    public string StateName { get; set; } = null!;

    public int Order { get; set; }

    public bool IsActive { get; set; }

    public bool Notify { get; set; }

    public virtual ICollection<HtmlTextLog> HtmlTextLogs { get; set; } = new List<HtmlTextLog>();

    public virtual ICollection<HtmlText> HtmlTexts { get; set; } = new List<HtmlText>();

    public virtual Workflow Workflow { get; set; } = null!;
}
