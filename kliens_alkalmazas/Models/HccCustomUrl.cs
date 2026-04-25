using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccCustomUrl
{
    public string Bvin { get; set; } = null!;

    public string RequestedUrl { get; set; } = null!;

    public string RedirectToUrl { get; set; } = null!;

    public bool IsPermanentRedirect { get; set; }

    public int SystemDataType { get; set; }

    public string SystemData { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }
}
