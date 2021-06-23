using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Model.ViewModels
{
    public class InsertNovogKorisnikaVM
    {
        public string NazivKorisnika { get; set; }

        public Uloge Uloge { get; set; }

        public string Password { get; set; }

        public string PasswordPotvrda { get; set; }
    }
}
