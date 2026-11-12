namespace SmartCampus.Core.Entities;

public class Schedule
{
    public Guid Id { get; set; }
    public string GroupName { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public string Building { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}
