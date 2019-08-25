using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public int StylistId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender {get; set;}
        public string LastVist{get; set;}
        public string Phone { get; set; }

        public virtual Stylist Stylist { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public Client()
        {
            this.Appointments = new HashSet<Appointment>();
        }
    }
}