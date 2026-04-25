using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class FileVersion
{
    public int FileId { get; set; }

    public int Version { get; set; }

    public string FileName { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public int Size { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string ContentType { get; set; } = null!;

    public byte[]? Content { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? Sha1hash { get; set; }

    public virtual File File { get; set; } = null!;
}
