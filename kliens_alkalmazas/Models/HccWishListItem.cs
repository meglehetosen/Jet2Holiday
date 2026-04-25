using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccWishListItem
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string CustomerId { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public string SelectionData { get; set; } = null!;

    public virtual HccProduct Product { get; set; } = null!;
}
