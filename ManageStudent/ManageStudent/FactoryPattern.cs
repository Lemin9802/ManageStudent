using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNP;
using StudentNP;
using TeacherNP;

namespace IPersonFactoryNP
{
    public interface IPersonFactory
    {
        Person CreatePerson();
    }

    public class StudentFactory : IPersonFactory
    {
        public Person CreatePerson()
        {
            Console.WriteLine("Them thong tin Sinh vien");

            // Nhập thông tin của Sinh viên từ người dùng
            Console.Write("Nhap MSSV: ");
            string studentId = Console.ReadLine();
            Console.Write("Nhap ten: ");
            string studentName = Console.ReadLine();
            Console.Write("Nhap lop: ");
            string studentClass = Console.ReadLine();
            Console.Write("Nhap SDT: ");
            string studentPhone = Console.ReadLine();

            // Tạo đối tượng Sinh viên với thông tin đã nhập
            Student student = new Student(studentId, studentName, studentClass, studentPhone);

            // Trả về đối tượng Sinh viên đã được tạo
            return student;
        }
    }

    public class TeacherFactory : IPersonFactory
    {
        public Person CreatePerson()
        {
            Console.WriteLine("Them thong tin giao vien");

            // Nhập thông tin của Giáo viên từ người dùng
            Console.Write("Nhap ID Giao vien: ");
            string teacherId = Console.ReadLine();
            Console.Write("Nhap ten Giao vien: ");
            string teacherName = Console.ReadLine();
            Console.Write("Nhap Mon hoc: ");
            string teachingSubject = Console.ReadLine();
            Console.Write("Nhap SDT: ");
            string teacherPhone = Console.ReadLine();

            // Tạo đối tượng Giáo viên với thông tin đã nhập
            Teacher teacher = new Teacher(teacherId, teacherName, teachingSubject, teacherPhone);

            // Trả về đối tượng Giáo viên đã được tạo
            return teacher;
        }
    }
}