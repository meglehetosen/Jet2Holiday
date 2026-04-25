using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ContentWorkflowSource
{
    public int SourceId { get; set; }

    public int WorkflowId { get; set; }

    public string SourceName { get; set; } = null!;

    public string SourceType { get; set; } = null!;

    public virtual ContentWorkflow Workflow { get; set; } = null!;
}
