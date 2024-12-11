using System.Text.Json.Serialization;

namespace Attendance_Student.DTOs.StudentDTO
{
    public class SelectStudentDTO
    {
        [JsonIgnore]
        public string id { get; set; }
        public string username { get; set; }
        public string status { get; set; }
        public string class_name { get; set; }
        public int age { get; set; }
        public string parent_name { get; set; }


    }
}
