using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class HtmlTextUser
{
    public int HtmlTextUserId { get; set; }

    public int ItemId { get; set; }

    public int StateId { get; set; }

    public int ModuleId { get; set; }

    public int TabId { get; set; }

    public int UserId { get; set; }

    public DateTime CreatedOnDate { get; set; }

    public virtual HtmlText Item { get; set; } = null!;
}
