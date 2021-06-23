using AutoMapper;
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
    public class ProizvodController : ControllerBase
    {
        private readonly IProizvodService _proizvodService;
        private readonly IMapper _mapper;

        public ProizvodController(IProizvodService proizvodService, IMapper mapper)
        {
            _proizvodService = proizvodService;
            _mapper = mapper;
        }

        [HttpGet]
        public NoviProizvodVM GetNoviProizvod()
        {
            var list = _proizvodService.GetNoviProizvod();

            return list;
        }

        [HttpGet("{status}")]
        public IList<PretragaProizvodaVM> GetByStatus(string status)
        {
            var list = _proizvodService.GetByStatus(status);

            return list;
        }

        [HttpPost]
        public InsertProizvodaVM InsertNovogProizvoda(InsertProizvodaVM obj)
        {
            var list = _proizvodService.InsertNoviProizvod(obj);

            return list;
        }
    }
}
