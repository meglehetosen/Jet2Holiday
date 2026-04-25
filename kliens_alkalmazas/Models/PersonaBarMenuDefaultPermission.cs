using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PersonaBarMenuDefaultPermission
{
    public int Id { get; set; }

    public int MenuId { get; set; }

    public string RoleNames { get; set; } = null!;

    public virtual PersonaBarMenu Menu { get; set; } = null!;
}
