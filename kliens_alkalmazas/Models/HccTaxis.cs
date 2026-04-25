using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccTaxis
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string CountryName { get; set; } = null!;

    public string RegionName { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public long TaxScheduleId { get; set; }

    public decimal Rate { get; set; }

    public bool ApplyToShipping { get; set; }

    public decimal ShippingRate { get; set; }

    public virtual HccStore Store { get; set; } = null!;

    public virtual HccTaxSchedule TaxSchedule { get; set; } = null!;
}
