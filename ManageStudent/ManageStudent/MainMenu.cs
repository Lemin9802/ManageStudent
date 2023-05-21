using PersonNP;
using PersonManageNP;
using IPersonFactoryNP;
using PersonIteratorNP;
using StudentNP;
using TeacherNP;
class MainMenu
{
    static void Main(string[] args)
    {
        PeopleManagement manager = new PeopleManagement();
        while (true)
        {
            Console.WriteLine("\n ======== PHAN MEM QUAN LY HOC SINH ========");
            Console.WriteLine("1. Hien thi danh sach Sinh vien/Giao vien");
            Console.WriteLine("2. Them thong tin");
            Console.WriteLine("3. Chinh sua thong tin");
            Console.WriteLine("4. Xoa thong tin");
            Console.WriteLine("5. Thoat khoi ung dung!");
            Console.Write("\n Nhap lua chon cua ban: ");
            int option = 0;
            try
            {
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        IIterator iterator = manager.CreateIterator();
                        if (iterator.HasNext())
                        {
                            Console.WriteLine("\nDANH SACH SINH VIEN: ");
                            Console.WriteLine("{0,-10} {1,-20} {2,-30} {3,-30} {4,-20}", "    ", "MSSV", "Ten", "Lop / Mon hoc ", "SDT");
                            Console.WriteLine("Hoan thanh yeu cau!");
                            while (iterator.HasNext())
                            {
                                Person person = iterator.Next();
                                if (person is Teacher)
                                {
                                    Teacher teacher = (Teacher)person;
                                    Console.WriteLine("Giao vien: {0,-20} {1,-30} {2,-30} {3,-20}",
                                        teacher.Id, teacher.Name, teacher.TeachingSubject, teacher.TeacherPhone);
                                }
                                else if (person is Student)
                                {
                                    Student student = (Student)person;
                                    Console.WriteLine("Sinh vien: {0,-20} {1,-30} {2,-30} {3,-20}",
                                        student.Id, student.Name, student.Grade, student.Phone);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach trong!");
                        }

                        break;
                    case 2:
                        {
                            Console.WriteLine("Vui long nhap thong tin:");
                            Console.Write("Chon doi tuong: 1) Giao vien hoac 2) Sinh vien ");
                            int choice = int.Parse(Console.ReadLine());
                            if (choice == 2)
                            {
                                IPersonFactory studentFactory = new StudentFactory();
                                Person student = studentFactory.CreatePerson();
                                manager.AddPerson(student);
                                Console.WriteLine("\nThong tin sinh vien da duoc them vao!");
                            }
                            else
                            {
                                IPersonFactory teacherFactory = new TeacherFactory();
                                Person teacher = teacherFactory.CreatePerson();
                                manager.AddPerson(teacher);
                                Console.WriteLine("\nThong tin giao vien da duoc them vao!");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nVui long nhap thong tin can chinh sua");
                        Console.Write("Nhap ID/MSSV: ");
                        string idUpdate = Console.ReadLine();
                        manager.UpdatePerson(idUpdate);
                        break;
                    case 4:
                        Console.Write("Nhap ID/MSSV can xoa: ");
                        string idDelete = Console.ReadLine();
                        manager.DeletePersonById(idDelete);
                        break;
                    case 5:
                        Console.WriteLine("Bye bye! ");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n LOI!!! VUI LONG NHAP LAI");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\n KHONG CO YEU CAU NAY, VUI LONG NHAP LAI: ");
            }
        }
    }
}
