using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProductType
{
    public Guid Bvin { get; set; }

    public bool IsPermanent { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public string TemplateName { get; set; } = null!;

    public virtual ICollection<HccCatalogRole> HccCatalogRoles { get; set; } = new List<HccCatalogRole>();

    public virtual HccMembershipProductType? HccMembershipProductType { get; set; }

    public virtual ICollection<HccProductTypeTranslation> HccProductTypeTranslations { get; set; } = new List<HccProductTypeTranslation>();

    public virtual ICollection<HccProductTypeXproductProperty> HccProductTypeXproductProperties { get; set; } = new List<HccProductTypeXproductProperty>();

    public virtual ICollection<HccProduct> HccProducts { get; set; } = new List<HccProduct>();
}
