using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccProduct
{
    public long Id { get; set; }

    public Guid Bvin { get; set; }

    public string Sku { get; set; } = null!;

    public Guid? ProductTypeId { get; set; }

    public decimal ListPrice { get; set; }

    public decimal? SitePrice { get; set; }

    public decimal SiteCost { get; set; }

    public int TaxExempt { get; set; }

    public string TaxClass { get; set; } = null!;

    public int NonShipping { get; set; }

    public int ShipSeparately { get; set; }

    public int ShippingMode { get; set; }

    public decimal ShippingWeight { get; set; }

    public decimal ShippingLength { get; set; }

    public decimal ShippingWidth { get; set; }

    public decimal ShippingHeight { get; set; }

    public int Status { get; set; }

    public string ImageFileSmall { get; set; } = null!;

    public string ImageFileMedium { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public int MinimumQty { get; set; }

    public Guid? ManufacturerId { get; set; }

    public Guid? VendorId { get; set; }

    public int GiftWrapAllowed { get; set; }

    public decimal ExtraShipFee { get; set; }

    public DateTime LastUpdated { get; set; }

    public string TemplateName { get; set; } = null!;

    public string PreContentColumnId { get; set; } = null!;

    public string PostContentColumnId { get; set; } = null!;

    public string RewriteUrl { get; set; } = null!;

    public string CustomProperties { get; set; } = null!;

    public decimal GiftWrapPrice { get; set; }

    public long StoreId { get; set; }

    public bool Featured { get; set; }

    public bool? AllowReviews { get; set; }

    public int OutOfStockMode { get; set; }

    public bool IsAvailableForSale { get; set; }

    public bool IsUserPrice { get; set; }

    public bool HideQty { get; set; }

    public bool IsSearchable { get; set; }

    public bool IsBundle { get; set; }

    public bool IsGiftCard { get; set; }

    public bool IsRecurring { get; set; }

    public int? RecurringInterval { get; set; }

    public int? RecurringIntervalType { get; set; }

    public int ShippingCharge { get; set; }

    public bool AllowUpcharge { get; set; }

    public decimal UpchargeAmount { get; set; }

    public string? UpchargeUnit { get; set; }

    public virtual ICollection<Foglala> Foglalas { get; set; } = new List<Foglala>();

    public virtual ICollection<HccBundledProduct> HccBundledProducts { get; set; } = new List<HccBundledProduct>();

    public virtual ICollection<HccCatalogRole> HccCatalogRoles { get; set; } = new List<HccCatalogRole>();

    public virtual ICollection<HccProductFileXproduct> HccProductFileXproducts { get; set; } = new List<HccProductFileXproduct>();

    public virtual ICollection<HccProductImage> HccProductImages { get; set; } = new List<HccProductImage>();

    public virtual ICollection<HccProductInventory> HccProductInventories { get; set; } = new List<HccProductInventory>();

    public virtual ICollection<HccProductPropertyValue> HccProductPropertyValues { get; set; } = new List<HccProductPropertyValue>();

    public virtual ICollection<HccProductRelationship> HccProductRelationships { get; set; } = new List<HccProductRelationship>();

    public virtual ICollection<HccProductReview> HccProductReviews { get; set; } = new List<HccProductReview>();

    public virtual ICollection<HccProductTranslation> HccProductTranslations { get; set; } = new List<HccProductTranslation>();

    public virtual ICollection<HccProductVolumeDiscount> HccProductVolumeDiscounts { get; set; } = new List<HccProductVolumeDiscount>();

    public virtual ICollection<HccProductXcategory> HccProductXcategories { get; set; } = new List<HccProductXcategory>();

    public virtual ICollection<HccProductXoption> HccProductXoptions { get; set; } = new List<HccProductXoption>();

    public virtual ICollection<HccVariant> HccVariants { get; set; } = new List<HccVariant>();

    public virtual ICollection<HccWishListItem> HccWishListItems { get; set; } = new List<HccWishListItem>();

    public virtual HccManufacturer? Manufacturer { get; set; }

    public virtual HccProductType? ProductType { get; set; }

    public virtual HccVendor? Vendor { get; set; }
}
