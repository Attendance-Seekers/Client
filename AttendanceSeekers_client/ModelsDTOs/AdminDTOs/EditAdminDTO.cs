using System.ComponentModel.DataAnnotations;

namespace Attendance_Student.DTOs.AdminDTOs
{
    public class EditAdminDTO
    {
        [Required]
        public string Id { get; set; }
        public string fullName { get; set; }

        public string address { get; set; }
        public int age { get; set; }


        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$")]
        public string email { get; set; }
        [RegularExpression("^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$")]

        public string phonenumber { get; set; }
    }
}
