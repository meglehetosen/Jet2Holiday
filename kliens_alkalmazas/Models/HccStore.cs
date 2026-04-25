using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccStore
{
    public long Id { get; set; }

    public Guid StoreGuid { get; set; }

    public string StoreName { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string CustomUrl { get; set; } = null!;

    public int LastOrderNumber { get; set; }

    public virtual ICollection<HccOrderTransaction> HccOrderTransactions { get; set; } = new List<HccOrderTransaction>();

    public virtual ICollection<HccShippingZone> HccShippingZones { get; set; } = new List<HccShippingZone>();

    public virtual ICollection<HccStoreSetting> HccStoreSettings { get; set; } = new List<HccStoreSetting>();

    public virtual ICollection<HccStoresXuser> HccStoresXusers { get; set; } = new List<HccStoresXuser>();

    public virtual ICollection<HccTaxSchedule> HccTaxSchedules { get; set; } = new List<HccTaxSchedule>();

    public virtual ICollection<HccTaxis> HccTaxes { get; set; } = new List<HccTaxis>();
}
