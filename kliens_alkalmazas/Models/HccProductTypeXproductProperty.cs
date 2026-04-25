using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductTypeXproductProperty
{
    public Guid ProductTypeBvin { get; set; }

    public long PropertyId { get; set; }

    public int SortOrder { get; set; }

    public long StoreId { get; set; }

    public long Id { get; set; }

    public virtual HccProductType ProductTypeBvinNavigation { get; set; } = null!;

    public virtual HccProductProperty Property { get; set; } = null!;
}
