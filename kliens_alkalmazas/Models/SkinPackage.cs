using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class SkinPackage
{
    public int SkinPackageId { get; set; }

    public int PackageId { get; set; }

    public int? PortalId { get; set; }

    public string SkinName { get; set; } = null!;

    public string SkinType { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Package Package { get; set; } = null!;

    public virtual ICollection<Skin> Skins { get; set; } = new List<Skin>();
}
