using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public int StylistId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender {get; set;}
        public string LastVist{get; set;}

        public virtual Stylist Stylist { get; set; }
    }
}