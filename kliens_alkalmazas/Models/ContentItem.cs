using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ContentItem
{
    public int ContentItemId { get; set; }

    public string? Content { get; set; }

    public int ContentTypeId { get; set; }

    public int TabId { get; set; }

    public int ModuleId { get; set; }

    public string? ContentKey { get; set; }

    public bool Indexed { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public int? StateId { get; set; }

    public virtual ICollection<ContentItemsMetaDatum> ContentItemsMetaData { get; set; } = new List<ContentItemsMetaDatum>();

    public virtual ICollection<ContentItemsTag> ContentItemsTags { get; set; } = new List<ContentItemsTag>();

    public virtual ContentType ContentType { get; set; } = null!;

    public virtual ICollection<ContentWorkflowLog> ContentWorkflowLogs { get; set; } = new List<ContentWorkflowLog>();

    public virtual ICollection<File> Files { get; set; } = new List<File>();

    public virtual ICollection<Module> Modules { get; set; } = new List<Module>();

    public virtual ContentWorkflowState? State { get; set; }

    public virtual ICollection<Tab> Tabs { get; set; } = new List<Tab>();
}
