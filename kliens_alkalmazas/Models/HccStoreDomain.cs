using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccStoreDomain
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string DomainName { get; set; } = null!;
}
