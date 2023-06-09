using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNP;

namespace TeacherNP
{
    public class Teacher : Person
    {
        public string TeachingSubject { get; set; } // Thuộc tính: Môn dạy
        public string TeacherPhone { get; set; } // Thuộc tính: Số điện thoại
        public Teacher(string id, string name, string teachingSubject, string? teacherPhone) : base(id, name)
        {
            TeachingSubject = teachingSubject;
            TeacherPhone= teacherPhone;
        }
    }
}
