using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Package
{
    public int PackageId { get; set; }

    public int? PortalId { get; set; }

    public string Name { get; set; } = null!;

    public string FriendlyName { get; set; } = null!;

    public string? Description { get; set; }

    public string PackageType { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string? License { get; set; }

    public string? Manifest { get; set; }

    public string? Owner { get; set; }

    public string? Organization { get; set; }

    public string? Url { get; set; }

    public string? Email { get; set; }

    public string? ReleaseNotes { get; set; }

    public bool IsSystemPackage { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public string? FolderName { get; set; }

    public string? IconFile { get; set; }

    public virtual ICollection<Assembly> Assemblies { get; set; } = new List<Assembly>();

    public virtual ICollection<Authentication> Authentications { get; set; } = new List<Authentication>();

    public virtual ICollection<DesktopModule> DesktopModules { get; set; } = new List<DesktopModule>();

    public virtual ICollection<JavaScriptLibrary> JavaScriptLibraries { get; set; } = new List<JavaScriptLibrary>();

    public virtual ICollection<LanguagePack> LanguagePacks { get; set; } = new List<LanguagePack>();

    public virtual ICollection<PackageDependency> PackageDependencies { get; set; } = new List<PackageDependency>();

    public virtual PackageType PackageTypeNavigation { get; set; } = null!;

    public virtual ICollection<SkinControl> SkinControls { get; set; } = new List<SkinControl>();

    public virtual ICollection<SkinPackage> SkinPackages { get; set; } = new List<SkinPackage>();
}
