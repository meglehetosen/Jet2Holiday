using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HtmlText
{
    public int ModuleId { get; set; }

    public int ItemId { get; set; }

    public string? Content { get; set; }

    public int? Version { get; set; }

    public int? StateId { get; set; }

    public bool? IsPublished { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? Summary { get; set; }

    public virtual ICollection<HtmlTextLog> HtmlTextLogs { get; set; } = new List<HtmlTextLog>();

    public virtual ICollection<HtmlTextUser> HtmlTextUsers { get; set; } = new List<HtmlTextUser>();

    public virtual Module Module { get; set; } = null!;

    public virtual WorkflowState? State { get; set; }
}
