using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class WebServer
{
    public int ServerId { get; set; }

    public string ServerName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime LastActivityDate { get; set; }

    public string? Url { get; set; }

    public string IisappName { get; set; } = null!;

    public bool Enabled { get; set; }

    public string? ServerGroup { get; set; }

    public string? UniqueId { get; set; }

    public int PingFailureCount { get; set; }
}
