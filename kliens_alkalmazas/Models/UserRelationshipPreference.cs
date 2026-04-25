using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class UserRelationshipPreference
{
    public int PreferenceId { get; set; }

    public int UserId { get; set; }

    public int RelationshipId { get; set; }

    public int DefaultResponse { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public virtual Relationship Relationship { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
