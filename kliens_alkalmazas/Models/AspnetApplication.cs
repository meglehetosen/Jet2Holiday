using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class AspnetApplication
{
    public string ApplicationName { get; set; } = null!;

    public string LoweredApplicationName { get; set; } = null!;

    public Guid ApplicationId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<AspnetMembership> AspnetMemberships { get; set; } = new List<AspnetMembership>();

    public virtual ICollection<AspnetUser> AspnetUsers { get; set; } = new List<AspnetUser>();
}
