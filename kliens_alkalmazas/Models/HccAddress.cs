using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccAddress
{
    public int Id { get; set; }

    public string Bvin { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public string NickName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleInitial { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Line1 { get; set; } = null!;

    public string Line2 { get; set; } = null!;

    public string Line3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string RegionBvin { get; set; } = null!;

    public string RegionName { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string CountryBvin { get; set; } = null!;

    public string CountryName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string WebSiteUrl { get; set; } = null!;

    public string UserBvin { get; set; } = null!;

    public long StoreId { get; set; }

    public int AddressType { get; set; }
}
