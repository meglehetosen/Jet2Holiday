using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ExportImportCheckpoint
{
    public int CheckpointId { get; set; }

    public int JobId { get; set; }

    public string AssemblyName { get; set; } = null!;

    public string Category { get; set; } = null!;

    public int Stage { get; set; }

    public string? StageData { get; set; }

    public int Progress { get; set; }

    public int TotalItems { get; set; }

    public int ProcessedItems { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public bool? Completed { get; set; }

    public virtual ExportImportJob Job { get; set; } = null!;
}
