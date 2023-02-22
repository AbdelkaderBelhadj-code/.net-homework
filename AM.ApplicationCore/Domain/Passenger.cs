using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDay { get; set; }
        public String PassportNumber { get; set; }
        public string EmailAddress { get; set;}
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public virtual ICollection<Flight> flights { get; set; }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }


        public override string ToString()
        {
            return "BirthDay"+BirthDay+"PassportNumber"+PassportNumber+"EmailAddress"+EmailAddress+"FirstName"+FirstName+"LastName"+LastName+"TelNumber"+TelNumber;
        }

        public bool CheckProfile(String nom , String prenom)
        {
            if ((this.FirstName == prenom) && (this.LastName == nom)) { return true; } else { return false; }
        }

        public bool CheckProfile(String nom, String prenom, String email)
        { 
            return this.LastName == nom && this.FirstName== prenom && this.EmailAddress == email;
        }
    }
}
