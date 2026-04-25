using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccNews
{
    public long Id { get; set; }

    public DateTime TimeStampUtc { get; set; }

    public string Message { get; set; } = null!;
}
