using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Relationship
{
    public int RelationshipId { get; set; }

    public int RelationshipTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? PortalId { get; set; }

    public int? UserId { get; set; }

    public int DefaultResponse { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public virtual Portal? Portal { get; set; }

    public virtual RelationshipType RelationshipType { get; set; } = null!;

    public virtual User? User { get; set; }

    public virtual ICollection<UserRelationshipPreference> UserRelationshipPreferences { get; set; } = new List<UserRelationshipPreference>();

    public virtual ICollection<UserRelationship> UserRelationships { get; set; } = new List<UserRelationship>();
}
