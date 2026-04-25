using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PersonaBarMenu
{
    public int MenuId { get; set; }

    public string Identifier { get; set; } = null!;

    public string ModuleName { get; set; } = null!;

    public string? FolderName { get; set; }

    public string? Controller { get; set; }

    public string ResourceKey { get; set; } = null!;

    public string Path { get; set; } = null!;

    public string? Link { get; set; }

    public string? CssClass { get; set; }

    public int? ParentId { get; set; }

    public int Order { get; set; }

    public bool AllowHost { get; set; }

    public bool Enabled { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? IconFile { get; set; }

    public virtual ICollection<PersonaBarMenu> InverseParent { get; set; } = new List<PersonaBarMenu>();

    public virtual PersonaBarMenu? Parent { get; set; }

    public virtual ICollection<PersonaBarExtension> PersonaBarExtensions { get; set; } = new List<PersonaBarExtension>();

    public virtual PersonaBarMenuDefaultPermission? PersonaBarMenuDefaultPermission { get; set; }

    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermissions { get; set; } = new List<PersonaBarMenuPermission>();

    public virtual ICollection<PersonaBarPermission> PersonaBarPermissions { get; set; } = new List<PersonaBarPermission>();
}
