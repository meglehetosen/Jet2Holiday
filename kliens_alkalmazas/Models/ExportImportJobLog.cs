using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ExportImportJobLog
{
    public int JobLogId { get; set; }

    public int JobId { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public int Level { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public virtual ExportImportJob Job { get; set; } = null!;
}
