using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class JournalComment
{
    public int CommentId { get; set; }

    public int JournalId { get; set; }

    public int UserId { get; set; }

    public string? Comment { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public string? CommentXml { get; set; }

    public virtual Journal Journal { get; set; } = null!;
}
