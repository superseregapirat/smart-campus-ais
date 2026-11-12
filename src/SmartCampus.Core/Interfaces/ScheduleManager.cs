using SmartCampus.Core.Entities;

namespace SmartCampus.Core.Services;

public class ScheduleManager
{
    public event Action<Schedule>? ScheduleChangedEvent;

    public void UpdateRoom(Schedule lesson, string newBuilding, string newRoom)
    {
        lesson.Building = newBuilding;
        lesson.RoomNumber = newRoom;
        ScheduleChangedEvent?.Invoke(lesson);
    }
}
