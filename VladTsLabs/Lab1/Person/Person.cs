using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Person
    {
        private static int LastUsedID = 1000;
        private string firstName, lastName;
        private int id;

        public Person(string firstName = "", string lastName = "")
        {
            id = ++LastUsedID;
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName 
        {
            get { return FirstName + " " + LastName; }
        }

        public int ID
        {
            get { return id; }
        }
        
        // Method accessors
        public string GetLastName()
        {
            return lastName;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public int GetID()
        {
            return id;
        }

        // Print methods
        private void Print(string property, object value)
        {
            Console.WriteLine(property + ": " + value.ToString());
        }

        public void PrintFirstName()
        {
            Print("FirstName", FirstName);
        }

        public void PrintLastName()
        {
            Print("LastName", LastName);
        }

        public void PrintID()
        {
            Print("ID", ID);
        }

        public override string ToString()
        {
            return String.Format("<Person#{0} FirstName={1}, LastName={2}>", ID, FirstName, LastName);
        }
    }
}