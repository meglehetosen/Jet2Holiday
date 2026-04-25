using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Assembly
{
    public int AssemblyId { get; set; }

    public int? PackageId { get; set; }

    public string AssemblyName { get; set; } = null!;

    public string Version { get; set; } = null!;

    public virtual Package? Package { get; set; }
}
