using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccCatalogRole
{
    public long CatalogRoleId { get; set; }

    public string? RoleName { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? CategoryId { get; set; }

    public Guid? ProductTypeId { get; set; }

    public long StoreId { get; set; }

    public virtual HccCategory? Category { get; set; }

    public virtual HccProduct? Product { get; set; }

    public virtual HccProductType? ProductType { get; set; }
}
