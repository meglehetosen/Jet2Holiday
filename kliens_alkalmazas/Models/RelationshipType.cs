using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class RelationshipType
{
    public int RelationshipTypeId { get; set; }

    public int Direction { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public virtual ICollection<Relationship> Relationships { get; set; } = new List<Relationship>();
}
