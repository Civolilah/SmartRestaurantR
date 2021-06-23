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
    public class IzvjestajService : IIzvjestajService
    {
        private AppDBContext _context;

        public IzvjestajService(AppDBContext context)
        {
            _context = context;
        }
        public UkupniIzvjestajVM Get(DateTime _OD, DateTime _DO, string naziv)
        {
            IzvjestajFilterVM request = new IzvjestajFilterVM
            {
                DO=_DO,
                OD=_OD,
                NazivProizvoda=naziv
            };
            UkupniIzvjestajVM izvjestaj = new UkupniIzvjestajVM();
            var list = _context.NarudzbaProizvod.Include(a => a.Proizvod).Include(a => a.Proizvod.ProizvodDetalji).Include(a=>a.Narudzba).ToList();

            if (!string.IsNullOrWhiteSpace(request.NazivProizvoda))
            {
                list = list.Where(a => a.Proizvod.Naziv.Contains(request.NazivProizvoda)).ToList();
            }
            list = list.Where(a => a.Narudzba.VrijemeKreiranjaNarudzbe >= request.OD && a.Narudzba.VrijemeKreiranjaNarudzbe <= request.DO).ToList();
            List<NarudzbaProizvod> listanarudzbaproizvod = _context.NarudzbaProizvod.Where(a => a.Narudzba.VrijemeKreiranjaNarudzbe >= request.OD && a.Narudzba.VrijemeKreiranjaNarudzbe <= request.DO).ToList();
            var listaproizvodid = list.Select(a => a.ProizvodID).ToList();
            List<Proizvod> listaproizvoda = _context.Proizvod.Include(a=>a.ProizvodDetalji).Where(a => IsAnyOf(listaproizvodid, a.ProizvodID) == true).ToList();
            izvjestaj.tabela = listaproizvoda.Select(a => new IzvjestajTabelaVM
            {
                NazivProizvoda=a.Naziv,
                Cijena=a.Cijena,
                TrenutnoStanje=a.ProizvodDetalji.KolicinaNaSkladistu.ToString(),
                PutaProdan=GetBrojPutaProdan(listanarudzbaproizvod,a.ProizvodID)
            }).ToList();

            
            izvjestaj.UkupnaZarada = listanarudzbaproizvod.Select(a => a.Proizvod.Cijena).Sum().ToString() + " KM";
            izvjestaj.UkupnoNarudzbi = listanarudzbaproizvod.Select(a => a.ProizvodID).Count();
            izvjestaj.BrojNarudzbiProizvoda = izvjestaj.tabela.Select(a => a.PutaProdan).Sum();
            izvjestaj.ProcenatNarudzbe = (((float)izvjestaj.BrojNarudzbiProizvoda / (float)izvjestaj.UkupnoNarudzbi)*100).ToString() + " %";
            return izvjestaj;
        } 
        private int GetBrojPutaProdan(List<NarudzbaProizvod> listanarudzva,int id)
        {
            int brojputa = listanarudzva.Where(a=>a.ProizvodID==id).Count();
            
            return brojputa;
        }

        private bool IsAnyOf(List<int> list,int proizvodid)
        {
            foreach (var item in list)
            {
                if (item == proizvodid)
                    return true;
            }
            return false;
        }

    }
}
