using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PortalGroup
{
    public int PortalGroupId { get; set; }

    public int? MasterPortalId { get; set; }

    public string? PortalGroupName { get; set; }

    public string? PortalGroupDescription { get; set; }

    public string? AuthenticationDomain { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }
}
