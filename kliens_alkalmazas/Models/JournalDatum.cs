using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class JournalDatum
{
    public int JournalDataId { get; set; }

    public int JournalId { get; set; }

    public string JournalXml { get; set; } = null!;

    public virtual Journal Journal { get; set; } = null!;
}
