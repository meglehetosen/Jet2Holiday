using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccMailingList
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public bool Private { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastUpdatedUtc { get; set; }

    public virtual ICollection<HccMailingListMember> HccMailingListMembers { get; set; } = new List<HccMailingListMember>();
}
