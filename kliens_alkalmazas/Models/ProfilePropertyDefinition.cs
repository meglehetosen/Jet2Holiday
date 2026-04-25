using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ProfilePropertyDefinition
{
    public int PropertyDefinitionId { get; set; }

    public int? PortalId { get; set; }

    public int? ModuleDefId { get; set; }

    public bool Deleted { get; set; }

    public int DataType { get; set; }

    public string? DefaultValue { get; set; }

    public string PropertyCategory { get; set; } = null!;

    public string PropertyName { get; set; } = null!;

    public int Length { get; set; }

    public bool Required { get; set; }

    public string? ValidationExpression { get; set; }

    public int ViewOrder { get; set; }

    public bool Visible { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public int? DefaultVisibility { get; set; }

    public bool ReadOnly { get; set; }

    public virtual Portal? Portal { get; set; }

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
