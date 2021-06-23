using System.ComponentModel.DataAnnotations;

namespace SmartRestaurant.Model
{
    public class JedinicaKolicine
    {
        [Key]
        public int JedinicaKolicineID { get; set; }

        public string NazivJedinice { get; set; }
    }
}
