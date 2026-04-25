using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class UrlTracking
{
    public int UrlTrackingId { get; set; }

    public int? PortalId { get; set; }

    public string Url { get; set; } = null!;

    public string UrlType { get; set; } = null!;

    public int Clicks { get; set; }

    public DateTime? LastClick { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool LogActivity { get; set; }

    public bool TrackClicks { get; set; }

    public int? ModuleId { get; set; }

    public bool NewWindow { get; set; }

    public virtual Portal? Portal { get; set; }

    public virtual ICollection<UrlLog> UrlLogs { get; set; } = new List<UrlLog>();
}
