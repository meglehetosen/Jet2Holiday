using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccUsgeoDatum
{
    public string Zip { get; set; } = null!;

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string County { get; set; } = null!;

    public string ZipType { get; set; } = null!;
}
