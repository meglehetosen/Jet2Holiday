using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Profile
{
    public int ProfileId { get; set; }

    public int UserId { get; set; }

    public int PortalId { get; set; }

    public string ProfileData { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public virtual Portal Portal { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
