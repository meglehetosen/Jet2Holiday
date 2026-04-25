using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class SynonymsGroup
{
    public int SynonymsGroupId { get; set; }

    public string SynonymsTags { get; set; } = null!;

    public int PortalId { get; set; }

    public string CultureCode { get; set; } = null!;

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }
}
