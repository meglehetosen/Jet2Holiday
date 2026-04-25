using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class SearchDeletedItem
{
    public int SearchDeletedItemsId { get; set; }

    public DateTime DateCreated { get; set; }

    public string? Document { get; set; }
}
