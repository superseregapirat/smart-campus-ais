namespace SmartCampus.Core.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string StudentCardNumber { get; set; } = string.Empty;
    public string Role { get; set; } = "Student";
    public int AccessLevel { get; set; } = 1;
    public bool IsActive { get; set; } = true;
}

