using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccUserQuestion
{
    public string Bvin { get; set; } = null!;

    public string QuestionName { get; set; } = null!;

    public int QuestionType { get; set; }

    public string Values { get; set; } = null!;

    public int Order { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }
}
