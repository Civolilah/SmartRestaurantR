using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartRestaurant.DbContext;
using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartRestaurant.Services
{
    public class KorisnikService : IKorisnikService
    {
        private AppDBContext _context;

        private IMapper _mapper;

        public KorisnikService(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<IspisNarudzbi> Get(PretragaNarudzbiVM request)
        {
            var list = _context.Narudzba.Include(a=>a.StatusNarudzbe).AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.NazivNarudzbe))
            {
                list = list.Where(a => a.NazivNarudzbe.StartsWith(request.NazivNarudzbe));
            }

            var lista1 = list.ToList();

            var listaaa = lista1.Select(a => new IspisNarudzbi
            {
                MjestoPosluzivanja=a.MjestoPosluzivanjaID.ToString(),
                NazivNarudzbe=a.NazivNarudzbe,
                StatusNarudzbe=a.StatusNarudzbe.NazivStatusa,
                VrijemeKreiranjaNarudzbe=a.VrijemeKreiranjaNarudzbe
            }).ToList();

            return listaaa;
        }



        public Model.Korisnici Authenticiraj(string username, string pass)
        {
            var user = _context.Korisnici.FirstOrDefault(x => x.NazivKorisnika == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.PasswordSalt, pass);

                if (hashedPass == user.PasswordHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }

            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Korisnici Insert(InsertNovogKorisnikaVM korisnik)
        {
            Korisnici korsnikk = new Korisnici
            {
                NazivKorisnika=korisnik.NazivKorisnika,
            };
            
            if (korisnik.Password != korisnik.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            korsnikk.PasswordSalt = GenerateSalt();
            korsnikk.PasswordHash = GenerateHash(korsnikk.PasswordSalt, korisnik.Password);
            
            _context.Korisnici.Add(korsnikk);
            _context.SaveChanges();
            int idkorisnika = _context.Korisnici.Where(a => a.NazivKorisnika == korsnikk.NazivKorisnika).Select(a=>a.KorisnikID).FirstOrDefault();
            int iduloge = korisnik.Uloge.UlogaID;
            KorisnikUloga novakorisnikuloga = new KorisnikUloga
            {
                 KorisniciID=idkorisnika,
                 UlogeID=iduloge
            };
            _context.KorisnikUloga.Add(novakorisnikuloga);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(korsnikk);
        }

        public Korisnici Autentifikacija(string nazivkorisnika, string password)
        {
            string nazivv = "";
            string passwordd = "";
            int brojac = 0;
            if (nazivkorisnika.StartsWith(" "))
            {
                foreach (var item in nazivkorisnika)
                {
                    if(brojac==0)
                    {
                        brojac++;
                    }
                    else
                    {
                        nazivv += item;
                    }
                }
                brojac = 0;
                foreach (var item in password)
                {
                    if (brojac == 0)
                    {
                        brojac++;
                    }
                    else
                    {
                        passwordd += item;
                    }
                }
                nazivkorisnika = nazivv;
                password = passwordd;
            }
            var user = _context.Korisnici.Where(a=>a.NazivKorisnika== nazivkorisnika).FirstOrDefault();

            if (user != null)
            {
                var hashedPass = GenerateHash(user.PasswordSalt, password);

                if (hashedPass == user.PasswordHash)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }

            return null;
        }

        [HttpGet]
        public IList<Uloge> GetUloge()
        {
            var obj = _context.Uloge.ToList();

            return obj;
        }


        //public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        //{
        //    var query = _context.Korisnici.AsQueryable();

        //    if (!string.IsNullOrWhiteSpace(request?.Ime))
        //    {
        //        query = query.Where(x => x.Ime.StartsWith(request.Ime));
        //    }

        //    if (!string.IsNullOrWhiteSpace(request?.Prezime))
        //    {
        //        query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
        //    }

        //    if (request?.IsUlogeLoadingEnabled == true)
        //    {
        //        query = query.Include(x => x.KorisniciUloge);
        //    }

        //    var list = query.ToList();

        //    return _mapper.Map<List<Model.Korisnici>>(list);
        //}
    }
}
