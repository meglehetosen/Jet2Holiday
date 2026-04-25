using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccSearchObjectWord
{
    public long SearchObjectId { get; set; }

    public long WordId { get; set; }

    public int Score { get; set; }

    public long SiteId { get; set; }

    public virtual HccSearchObject SearchObject { get; set; } = null!;

    public virtual HccSearchLexicon Word { get; set; } = null!;
}
