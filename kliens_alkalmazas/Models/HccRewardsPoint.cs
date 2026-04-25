using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccRewardsPoint
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public int Points { get; set; }

    public int PointsHeld { get; set; }

    public DateTime TransactionTime { get; set; }

    public long StoreId { get; set; }
}
