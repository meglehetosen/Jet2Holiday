using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccAuthToken
{
    public long Id { get; set; }

    public Guid TokenId { get; set; }

    public long UserId { get; set; }

    public DateTime Expires { get; set; }

    public virtual HccUserAccount User { get; set; } = null!;
}
