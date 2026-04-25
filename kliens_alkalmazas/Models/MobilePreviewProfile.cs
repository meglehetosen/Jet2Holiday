using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class MobilePreviewProfile
{
    public int Id { get; set; }

    public int PortalId { get; set; }

    public string Name { get; set; } = null!;

    public int Width { get; set; }

    public int Height { get; set; }

    public string UserAgent { get; set; } = null!;

    public int SortOrder { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public virtual Portal Portal { get; set; } = null!;
}
