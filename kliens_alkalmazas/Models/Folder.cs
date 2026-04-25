using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Folder
{
    public int FolderId { get; set; }

    public int? PortalId { get; set; }

    public string FolderPath { get; set; } = null!;

    public int StorageLocation { get; set; }

    public bool IsProtected { get; set; }

    public bool IsCached { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    public int FolderMappingId { get; set; }

    public int? ParentId { get; set; }

    public bool IsVersioned { get; set; }

    public int? WorkflowId { get; set; }

    public string? MappedPath { get; set; }

    public virtual ICollection<File> Files { get; set; } = new List<File>();

    public virtual FolderMapping FolderMapping { get; set; } = null!;

    public virtual ICollection<FolderPermission> FolderPermissions { get; set; } = new List<FolderPermission>();

    public virtual Portal? Portal { get; set; }

    public virtual ContentWorkflow? Workflow { get; set; }
}
