using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class AddressBookTester
    {
        private AddressBook Book;
        private Person Me, Professor;

        public AddressBookTester() 
        {
            Book = new AddressBook();
            Me = new Person("Vlad", "Tsvang");
            Professor = new Person("Paramsothy", "Thananjeyan");
        }

        public void RunTests()
        {
            Console.WriteLine("Testing AddressBook");

            Book.Add(Me);

            Console.WriteLine("The first person in the address book is {0}", Book[0]);
            Console.WriteLine("Yay! The indexer works!");


            try
            {
                Book.Add(Me);
                Console.WriteLine("Is it me? {0}", Book[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("You cannot add me twice, though...");
            }

            Console.WriteLine("Add the professor");
            Book.Add(Professor);

            Console.WriteLine("Now find me by name: {0}", Book.Search("Vlad")[0]);

            Console.WriteLine("Delete me");
            Book.Delete(Me);

            try
            {
                Console.WriteLine("Woohoo! {0}", Book[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("The indexes just shifted: {0}", Book[0]);
            }

            Console.WriteLine("Find the professor by his id: {0}", Book.Search(Professor.ID)[0]);

            Console.WriteLine("Done testing the AddressBook class!");
        }
    }
}

/*

Testing AddressBook
The first person in the address book is <Person#1003 FirstName=Vlad, LastName=Tsvang>
Yay! The indexer works!
You cannot add me twice, though...
Add the professor
Now find me by name: <Person#1003 FirstName=Vlad, LastName=Tsvang>
Delete me
The indexes just shifted: <Person#1004 FirstName=Paramsothy, LastName=Thananjeyan>
Find the professor by his id: <Person#1004 FirstName=Paramsothy, LastName=Thananjeyan>
Done testing the AddressBook class!

*/