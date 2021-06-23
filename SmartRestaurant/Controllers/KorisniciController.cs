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
    [Authorize(Roles = "Vlasnik")]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisnikService _korisnikService;
        private readonly IMapper _mapper;

        public KorisniciController(IKorisnikService korisnikService, IMapper mapper)
        {
            _korisnikService = korisnikService;
            _mapper = mapper;
        }

        [HttpGet]
        public IList<Uloge> GetUloge()
        {
            var list = _korisnikService.GetUloge();

            return list;
        }
        [HttpPost]
        public Korisnici Insert(InsertNovogKorisnikaVM obj)
        {
            var list = _korisnikService.Insert(obj);

            return list;
        }
    }
}
