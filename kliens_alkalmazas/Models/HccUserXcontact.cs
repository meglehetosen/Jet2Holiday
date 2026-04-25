using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccUserXcontact
{
    public long Id { get; set; }

    public string ContactId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public long StoreId { get; set; }

    public virtual HccUser User { get; set; } = null!;
}
