using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNP;

namespace PersonIteratorNP
{
    public interface IIterator
    {
        bool HasNext();
        Person Next();
    }

    public class PersonIterator : IIterator
    {
        private List<Person> people;
        private int position;

        public PersonIterator(List<Person> people)
        {
            this.people = people;
            position = 0;
        }

        public bool HasNext()
        {
            return position < people.Count;
        }

        public Person Next()
        {
            Person person = people[position];
            position++;
            return person;
        }
    }
}


