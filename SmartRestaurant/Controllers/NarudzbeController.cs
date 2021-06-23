using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartRestaurant.DbContext;
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
    [Authorize(Roles = "Vlasnik, Administrator")]
    public class NarudzbeController : ControllerBase
    {
        private readonly INarudzbeService _narudzbeService;
        private readonly IMapper _mapper;

        public NarudzbeController(INarudzbeService narudzbeService, IMapper mapper)
        {
            _narudzbeService = narudzbeService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("[action]")]
        public IList<IspisNarudzbi> GetIspisNarudzbi([FromQuery] PretragaNarudzbiVM request)
        {
            var list = _narudzbeService.Get(request);

            return list;
        }

        [HttpGet("{idnarudzbe}")]
        public DetaljiNarudzbeVM GetNarudzbaDetalji(int idnarudzbe)
        {
            var obj = _narudzbeService.GetNarudzbaDetalji(idnarudzbe);

            return obj;
        }

        [HttpGet]
        [Route("[action]/{idnarudzbestatus}")]
        public IzmjeniStatusNarudzbeVM GetNarudzbaStatus(int idnarudzbestatus)
        {
            var obj = _narudzbeService.GetNarudzbaStatus(idnarudzbestatus);

            return obj;
        }

        [HttpGet]
        [Route("[action]/{search}")]
        public List<Narudzba> GetBezNot(string search)
        {
            var obj = _narudzbeService.GetBezNot(search);

            return obj;
        }

        [HttpGet]
        [Route("[action]/{korisnik}")]
        public List<PlatiNarudzbuVM> GetNeplacene(string korisnik)
        {
            var list = _narudzbeService.GetNeplacene(korisnik);

            return list;
        }

        [HttpPatch]
        [Route("[action]/{idnarudzbe}")]
        public Narudzba PlatiNarudzbu(int idnarudzbe)
        {
            var list = _narudzbeService.PlatiNarudzbu(idnarudzbe);

            return list;
        }

        [HttpGet]
        [Route("[action]")]
        public List<Narudzba> GetBezPrihvacanja()
        {
            var obj = _narudzbeService.GetBezPrihvacanja();

            return obj;
        }

        [HttpPatch]
        public StatusNarudzbeVM IzmjeniStatusNarudzbe(StatusNarudzbeVM objekat)
        {
            var obj = _narudzbeService.IzmijeniStatusNarudzbe(objekat);

            return obj;
        }

        [HttpPatch]
        [Route("[action]/{idnarudzbe}")]
        public Narudzba PromijeniStatusNotifikacije(int idnarudzbe)
        {
            Narudzba n=_narudzbeService.PromijeniStatusNotifikacije(idnarudzbe);

            return n;
        }

        [HttpPatch]
        [Route("[action]/{idnarudzbe}")]
        public Narudzba PromijeniStatusPrihvatanja(int idnarudzbe)
        {
            Narudzba n = _narudzbeService.PromijeniStatusPrihvatanja(idnarudzbe);

            return n;
        }

        [HttpDelete]
        public Narudzba IzbrisiNarudzbu(int id)
        {
            var obj = _narudzbeService.IzbrisiNarudzbu(id);

            return obj;
        }

        [HttpPost]
        public NovaNarudzba DodajNarudzbu(NovaNarudzba objekat)
        {
            var obj = _narudzbeService.DodajNarudzbu(objekat);

            return obj;
        }
    }
}
