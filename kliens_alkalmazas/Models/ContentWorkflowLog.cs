using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ContentWorkflowLog
{
    public int WorkflowLogId { get; set; }

    public string Action { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime Date { get; set; }

    public int User { get; set; }

    public int WorkflowId { get; set; }

    public int ContentItemId { get; set; }

    public int Type { get; set; }

    public virtual ContentItem ContentItem { get; set; } = null!;

    public virtual ContentWorkflow Workflow { get; set; } = null!;
}
