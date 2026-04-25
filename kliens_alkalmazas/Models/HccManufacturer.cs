using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccManufacturer
{
    public Guid Bvin { get; set; }

    public string DisplayName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string DropShipEmailTemplateId { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public virtual ICollection<HccProduct> HccProducts { get; set; } = new List<HccProduct>();
}
