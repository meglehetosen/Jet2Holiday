using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccRma
{
    public Guid Bvin { get; set; }

    public Guid OrderBvin { get; set; }

    public string Name { get; set; } = null!;

    public int Number { get; set; }

    public string EmailAddress { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public int Status { get; set; }

    public DateTime DateOfReturn { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public virtual ICollection<HccRmaitem> HccRmaitems { get; set; } = new List<HccRmaitem>();

    public virtual HccOrder OrderBvinNavigation { get; set; } = null!;
}
