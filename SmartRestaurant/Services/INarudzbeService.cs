using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRestaurant.Services
{
    public interface INarudzbeService
    {
        IList<IspisNarudzbi> Get(PretragaNarudzbiVM request);
        IList<PregledVM> PregledNarudzbi(FilterPregledVM request);
        DetaljiNarudzbeVM GetNarudzbaDetalji(int idnarudzbe);
        IzmjeniStatusNarudzbeVM GetNarudzbaStatus(int idnarudzbestatus);
        StatusNarudzbeVM IzmijeniStatusNarudzbe(StatusNarudzbeVM obj);
        Narudzba IzbrisiNarudzbu(int id);
        UrediNarudzbuVM GetNarudzba(int idnarudzbe);
        Narudzba UrediNarudzbu(IzvrsiUredjivanjeNarudzbeVM obj);
        NovaNarudzba DodajNarudzbu(NovaNarudzba obj);
        List<Narudzba> GetBezNot(string user);
        List<PlatiNarudzbuVM> GetNeplacene(string korisnik);
        List<Narudzba> GetBezPrihvacanja();
        Narudzba PromijeniStatusNotifikacije(int idnarudzbe);
        Narudzba PromijeniStatusPrihvatanja(int idnarudzbe);
        Narudzba PlatiNarudzbu(int idnarudzbe);
    }
}
