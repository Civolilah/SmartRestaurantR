using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRestaurant.Services
{
    public interface IProizvodService
    {
        NoviProizvodVM GetNoviProizvod();
        DetaljiProizvodaVM GetDetaljiProizvoda(int id);
        InsertProizvodaVM InsertNoviProizvod(InsertProizvodaVM obj);
        IList<PretragaProizvodaVM> GetByStatus(string status);
        IList<ProizvodiVM> GetSviProizvodi(int id);
        IList<ProizvodiVM> GetPreporuke(string korisnik);
        UrediStatusVM GetStatusNarudzbe(int idnarudzbe);
        Proizvod PromjenaStatusa(PromjenaStatusaVM obj);
        Proizvod OcijeniProizvod(OcjenaProizvodaVM obj);
    }
}
