using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccTaxSchedule
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string Name { get; set; } = null!;

    public decimal DefaultRate { get; set; }

    public decimal DefaultShippingRate { get; set; }

    public virtual ICollection<HccTaxis> HccTaxes { get; set; } = new List<HccTaxis>();

    public virtual HccStore Store { get; set; } = null!;
}
