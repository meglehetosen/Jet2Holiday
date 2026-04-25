using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class FolderMapping
{
    public int FolderMappingId { get; set; }

    public int? PortalId { get; set; }

    public string MappingName { get; set; } = null!;

    public string FolderProviderType { get; set; } = null!;

    public int? Priority { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual ICollection<FolderMappingsSetting> FolderMappingsSettings { get; set; } = new List<FolderMappingsSetting>();

    public virtual ICollection<Folder> Folders { get; set; } = new List<Folder>();

    public virtual Portal? Portal { get; set; }
}
