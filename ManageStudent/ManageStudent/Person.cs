using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNP
{
    public class Person
    {
        public string Id { get; set; } // Thuộc tính: Mã số
        public string Name { get; set; } // Thuộc tính: Tên

        public Person(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

