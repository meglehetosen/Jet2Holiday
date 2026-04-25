using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class ExportImportJob
{
    public int JobId { get; set; }

    public int PortalId { get; set; }

    public int JobType { get; set; }

    public int JobStatus { get; set; }

    public bool IsCancelled { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public DateTime LastModifiedOnDate { get; set; }

    public DateTime? CompletedOnDate { get; set; }

    public string? Directory { get; set; }

    public string? JobObject { get; set; }

    public virtual ICollection<ExportImportCheckpoint> ExportImportCheckpoints { get; set; } = new List<ExportImportCheckpoint>();

    public virtual ICollection<ExportImportJobLog> ExportImportJobLogs { get; set; } = new List<ExportImportJobLog>();
}
