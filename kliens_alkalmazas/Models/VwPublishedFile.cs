using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwPublishedFile
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

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateOnly StartDate { get; set; }

    public bool EnablePublishPeriod { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? ContentItemId { get; set; }

    public int PublishedVersion { get; set; }

    public string Folder { get; set; } = null!;

    public bool IsCached { get; set; }

    public int StorageLocation { get; set; }

    public int FolderMappingId { get; set; }

    public bool HasBeenPublished { get; set; }
}
