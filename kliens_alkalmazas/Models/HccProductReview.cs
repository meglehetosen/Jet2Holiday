using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductReview
{
    public int Id { get; set; }

    public DateTime LastUpdated { get; set; }

    public Guid Bvin { get; set; }

    public int Approved { get; set; }

    public string Description { get; set; } = null!;

    public int Karma { get; set; }

    public DateTime ReviewDate { get; set; }

    public int Rating { get; set; }

    public string UserId { get; set; } = null!;

    public long StoreId { get; set; }

    public Guid ProductId { get; set; }

    public virtual HccProduct Product { get; set; } = null!;
}
