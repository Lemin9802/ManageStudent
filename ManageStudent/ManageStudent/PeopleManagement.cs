using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNP;
using PersonIteratorNP;
using IPersonFactoryNP;
using StudentNP;
using TeacherNP;

namespace PersonManageNP
{
    public class PeopleManagement
    {
        private List<Person> people;
        public PeopleManagement()
        {
            people = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            people.Add(person);
        }
        public void DeletePersonById(string id)
        {
            Person person = FindPersonById(id);
            if (person != null)
            {
                people.Remove(person);
                Console.WriteLine("Da xoa thong tin thanh cong");
            }
        }
        public void UpdatePerson(string id)
        {
            Person person = FindPersonById(id);
            if (person != null)
            {
                Console.WriteLine("Nhap thong tin can cap nhat:");
                Console.Write("Chon doi tuong: 1) Giao vien hoac 2) Sinh vien: ");
                int choice = int.Parse(Console.ReadLine());

                if (person is Student && choice == 2)
                {
                    Console.WriteLine("Thong tin sinh vien:");
                    Console.WriteLine("Ten sinh vien: {0}", person.Name);
                    Console.Write("Nhap lop: ");
                    string grade = Console.ReadLine();
                    Console.Write("Nhap SDT: ");
                    string phone = Console.ReadLine();
                    ((Student)person).Grade = grade;
                    ((Student)person).Phone = phone;
                    Console.WriteLine("\nThong tin sinh vien da duoc cap nhat!");
                }
                else if (person is Teacher && choice == 1)
                {
                    Console.WriteLine("Thong tin giao vien:");
                    Console.WriteLine("Ten giao vien: {0}", person.Name);
                    Console.Write("Nhap Mon day: ");
                    string teachingSubject = Console.ReadLine();

                    ((Teacher)person).TeachingSubject = teachingSubject;

                    Console.WriteLine("\nThong tin giao vien da duoc cap nhat!");
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le!");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay nguoi.");
            }
        }
        public IIterator CreateIterator()
        {
            return new PersonIterator(people);
        }
        private Person FindPersonById(string id)
        {
            foreach (Person person in people)
            {
                if (person.Id == id)
                {
                    // Tìm thấy người có ID trùng khớp
                    return person;
                }
            }
            // Không tìm thấy người có ID trùng khớp
            return null;
        }
    }
}
