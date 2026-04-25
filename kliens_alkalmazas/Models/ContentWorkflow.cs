using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ContentWorkflow
{
    public int WorkflowId { get; set; }

    public int? PortalId { get; set; }

    public string WorkflowName { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public bool StartAfterCreating { get; set; }

    public bool StartAfterEditing { get; set; }

    public bool DispositionEnabled { get; set; }

    public bool IsSystem { get; set; }

    public string WorkflowKey { get; set; } = null!;

    public virtual ICollection<ContentWorkflowLog> ContentWorkflowLogs { get; set; } = new List<ContentWorkflowLog>();

    public virtual ICollection<ContentWorkflowSource> ContentWorkflowSources { get; set; } = new List<ContentWorkflowSource>();

    public virtual ICollection<ContentWorkflowState> ContentWorkflowStates { get; set; } = new List<ContentWorkflowState>();

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();
}
