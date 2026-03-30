using Seminar7._2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar7._2.ViewModel
{
    internal class ViewModel1
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

        public BindingList<Participant> Participants { get; set; }

        public ViewModel1() 
        { 
            Participants = new BindingList<Participant>();
        }
        
        public void AddParticipant()
        {
            Participants.Add(new Participant(LastName, FirstName, BirthDate));
        }
    }
}
