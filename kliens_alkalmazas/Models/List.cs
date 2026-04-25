using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class List
{
    public int EntryId { get; set; }

    public string ListName { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Text { get; set; } = null!;

    public int ParentId { get; set; }

    public int Level { get; set; }

    public int SortOrder { get; set; }

    public int DefinitionId { get; set; }

    public string? Description { get; set; }

    public int PortalId { get; set; }

    public bool SystemList { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }
}
