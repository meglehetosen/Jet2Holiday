using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccCategoryXproperty
{
    public long Id { get; set; }

    public string CategoryId { get; set; } = null!;

    public long PropertyId { get; set; }

    public long ParentPropertyId { get; set; }

    public int SortOrder { get; set; }

    public string FilterName { get; set; } = null!;

    public int DisplayMode { get; set; }

    public long StoreId { get; set; }
}
