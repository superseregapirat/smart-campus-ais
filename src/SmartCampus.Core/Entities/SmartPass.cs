namespace SmartCampus.Core.Entities;

public class SmartPass
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string DynamicToken { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime ExpiresAt { get; set; } = DateTime.UtcNow.AddSeconds(60);
    public bool IsRevoked { get; set; } = false;
}
