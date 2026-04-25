using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class TaxonomyTerm
{
    public int TermId { get; set; }

    public int VocabularyId { get; set; }

    public int? ParentTermId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Weight { get; set; }

    public int TermLeft { get; set; }

    public int TermRight { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual ICollection<ContentItemsTag> ContentItemsTags { get; set; } = new List<ContentItemsTag>();

    public virtual ICollection<TaxonomyTerm> InverseParentTerm { get; set; } = new List<TaxonomyTerm>();

    public virtual TaxonomyTerm? ParentTerm { get; set; }

    public virtual TaxonomyVocabulary Vocabulary { get; set; } = null!;
}
