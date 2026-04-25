using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class VwProfile
{
    public int UserId { get; set; }

    public int? PortalId { get; set; }

    public string PropertyName { get; set; } = null!;

    public string? PropertyValue { get; set; }

    public int Visibility { get; set; }

    public string? ExtendedVisibility { get; set; }

    public DateTime LastUpdatedDate { get; set; }

    public int PropertyDefinitionId { get; set; }
}
