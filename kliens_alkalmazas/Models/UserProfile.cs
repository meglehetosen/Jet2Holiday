using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class UserProfile
{
    public int ProfileId { get; set; }

    public int UserId { get; set; }

    public int PropertyDefinitionId { get; set; }

    public string? PropertyValue { get; set; }

    public string? PropertyText { get; set; }

    public int Visibility { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public string? ExtendedVisibility { get; set; }

    public virtual ProfilePropertyDefinition PropertyDefinition { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
