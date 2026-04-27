using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11.Entities
{
    public  class Participant
    {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate {  get; set; }


        public Participant(string lastName, string firstName, DateTime birthDate)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
        }

        public Participant(long id, string lastName, string firstName, DateTime birthDate)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
        }

        public Participant()
        {
        }

    }

}
