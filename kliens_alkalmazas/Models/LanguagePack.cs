using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class LanguagePack
{
    public int LanguagePackId { get; set; }

    public int PackageId { get; set; }

    public int DependentPackageId { get; set; }

    public int LanguageId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Package Package { get; set; } = null!;
}
