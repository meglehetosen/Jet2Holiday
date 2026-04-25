using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class File
{
    public int FileId { get; set; }

    public int? PortalId { get; set; }

    public string FileName { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public int Size { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string ContentType { get; set; } = null!;

    public int FolderId { get; set; }

    public byte[]? Content { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    public string? Sha1hash { get; set; }

    public DateTime LastModificationTime { get; set; }

    public string? Folder { get; set; }

    public string? Title { get; set; }

    public DateOnly StartDate { get; set; }

    public bool EnablePublishPeriod { get; set; }

    public DateOnly? EndDate { get; set; }

    public int PublishedVersion { get; set; }

    public int? ContentItemId { get; set; }

    public bool HasBeenPublished { get; set; }

    public string? Description { get; set; }

    public virtual ContentItem? ContentItem { get; set; }

    public virtual ICollection<FileVersion> FileVersions { get; set; } = new List<FileVersion>();

    public virtual Folder FolderNavigation { get; set; } = null!;

    public virtual Portal? Portal { get; set; }
}
