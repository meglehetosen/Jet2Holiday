using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ModuleDefinition
{
    public int ModuleDefId { get; set; }

    public string FriendlyName { get; set; } = null!;

    public int DesktopModuleId { get; set; }

    public int DefaultCacheTime { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string DefinitionName { get; set; } = null!;

    public virtual DesktopModule DesktopModule { get; set; } = null!;

    public virtual ICollection<ModuleControl> ModuleControls { get; set; } = new List<ModuleControl>();

    public virtual ICollection<Module> Modules { get; set; } = new List<Module>();
}
