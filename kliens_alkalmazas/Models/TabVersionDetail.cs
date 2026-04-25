using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class TabVersionDetail
{
    public int TabVersionDetailId { get; set; }

    public int TabVersionId { get; set; }

    public int ModuleId { get; set; }

    public int ModuleVersion { get; set; }

    public string PaneName { get; set; } = null!;

    public int ModuleOrder { get; set; }

    public int Action { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public virtual TabVersion TabVersion { get; set; } = null!;
}
