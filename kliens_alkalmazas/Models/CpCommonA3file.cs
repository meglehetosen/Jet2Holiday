using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class CpCommonA3file
{
    public int Id { get; set; }

    public int FolderId { get; set; }

    public int? PortalId { get; set; }

    public int? UserId { get; set; }

    public string? FileName { get; set; }

    public string? Bucket { get; set; }

    public string? A3key { get; set; }

    public string? Extension { get; set; }

    public int? Size { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string? Duration { get; set; }

    public string? ContentType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual CpCommonA3folder Folder { get; set; } = null!;
}
