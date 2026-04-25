using System;
using System.Collections.Generic;

namespace kliens_alkalmazas.Models;

public partial class PasswordHistory
{
    public int PasswordHistoryId { get; set; }

    public int UserId { get; set; }

    public string Password { get; set; } = null!;

    public string PasswordSalt { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual User User { get; set; } = null!;
}
