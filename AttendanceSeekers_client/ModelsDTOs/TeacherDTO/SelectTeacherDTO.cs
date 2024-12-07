namespace Attendance_Student.DTOs.TeacherDTO
{
    public class SelectTeacherDTO:EditTeacherDTO
    {
        
        public int DeptId { get; set; }
        //public string department_name { get; set; }
        public string username { get; set; }

    }
}
