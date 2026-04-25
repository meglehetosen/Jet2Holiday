using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ContentItemsMetaDatum
{
    public int ContentItemMetaDataId { get; set; }

    public int ContentItemId { get; set; }

    public int MetaDataId { get; set; }

    public string? MetaDataValue { get; set; }

    public virtual ContentItem ContentItem { get; set; } = null!;

    public virtual MetaData MetaData { get; set; } = null!;
}
