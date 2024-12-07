﻿using Attendance_Student.DTOs.StudentDTO;

namespace Attendance_Student.DTOs.ClassDTO
{
    public class SelectClassDTO
    {
        public int Class_Id { get; set; }

        public string Class_Name { get; set; }
        public int Class_Size { get; set; } // max no of student

        public List<SelectStudentDTO> students { get; set; }
        //public TimeTable timeTable { get; set; }


    }
}
