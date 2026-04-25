using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PackageType
{
    public string PackageType1 { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int SecurityAccessLevel { get; set; }

    public string? EditorControlSrc { get; set; }

    public bool SupportsSideBySideInstallation { get; set; }

    public virtual ICollection<Package> Packages { get; set; } = new List<Package>();
}
