using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccOrderPackage
{
    public long Id { get; set; }

    public string Description { get; set; } = null!;

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public decimal Length { get; set; }

    public int SizeUnits { get; set; }

    public decimal Weight { get; set; }

    public int WeightUnits { get; set; }

    public Guid OrderId { get; set; }

    public string ShippingProviderId { get; set; } = null!;

    public string ShippingProviderServiceCode { get; set; } = null!;

    public int HasShipped { get; set; }

    public string TrackingNumber { get; set; } = null!;

    public DateTime ShipDateUtc { get; set; }

    public decimal EstimatedShippingCost { get; set; }

    public string Items { get; set; } = null!;

    public DateTime LastUpdatedUtc { get; set; }

    public string CustomProperties { get; set; } = null!;

    public long StoreId { get; set; }

    public string? ShippingMethodId { get; set; }

    public virtual HccOrder Order { get; set; } = null!;
}
