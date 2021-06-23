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
    public class ProizvodService : IProizvodService
    {
        private AppDBContext _context;

        public ProizvodService(AppDBContext context)
        {
            _context = context;
        }

        public IList<PretragaProizvodaVM> GetByStatus(string status)
        {
            
            if(status=="Svi")
            {
                var lista = _context.Proizvod.Include(a=>a.Skladiste).Select(a => new PretragaProizvodaVM
                {
                    ProizvodID=a.ProizvodID,
                    Naziv=a.Naziv,
                    Aktivan=GetStatusString(a.Aktivan),
                    Cijena=a.Cijena,
                    NazivSkladista=a.Skladiste.NazivSkladista,
                    Slika=a.Slika
                }).ToList();

                return lista;
            }
            else
            {
                bool statusdva = false;
                if(status=="Aktivni")
                {
                    statusdva = true;
                }
                var lista = _context.Proizvod.Include(a => a.Skladiste).Where(a=>a.Aktivan==statusdva).Select(a => new PretragaProizvodaVM
                {
                    ProizvodID = a.ProizvodID,
                    Naziv = a.Naziv,
                    Aktivan = GetStatusString(a.Aktivan),
                    Cijena = a.Cijena,
                    NazivSkladista = a.Skladiste.NazivSkladista,
                    Slika = a.Slika
                }).ToList();

                return lista;
            }

        }

        public DetaljiProizvodaVM GetDetaljiProizvoda(int id)
        {
            int ocjena = _context.KorisnikOcjena.Where(a => a.ProizvodID == id).Select(a => a.Ocjena).FirstOrDefault();
            DetaljiProizvodaVM proizvod = _context.Proizvod.Include(a => a.ProizvodDetalji).Include(a=> a.JedinicaKolicine).Include(a=> a.PodKategorijeProizvoda).Where(a => a.ProizvodID == id).Select(a => new DetaljiProizvodaVM
            {
                JedinicaMjere=a.JedinicaKolicine.NazivJedinice,
                KategorijaProizvoda=a.PodKategorijeProizvoda.Naziv,
                KolicinaNaSkladistu=(a.ProizvodDetalji.KolicinaNaSkladistu*a.Količina).ToString(),
                Opis=a.ProizvodDetalji.Opis,
                KolicinaProizvoda=a.Količina,
                Slika=a.Slika,
                Ocjena= ocjena
            }).FirstOrDefault();

            return proizvod;
        }

        public NoviProizvodVM GetNoviProizvod()
        {
            NoviProizvodVM novi = new NoviProizvodVM();

            novi.Skladiste = _context.Skladiste.Select(a => new Skladiste
            {
                SkladisteID=a.SkladisteID,
                NazivSkladista=a.NazivSkladista
            }).ToList();

            novi.KategorijaProizvoda = _context.PodKategorijeProizvoda.Select(a => new PodKategorijeProizvoda
            {
                ID=a.ID,
                Naziv=a.Naziv
            }).ToList();

            novi.JedinicaKolicine = _context.JedinicaKolicine.Select(a => new JedinicaKolicine
            {
                JedinicaKolicineID=a.JedinicaKolicineID,
                NazivJedinice=a.NazivJedinice
            }).ToList();

            return novi;
        }

        public IList<ProizvodiVM> GetPreporuke(string korisnik)
        {
            int idkorisnika = _context.Korisnici.Where(a => a.NazivKorisnika == korisnik).Select(a => a.KorisnikID).FirstOrDefault();
            List<ProizvodiVM> listapreporuka = new List<ProizvodiVM>();
            List<KorisnikOcjena> listaocjenjenih = _context.KorisnikOcjena.Include(a=>a.Proizvod).Include(a=>a.Proizvod.PodKategorijeProizvoda).Where(a => a.KorisniciID == idkorisnika && a.Ocjena>=3).ToList();
            List<Proizvod> listaproizvoda = _context.Proizvod.Include(a=>a.PodKategorijeProizvoda).ToList();

            if(listaocjenjenih.Count>0)
            {
                for (int i = 0; i < listaocjenjenih.Count; i++)
                {
                    for (int j = 0; j < listaproizvoda.Count; j++)
                    {
                        if(IsOcjenjen(listaproizvoda[j].ProizvodID,idkorisnika)==false && PripadaPodGrupi(listaocjenjenih[i].Proizvod.PodKategorijeProizvoda.Naziv, listaproizvoda[j].ProizvodID) == true && PostojiUListi(listaproizvoda[j].ProizvodID, listapreporuka) == false)
                        {
                            listapreporuka.Add(new ProizvodiVM
                            {
                                ProizvodID=listaproizvoda[j].ProizvodID,
                                Cijena=listaproizvoda[j].Cijena,
                                Naziv=listaproizvoda[j].Naziv,
                                Slika=listaproizvoda[j].Slika
                            });
                        }
                    }
                }
            }

            if(listaproizvoda.Count>6)
                listapreporuka = listapreporuka.Take(6).ToList();
            else
                listapreporuka = listapreporuka.ToList();

            var listaa = listapreporuka.ToList();

            return listaa;
        }

        public UrediStatusVM GetStatusNarudzbe(int idnarudzbe)
        {
            string nazivnarudzbe = _context.Proizvod.Where(a => a.ProizvodID == idnarudzbe).Select(a => a.Naziv).FirstOrDefault();
            List<string> _status = new List<string>();
            _status.Add("Aktivan");
            _status.Add("Neaktivan");
            UrediStatusVM novi = new UrediStatusVM
            {
                NazivNarudzbe=nazivnarudzbe,
                Status=_status
            };

            return novi;
        }

        public IList<ProizvodiVM> GetSviProizvodi(int id)
        {
            if(id==1)
            {
                var listaproizvoda = _context.Proizvod.Include(a=>a.PodKategorijeProizvoda).Include(a=>a.PodKategorijeProizvoda.KategorijaProizvoda).Where(a => a.Aktivan == true && a.PodKategorijeProizvoda.KategorijaProizvoda.NazivKategorije=="Hrana").Select(a => new ProizvodiVM
                {
                    ProizvodID = a.ProizvodID,
                    Naziv = a.Naziv,
                    Cijena = a.Cijena,
                    Slika = a.Slika
                }).ToList();

                return listaproizvoda;
            }
            else
            {
                var listaproizvodaa = _context.Proizvod.Include(a => a.PodKategorijeProizvoda).Include(a => a.PodKategorijeProizvoda.KategorijaProizvoda).Where(a => a.Aktivan == true && a.PodKategorijeProizvoda.KategorijaProizvoda.NazivKategorije == "Piće").Select(a => new ProizvodiVM
                {
                    ProizvodID = a.ProizvodID,
                    Naziv = a.Naziv,
                    Cijena = a.Cijena,
                    Slika = a.Slika
                }).ToList();
                return listaproizvodaa;
            }
        }

        public InsertProizvodaVM InsertNoviProizvod(InsertProizvodaVM obj)
        {
            ProizvodDetalji detalji = new ProizvodDetalji
            {
               Opis=obj.Opis,
               KolicinaNaSkladistu=obj.KolicinaNaSkladistu
            };
            _context.Add(detalji);
            _context.SaveChanges();
            int jedinicakolicineid = _context.JedinicaKolicine.Where(a => a.NazivJedinice == obj.JedinicaKolicine).Select(a => a.JedinicaKolicineID).FirstOrDefault();
            int kategorijaproizvodaid = _context.PodKategorijeProizvoda.Where(a => a.Naziv == obj.KategorijaProizvoda).Select(a => a.ID).FirstOrDefault();
            int skladisteid = _context.Skladiste.Where(a => a.NazivSkladista == obj.Skladiste).Select(a => a.SkladisteID).FirstOrDefault();
            int detaljiid = _context.ProizvodDetalji.Where(a => a.Opis == obj.Opis && a.KolicinaNaSkladistu == obj.KolicinaNaSkladistu).Select(a => a.ProizvodDetaljiID).FirstOrDefault();
            Proizvod novi = new Proizvod
            {
                ProizvodDetaljiID= detaljiid,
                Aktivan=obj.Aktivan,
                Cijena=obj.Cijena,
                JedinicaKolicineID= jedinicakolicineid,
                PodKategorijeProizvodaID= kategorijaproizvodaid,
                Naziv=obj.Naziv,
                Količina=obj.Kolicina,
                Slika=obj.Slika,
                SkladisteID= skladisteid,
                IstekRoka=obj.IstekRoka,
                NabavnaCijena=obj.NabavnaCijena
            };
            
            _context.Add(novi);
            _context.SaveChanges();
            return obj;
        }

        public Proizvod PromjenaStatusa(PromjenaStatusaVM obj)
        {
            Proizvod p = _context.Proizvod.Where(a => a.ProizvodID == obj.proizvodid).FirstOrDefault();

            p.Aktivan = obj.aktivan;
            _context.SaveChanges();

            return p;
        }

        private string GetStatusString(bool status)
        {
            if (status == false)
                return "Neaktivan";
            else
                return "Aktivan";
        }

        public Proizvod OcijeniProizvod(OcjenaProizvodaVM obj)
        {
            KorisnikOcjena objekat = null;
            int korisniid = _context.Korisnici.Where(a => a.NazivKorisnika == obj.Korisnik).Select(a => a.KorisnikID).FirstOrDefault();
            objekat = _context.KorisnikOcjena.Include(a=>a.Proizvod).Where(a => a.KorisniciID == korisniid && a.ProizvodID == obj.ProizvodID).FirstOrDefault();

            if (objekat!=null)
            {
                objekat.Ocjena = obj.Ocjena;
                _context.SaveChanges();
            }
            else
            {
                KorisnikOcjena novi = new KorisnikOcjena
                {
                    KorisniciID= korisniid,
                    ProizvodID=obj.ProizvodID,
                    Ocjena=obj.Ocjena
                };
                _context.Add(novi);
                _context.SaveChanges();
            }
            Proizvod p = _context.Proizvod.Where(a => a.ProizvodID == obj.ProizvodID).FirstOrDefault();
            return p;
        }

        private bool IsOcjenjen(int proizvodid, int korisnikid)
        {
            KorisnikOcjena objekat = null;
            objekat = _context.KorisnikOcjena.Where(a => a.KorisniciID == korisnikid && a.ProizvodID == proizvodid).FirstOrDefault();

            if (objekat != null)
                return true;

            return false;
        }

        private bool PripadaPodGrupi(string nazivpodgrupe, int proizvodid)
        {
            Proizvod p = null;
            p = _context.Proizvod.Where(a => a.PodKategorijeProizvoda.Naziv == nazivpodgrupe && a.ProizvodID == proizvodid).FirstOrDefault();

            if (p != null)
                return true;

            return false;
        }

        private bool PostojiUListi(int proizvodid, List<ProizvodiVM> obj)
        {
            ProizvodiVM objekat = null;
            objekat = obj.Where(a => a.ProizvodID == proizvodid).FirstOrDefault();

            if (objekat != null)
                return true;

            return false;
        }
    }
}
