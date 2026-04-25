using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class Module
{
    public int ModuleId { get; set; }

    public int ModuleDefId { get; set; }

    public bool AllTabs { get; set; }

    public bool IsDeleted { get; set; }

    public bool? InheritViewPermissions { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? PortalId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? LastContentModifiedOnDate { get; set; }

    public int? ContentItemId { get; set; }

    public bool IsShareable { get; set; }

    public bool IsShareableViewOnly { get; set; }

    public virtual ContentItem? ContentItem { get; set; }

    public virtual ICollection<CoreMessagingSubscription> CoreMessagingSubscriptions { get; set; } = new List<CoreMessagingSubscription>();

    public virtual ICollection<HtmlText> HtmlTexts { get; set; } = new List<HtmlText>();

    public virtual ModuleDefinition ModuleDef { get; set; } = null!;

    public virtual ICollection<ModulePermission> ModulePermissions { get; set; } = new List<ModulePermission>();

    public virtual ICollection<ModuleSetting> ModuleSettings { get; set; } = new List<ModuleSetting>();

    public virtual ICollection<TabModule> TabModules { get; set; } = new List<TabModule>();
}
