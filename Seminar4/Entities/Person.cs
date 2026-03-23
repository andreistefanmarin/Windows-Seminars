using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Entities
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Person(string firstName, string lastName, DateTime birthDate) 
        { 
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
