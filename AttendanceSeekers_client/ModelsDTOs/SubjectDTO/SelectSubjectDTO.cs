﻿using Attendance_Student.DTOs.TeacherDTO;
using Attendance_Student.Models;
using System.ComponentModel.DataAnnotations;

namespace Attendance_Student.DTOs.SubjectDTO
{
    public class SelectSubjectDTO
    {
       
        public int subject_Id { get; set; }
        
        public string subject_Name { get; set; }

        public int subject_Duration { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public  List<CustomSelectTeacherDTO> teachers { get; set; }
        //public  List<SubjectDaySchedule> daysScheduled { get; set; } 
    }
}
