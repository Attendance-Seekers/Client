using Attendance_Student.DTOs.StudentDTO;
using Attendance_Student.DTOs.TimeTableDTO;

namespace Attendance_Student.DTOs.ClassDTO
{
    public class SelectClassDTO
    {
        public int Class_Id { get; set; }

        public string Class_Name { get; set; }
        public int Class_Size { get; set; } // max no of student

        public List<SelectStudentDTO> students { get; set; }
        public SelectTimeTableDTO timeTable { get; set; }


    }
}
