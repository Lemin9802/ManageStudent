using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNP;

namespace StudentNP
{
    public class Student : Person
    {
        public string Grade { get; set; } // Thuộc tính: Lớp
        public string Phone { get; set; } // Thuộc tính: Số điện thoại

        public Student(string id, string name, string grade, string phone)
            : base(id, name)
        {
            Grade = grade;
            Phone = phone;
        }
    }
}
