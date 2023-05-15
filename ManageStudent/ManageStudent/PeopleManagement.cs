using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNP;
using PersonIteratorNP;

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
            }
        }

        public void UpdatePerson(string id)
        {
            Person person = FindPersonById(id);
            if (person != null)
            {
                // Cập nhật thông tin của person
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
