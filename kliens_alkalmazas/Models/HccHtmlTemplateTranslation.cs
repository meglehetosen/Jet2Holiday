using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HccHtmlTemplateTranslation
{
    public long HtmlTemplateTranslationId { get; set; }

    public long HtmlTemplateId { get; set; }

    public string Culture { get; set; } = null!;

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string? RepeatingSection { get; set; }

    public virtual HccHtmlTemplate HtmlTemplate { get; set; } = null!;
}
