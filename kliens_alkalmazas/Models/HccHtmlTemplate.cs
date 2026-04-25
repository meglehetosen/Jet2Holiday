using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccHtmlTemplate
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public DateTime LastUpdatedUtc { get; set; }

    public string DisplayName { get; set; } = null!;

    public string FromEmail { get; set; } = null!;

    public int TemplateType { get; set; }

    public virtual ICollection<HccHtmlTemplateTranslation> HccHtmlTemplateTranslations { get; set; } = new List<HccHtmlTemplateTranslation>();
}
