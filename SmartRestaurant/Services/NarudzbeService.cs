using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartRestaurant.DbContext;
using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRestaurant.Services
{
    public class NarudzbeService : INarudzbeService
    {
        private AppDBContext _context;

        public NarudzbeService(AppDBContext context)
        {
            _context = context;
        }

        public IList<IspisNarudzbi> Get(PretragaNarudzbiVM request)
        {
            var list = _context.Narudzba.Include(a=>a.MjestoPosluzivanja).Include(a => a.StatusNarudzbe).AsQueryable();
            if(request.NazivNarudzbe!="Brisanje")
            {
                list = list.Where(a => a.StatusNarudzbe.NazivStatusa!="Završeno");
            }
            if (!string.IsNullOrWhiteSpace(request.NazivNarudzbe)&& request.NazivNarudzbe != "Brisanje")
            {
                list = list.Where(a => a.NazivNarudzbe.Contains(request.NazivNarudzbe));
            }

            var lista1 = list.ToList();

            var listaaa = lista1.Select(a => new IspisNarudzbi
            {
                NarudzbaID=a.NarudzbaID,
                MjestoPosluzivanja = a.MjestoPosluzivanja.BrojMjestaPosluzivanja.ToString(),
                NazivNarudzbe = a.NazivNarudzbe,
                StatusNarudzbe = a.StatusNarudzbe.NazivStatusa,
                VrijemeKreiranjaNarudzbe = a.VrijemeKreiranjaNarudzbe
            }).ToList();

            return listaaa;
        }

        public IList<PregledVM> PregledNarudzbi(FilterPregledVM request)
        {
            var list = _context.Narudzba.Include(a => a.MjestoPosluzivanja).Include(a => a.StatusNarudzbe).AsQueryable();
           
            if (!string.IsNullOrWhiteSpace(request.NazivNarudzbe))
            {
                list = list.Where(a => a.NazivNarudzbe.Contains(request.NazivNarudzbe));
            }

            if (!string.IsNullOrWhiteSpace(request.Status))
            {
                list = list.Where(a => a.StatusNarudzbe.NazivStatusa.Contains(request.Status));
            }

            if (!string.IsNullOrWhiteSpace(request.IDMjestaPosluzivanja))
            {
                list = list.Where(a => a.MjestoPosluzivanja.BrojMjestaPosluzivanja.ToString().Contains(request.IDMjestaPosluzivanja));
            }

            list = list.Where(a => a.VrijemeKreiranjaNarudzbe >= request.OD && a.VrijemeKreiranjaNarudzbe <= request.DO);

            var lista1 = list.ToList();

            var listaaa = lista1.Select(a => new PregledVM
            {
                NarudzbaID = a.NarudzbaID,
                IDMjestaPosluzivanja = a.MjestoPosluzivanja.BrojMjestaPosluzivanja.ToString(),
                NazivNarudzbe = a.NazivNarudzbe,
                Status = a.StatusNarudzbe.NazivStatusa,
                VrijemeKreiranjaNarudzbe = a.VrijemeKreiranjaNarudzbe
            }).ToList();

            return listaaa;
        }

        public DetaljiNarudzbeVM GetNarudzbaDetalji(int idnarudzbe)
        {

            DetaljiNarudzbeVM detalji = _context.Narudzba.Include(a=>a.NarudzbaDetalji).Where(a => a.NarudzbaID == idnarudzbe).Select(a => new DetaljiNarudzbeVM
            {
                Cijena=a.NarudzbaDetalji.Cijena.ToString()+" KM"
            }).FirstOrDefault();
            detalji.listaproizvoda = _context.NarudzbaProizvod.Include(a => a.Proizvod).Include(a=>a.Proizvod.ProizvodDetalji).Where(a => a.NarudzbaID == idnarudzbe).Select(a=>new ProizvodNarudzbaDetaljiVM { 
                Naziv=a.Proizvod.Naziv,
                Cijena=a.Proizvod.Cijena,
                Opis=a.Proizvod.ProizvodDetalji.Opis
            }).ToList();

            Narudzba n = _context.Narudzba.Where(a => a.NarudzbaID == idnarudzbe).FirstOrDefault();

            if (n.ImeNarucioca != null)
            {
                detalji.ImeIPrezimeNarucioca = n.ImeNarucioca;
                detalji.AdresaNarucioca = n.AdresaNarucioca;
                detalji.BrojTelefonaNarucioca = n.BrojTelefonaNarucioca;
            }
            return detalji;
        }

        public IzmjeniStatusNarudzbeVM GetNarudzbaStatus(int idnarudzbestatus)
        {

            IzmjeniStatusNarudzbeVM status = new IzmjeniStatusNarudzbeVM();

            
            status.NazivNarudzbe = _context.Narudzba.Where(a => a.NarudzbaID == idnarudzbestatus).Select(a => a.NazivNarudzbe).FirstOrDefault();
            status.listastatusa = _context.StatusNarudzbe.ToList();

            return status;
        }

        public StatusNarudzbeVM IzmijeniStatusNarudzbe(StatusNarudzbeVM obj)
        {
            Narudzba objekat = _context.Narudzba.Where(a => a.NarudzbaID == obj.NarudzbaID).FirstOrDefault();
            objekat.StatusNarudzbeID = _context.StatusNarudzbe.Where(a => a.NazivStatusa == obj.NazivStatusa).Select(a => a.StatusNarudzbeID).FirstOrDefault();
            objekat.PromjenaStatusa = true;
            objekat.PrihvacenaNotifikacija = false;
            _context.SaveChanges();

            return obj;
        }

        public Narudzba IzbrisiNarudzbu(int id)
        {
            NarudzbaProizvod narudzbaproizvod = _context.NarudzbaProizvod.Where(a => a.NarudzbaID == id).FirstOrDefault();
            Narudzba narudzba = _context.Narudzba.Where(a => a.NarudzbaID == id).FirstOrDefault();
            _context.NarudzbaProizvod.Remove(narudzbaproizvod);
            _context.Narudzba.Remove(narudzba);
            _context.SaveChanges();

            return narudzba;

        }

        public UrediNarudzbuVM GetNarudzba(int idnarudzbe)
        {
            UrediNarudzbuVM objekat = new UrediNarudzbuVM();

            List<NarudzbaProizvod> lista = _context.NarudzbaProizvod.Include(a=>a.Proizvod).Include(a=>a.Proizvod.ProizvodDetalji).Where(a => a.NarudzbaID == idnarudzbe).ToList();
            List<Proizvod> lista2 = _context.Proizvod.Include(a => a.ProizvodDetalji).Include(a => a.ProizvodDetalji).ToList();
            objekat.listaproizvoda = lista2.Select(a => new UrediNarudzbuProizvodVM
            {
                NazivProizvoda=a.Naziv,
                Cijena=a.Cijena,
                Narucen=GetValue(lista,a.ProizvodID),
                Opis=a.ProizvodDetalji.Opis,
                ProizvodID=a.ProizvodID
            }).ToList();

            objekat.listamjestaposluzivanja = _context.MjestoPosluzivanja.Select(a => new MjestoPosluzivanja
            {
                MjestoPosluzivanjaID=a.MjestoPosluzivanjaID,
                BrojMjestaPosluzivanja=a.BrojMjestaPosluzivanja
            }).ToList();

            return objekat;
        }

        private bool GetValue(List<NarudzbaProizvod> obj, int proizvodid)
        {
            bool aktivan = false;
            foreach (var item in obj)
            {
                if (item.ProizvodID == proizvodid)
                    aktivan = true;
            }
            return aktivan;
        }

        public Narudzba UrediNarudzbu(IzvrsiUredjivanjeNarudzbeVM obj)
        {
            Narudzba objekat = _context.Narudzba.Where(a => a.NarudzbaID == obj.NarudzbaID).FirstOrDefault();

            List<NarudzbaProizvod> izbrisati = _context.NarudzbaProizvod.Where(a => a.NarudzbaID == objekat.NarudzbaID).ToList();

            foreach (var item in izbrisati)
            {
                _context.NarudzbaProizvod.Remove(item);
            }
            _context.SaveChanges();

            objekat.MjestoPosluzivanjaID = _context.MjestoPosluzivanja.Where(a => a.BrojMjestaPosluzivanja == obj.BrojMjestaNarudzbeID).Select(a => a.MjestoPosluzivanjaID).FirstOrDefault();
            foreach (var item in obj.listaproizvoda)
            {
                NarudzbaProizvod noviobjekat = new NarudzbaProizvod
                {
                    NarudzbaID=obj.NarudzbaID,
                    ProizvodID=item.ProizvodID
                };
                _context.NarudzbaProizvod.Add(noviobjekat);
            }

            _context.SaveChanges();
            return objekat;
        }

        public NovaNarudzba DodajNarudzbu(NovaNarudzba obj)
        {
            Narudzba novanarudzba = new Narudzba
            {
                NazivNarudzbe = obj.NazivNarudzbe,
                VrijemeKreiranjaNarudzbe = obj.VrijemeKreiranja,
                Prihvacena = false,
                PrihvacenaNotifikacija = false,
                PromjenaStatusa=false
            };
            if (obj.KucnaDostava != null)
            {
                novanarudzba.AdresaNarucioca = obj.KucnaDostava.Adresa;
                novanarudzba.BrojTelefonaNarucioca = obj.KucnaDostava.BrojTelefona;
                novanarudzba.ImeNarucioca = obj.KucnaDostava.Imeiprezime;
            }
            novanarudzba.StatusNarudzbeID = _context.StatusNarudzbe.Where(a => a.NazivStatusa == obj.Status).Select(a => a.StatusNarudzbeID).FirstOrDefault();
            novanarudzba.MjestoPosluzivanjaID = _context.MjestoPosluzivanja.Where(a => a.BrojMjestaPosluzivanja == int.Parse(obj.UserName)).Select(a => a.MjestoPosluzivanjaID).FirstOrDefault();
            NarudzbaDetalji novidetalji = new NarudzbaDetalji
            {
                Količina = obj.Detalji.Količina,
                Cijena = obj.Detalji.Cijena,
                Placena = false
            };
            _context.Add(novidetalji);
            _context.SaveChanges();
            int iddetalja = novidetalji.NarudzbaDetaljiID;
            novanarudzba.NarudzbaDetaljiID = iddetalja;
            _context.Add(novanarudzba);
            _context.SaveChanges();
            int idnarudzbe = novanarudzba.NarudzbaID;
            for (int i = 0; i < obj.ListaProizvodID.Count; i++)
            {
                NarudzbaProizvod novinarudzproiz = new NarudzbaProizvod
                {
                    NarudzbaID = idnarudzbe,
                    ProizvodID = obj.ListaProizvodID[i]
                };
                Proizvod proizvod = _context.Proizvod.Include(a => a.ProizvodDetalji).Where(a => a.ProizvodID == obj.ListaProizvodID[i]).FirstOrDefault();
                proizvod.ProizvodDetalji.KolicinaNaSkladistu -= obj.ListaKolicina[i];
                if (proizvod.ProizvodDetalji.KolicinaNaSkladistu <= 0)
                {
                    proizvod.Aktivan = false;
                }
                _context.Add(novinarudzproiz);
                _context.SaveChanges();
            }
            int korisnikid = _context.Korisnici.Where(a => a.NazivKorisnika == obj.UserName).Select(a => a.KorisnikID).FirstOrDefault();
            KorisnikNarudzba novikorisniknarudzba = new KorisnikNarudzba {
                KorisnikID = korisnikid,
                NarudzbaID = idnarudzbe
            };
            _context.Add(novikorisniknarudzba);
            _context.SaveChanges();
            return obj;
        }

        public List<Narudzba> GetBezNot(string user)
        {
            List<Narudzba> listaa = null;
            if (user!=null)
            {
                listaa = _context.KorisnikNarudzba.Include(a => a.Narudzba).Include(a => a.Korisnici).Include(a => a.Narudzba.StatusNarudzbe).Where(a => a.Narudzba.PromjenaStatusa == true && a.Korisnici.NazivKorisnika == user && a.Narudzba.StatusNarudzbe.NazivStatusa != "Završeno" && a.Narudzba.PrihvacenaNotifikacija == false).Select(b => new Narudzba
                {
                    AdresaNarucioca = b.Narudzba.AdresaNarucioca,
                    BrojTelefonaNarucioca = b.Narudzba.BrojTelefonaNarucioca,
                    ImeNarucioca = b.Narudzba.ImeNarucioca,
                    MjestoPosluzivanjaID = b.Narudzba.MjestoPosluzivanjaID,
                    NarudzbaDetaljiID = b.Narudzba.NarudzbaDetaljiID,
                    NazivNarudzbe = b.Narudzba.NazivNarudzbe,
                    Prihvacena = b.Narudzba.Prihvacena,
                    PrihvacenaNotifikacija = b.Narudzba.PrihvacenaNotifikacija,
                    PromjenaStatusa = b.Narudzba.PromjenaStatusa,
                    StatusNarudzbeID = b.Narudzba.StatusNarudzbeID,
                    VrijemeKreiranjaNarudzbe = b.Narudzba.VrijemeKreiranjaNarudzbe,
                    VrijemeOdgovoraNaNarudzbu = b.Narudzba.VrijemeOdgovoraNaNarudzbu,
                    StatusNarudzbe = b.Narudzba.StatusNarudzbe,
                    NarudzbaID = b.NarudzbaID
                }).ToList(); 
            }
            else
            {
                Narudzba n = _context.Narudzba.FirstOrDefault();
                listaa.Add(n);
            }
            return listaa;
        }

        public Narudzba PromijeniStatusNotifikacije(int idnarudzbe)
        {
            Narudzba n = _context.Narudzba.Where(a => a.NarudzbaID == idnarudzbe).FirstOrDefault();
            n.PrihvacenaNotifikacija = true;
            n.PromjenaStatusa = false;
            _context.SaveChanges();

            return n;
        }

        public List<Narudzba> GetBezPrihvacanja()
        {
            List<Narudzba> listaa = null;

            listaa = _context.KorisnikNarudzba.Include(a => a.Narudzba).Include(a=>a.Narudzba.MjestoPosluzivanja).Include(a => a.Korisnici).Include(a => a.Narudzba.StatusNarudzbe).Where(a => a.Narudzba.Prihvacena==false).Select(b => new Narudzba
            {
                AdresaNarucioca = b.Narudzba.AdresaNarucioca,
                BrojTelefonaNarucioca = b.Narudzba.BrojTelefonaNarucioca,
                ImeNarucioca = b.Narudzba.ImeNarucioca,
                MjestoPosluzivanjaID = b.Narudzba.MjestoPosluzivanjaID,
                NarudzbaDetaljiID = b.Narudzba.NarudzbaDetaljiID,
                NazivNarudzbe = b.Narudzba.NazivNarudzbe,
                Prihvacena = b.Narudzba.Prihvacena,
                PrihvacenaNotifikacija = b.Narudzba.PrihvacenaNotifikacija,
                PromjenaStatusa = b.Narudzba.PromjenaStatusa,
                StatusNarudzbeID = b.Narudzba.StatusNarudzbeID,
                VrijemeKreiranjaNarudzbe = b.Narudzba.VrijemeKreiranjaNarudzbe,
                VrijemeOdgovoraNaNarudzbu = b.Narudzba.VrijemeOdgovoraNaNarudzbu,
                StatusNarudzbe = b.Narudzba.StatusNarudzbe,
                NarudzbaID = b.NarudzbaID,
                MjestoPosluzivanja=b.Narudzba.MjestoPosluzivanja
            }).ToList();

            return listaa;
        }

        public Narudzba PromijeniStatusPrihvatanja(int idnarudzbe)
        {
            Narudzba n = _context.Narudzba.Where(a => a.NarudzbaID == idnarudzbe).FirstOrDefault();
            n.Prihvacena = true;

            _context.SaveChanges();

            return n;
        }

        public List<PlatiNarudzbuVM> GetNeplacene(string korisnik)
        {
            List<PlatiNarudzbuVM> listaneplacenih = _context.KorisnikNarudzba.Include(a => a.Narudzba).Include(a => a.Korisnici).Include(a=>a.Narudzba.StatusNarudzbe).Include(a => a.Narudzba.NarudzbaDetalji).Where(a => a.Korisnici.NazivKorisnika == korisnik&& a.Narudzba.NarudzbaDetalji.Placena==false && a.Narudzba.StatusNarudzbe.NazivStatusa!="Završeno").Select(a => new PlatiNarudzbuVM { 
                    NazivNarudzbe=a.Narudzba.NazivNarudzbe,
                    Cijena=a.Narudzba.NarudzbaDetalji.Cijena,
                     ImeNarucioca=a.Narudzba.ImeNarucioca,
                     NarudzbaID=a.NarudzbaID
            }).ToList();

            return listaneplacenih;
        }

        public Narudzba PlatiNarudzbu(int idnarudzbe)
        {
            Narudzba n = _context.Narudzba.Where(a => a.NarudzbaID == idnarudzbe).FirstOrDefault();
            NarudzbaDetalji narudzbadetalji = _context.Narudzba.Include(a => a.NarudzbaDetaljiID).Where(a => a.NarudzbaID == idnarudzbe).Select(a => a.NarudzbaDetalji).FirstOrDefault();
            narudzbadetalji.Placena = true;
            _context.SaveChanges();

            return n;
        }
    }
}
