using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccSearchObject
{
    public long Id { get; set; }

    public int ObjectType { get; set; }

    public Guid ObjectId { get; set; }

    public string Title { get; set; } = null!;

    public long SiteId { get; set; }

    public DateTime LastIndexUtc { get; set; }

    public virtual ICollection<HccSearchObjectWord> HccSearchObjectWords { get; set; } = new List<HccSearchObjectWord>();
}
