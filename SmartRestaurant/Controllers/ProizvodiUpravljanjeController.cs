using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using SmartRestaurant.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRestaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator, Vlasnik")]
    public class ProizvodiUpravljanjeController : ControllerBase
    {
        private readonly IProizvodService _proizvodService;

        public ProizvodiUpravljanjeController(IProizvodService proizvodService)
        {
            _proizvodService = proizvodService;
        }

        [HttpGet("{id}")]
        public DetaljiProizvodaVM GetDetaljiProizvoda(int id)
        {
            var list = _proizvodService.GetDetaljiProizvoda(id);

            return list;
        }

        [HttpGet]
        [Route("[action]/{idnarudzbe}")]
        public UrediStatusVM GetStatusNarudzbe(int idnarudzbe)
        {
            var list = _proizvodService.GetStatusNarudzbe(idnarudzbe);

            return list;
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public IList<ProizvodiVM> GetSveProizvode(int id)
        {
            var list = _proizvodService.GetSviProizvodi(id);

            return list;
        }

        [HttpGet]
        [Route("{korisnik}/GetPreporuke")]
        public IList<ProizvodiVM> GetPreporuke(string korisnik)
        {
            var list = _proizvodService.GetPreporuke(korisnik);

            return list;
        }

        [HttpPatch]
        public Proizvod PromjenaStatusa(PromjenaStatusaVM obj)
        {
            var list = _proizvodService.PromjenaStatusa(obj);

            return list;
        }

        [HttpPatch("OcijeniProizvod")]
        public Proizvod OcijeniProizvod(OcjenaProizvodaVM obj)
        {
            var list = _proizvodService.OcijeniProizvod(obj);

            return list;
        }
    }
}
