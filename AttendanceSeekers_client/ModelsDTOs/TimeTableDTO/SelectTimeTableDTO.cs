using Attendance_Student.DTOs.ScheduleDTOs;

namespace Attendance_Student.DTOs.TimeTableDTO
{
    public class SelectTimeTableDTO
    {
        public int TimeTableId { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<DayScheduleDTO> daySchedules { get; set; }

    }
}
