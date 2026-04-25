using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccOrderCoupon
{
    public long Id { get; set; }

    public DateTime LastUpdatedUtc { get; set; }

    public string CouponCode { get; set; } = null!;

    public Guid OrderBvin { get; set; }

    public long StoreId { get; set; }

    public string UserId { get; set; } = null!;

    public bool IsUsed { get; set; }

    public virtual HccOrder OrderBvinNavigation { get; set; } = null!;
}
