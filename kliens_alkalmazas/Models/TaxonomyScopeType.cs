using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class TaxonomyScopeType
{
    public int ScopeTypeId { get; set; }

    public string? ScopeType { get; set; }

    public virtual ICollection<TaxonomyVocabulary> TaxonomyVocabularies { get; set; } = new List<TaxonomyVocabulary>();
}
