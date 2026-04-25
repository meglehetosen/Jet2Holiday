using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccMailingListMember
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public long ListId { get; set; }

    public string EmailAddress { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime LastUpdatedUtc { get; set; }

    public virtual HccMailingList List { get; set; } = null!;
}
