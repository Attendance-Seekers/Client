using System.ComponentModel.DataAnnotations;

namespace Attendance_Student.DTOs.AdminDTOs
{
    public class AddAdminDTO
    {
        [Required]
        public string fullName { get; set; }

        public string address { get; set; }
        public int age { get; set; }


        [Required]
        public string username { get; set; }
        [Required]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$")]
        public string password { get; set; }
        [Required]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$")]
        public string email { get; set; }
        [Required]
        [RegularExpression("^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$")]

        public string phonenumber { get; set; }
    }
}
