using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductXoption
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public Guid ProductBvin { get; set; }

    public Guid OptionBvin { get; set; }

    public int SortOrder { get; set; }

    public virtual HccProductOption OptionBvinNavigation { get; set; } = null!;

    public virtual HccProduct ProductBvinNavigation { get; set; } = null!;
}
