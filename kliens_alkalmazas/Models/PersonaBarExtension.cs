using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PersonaBarExtension
{
    public int ExtensionId { get; set; }

    public string Identifier { get; set; } = null!;

    public int MenuId { get; set; }

    public string? FolderName { get; set; }

    public string? Controller { get; set; }

    public string Container { get; set; } = null!;

    public string Path { get; set; } = null!;

    public int Order { get; set; }

    public bool Enabled { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual PersonaBarMenu Menu { get; set; } = null!;
}
