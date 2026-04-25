using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccUser
{
    public string Bvin { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public int TaxExempt { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime LastLoginDate { get; set; }

    public string Comment { get; set; } = null!;

    public string AddressBook { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public int Locked { get; set; }

    public DateTime LockedUntil { get; set; }

    public int FailedLoginCount { get; set; }

    public string Phones { get; set; } = null!;

    public string PricingGroup { get; set; } = null!;

    public string CustomQuestionAnswers { get; set; } = null!;

    public long StoreId { get; set; }

    public string ShippingAddress { get; set; } = null!;

    public string BillingAddress { get; set; } = null!;

    public virtual ICollection<HccUserXcontact> HccUserXcontacts { get; set; } = new List<HccUserXcontact>();
}
