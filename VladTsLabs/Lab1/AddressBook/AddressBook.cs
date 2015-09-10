using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class AddressBook
    {
        private Collection<Person> List;

        public AddressBook()
        {
            List = new Collection<Person>();
        }

        public void Add(Person person)
        {
            foreach (Person p in List)
            {
                if (p.ID == person.ID)
                {
                    return;
                }
            }

            List.Add(person);
        }

        public void Delete(Person person)
        {
            List.Remove(person);
        }

        // Indexer
        public Person this[int i]
        {
            get { return List[i]; }
            set { List[i] = value; }
        }

        public Person[] Search(string query)
        {
            Collection<Person> results = new Collection<Person>();

            foreach (Person p in List)
            {
                if (p.FirstName == query || p.LastName == query)
                {
                    results.Add(p);
                }
            }

            return results.ToArray();
        }

        public Person[] Search(int query)
        {
            Collection<Person> results = new Collection<Person>();

            foreach (Person p in List)
            {
                if (p.ID == query)
                {
                    results.Add(p);
                }
            }

            return results.ToArray();
        }
    }
}
