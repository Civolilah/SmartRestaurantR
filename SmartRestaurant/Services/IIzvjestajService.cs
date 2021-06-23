using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRestaurant.Services
{
    public interface IIzvjestajService
    {
       UkupniIzvjestajVM Get(DateTime OD,DateTime DO,string naziv);
    }
}
