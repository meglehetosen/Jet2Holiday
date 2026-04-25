using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ContentType
{
    public int ContentTypeId { get; set; }

    public string ContentType1 { get; set; } = null!;

    public virtual ICollection<ContentItem> ContentItems { get; set; } = new List<ContentItem>();

    public virtual ICollection<ContentWorkflowAction> ContentWorkflowActions { get; set; } = new List<ContentWorkflowAction>();
}
