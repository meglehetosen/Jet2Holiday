namespace kliens_alkalmazas_api.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public bool IsSuperUser { get; set; }
    public int? AffiliateId { get; set; }
    public string? Email { get; set; }
    public string DisplayName { get; set; } = string.Empty;
    public bool UpdatePassword { get; set; }
    public string? LastIpaddress { get; set; }
    public bool IsDeleted { get; set; }
    public int? CreatedByUserId { get; set; }
    public DateTime? CreatedOnDate { get; set; }
    public int? LastModifiedByUserId { get; set; }
    public DateTime? LastModifiedOnDate { get; set; }
    public Guid? PasswordResetToken { get; set; }
    public DateTime? PasswordResetExpiration { get; set; }
}
