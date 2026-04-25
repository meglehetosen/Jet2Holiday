using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccShippingMethodTranslation
{
    public long ShippingMethodTranslationId { get; set; }

    public Guid ShippingMethodId { get; set; }

    public string Culture { get; set; } = null!;

    public string? Name { get; set; }

    public virtual HccShippingMethod ShippingMethod { get; set; } = null!;
}
