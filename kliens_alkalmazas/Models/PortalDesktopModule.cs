using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PortalDesktopModule
{
    public int PortalDesktopModuleId { get; set; }

    public int PortalId { get; set; }

    public int DesktopModuleId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual DesktopModule DesktopModule { get; set; } = null!;

    public virtual ICollection<DesktopModulePermission> DesktopModulePermissions { get; set; } = new List<DesktopModulePermission>();

    public virtual Portal Portal { get; set; } = null!;
}
