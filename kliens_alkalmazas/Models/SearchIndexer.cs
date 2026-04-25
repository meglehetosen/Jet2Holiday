using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class SearchIndexer
{
    public int SearchIndexerId { get; set; }

    public string SearchIndexerAssemblyQualifiedName { get; set; } = null!;
}
