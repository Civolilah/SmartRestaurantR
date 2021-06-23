using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using SmartRestaurant.Model.ViewModels;
using Newtonsoft;

namespace SmartRestaurantWinUI
{
    public class APIService
    {
        private string _route;
        public static string Username { get; set; }
        public static string Password { get; set; }
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> PregledNarudzbi<T>(object search)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}";
            
            if (search!=null)
            {
                var keyValueContent = search.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString()+"="+values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString()+"&";
                    }
                    brojac++;
                }
            }
            
            
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}"+ "/GetIspisNarudzbi";
               
            if (search != null)
            {
                var keyValueContent = search.ToKeyValue();
                var key = keyValueContent.Keys.FirstOrDefault().ToString();
                var values = keyValueContent.Values.FirstOrDefault().ToString();
                url += "?";
                url += key + "=" + values;
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetIzvjestaj<T>(object search)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}";

            if (search != null)
            {
                var keyValueContent = search.ToKeyValue();
                var DO = keyValueContent.Where(a=>a.Key=="DO").FirstOrDefault();
                var dovalue = DO.Value.ToString();
                url += "?";
                url +=  "OD" + "=" + keyValueContent.Values.FirstOrDefault().ToString()+"&";
                url +=  "DO" + "=" + dovalue+"&naziv="+ keyValueContent.Values.LastOrDefault().ToString();
                
            }

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetBezPrihvatanja<T>()
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}" + "/GetBezPrihvacanja";
            
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetNoviProizvod<T>()
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetUloge<T>()
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetNarudzbaDetalji<T>(object idnarudzbe)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}/{idnarudzbe}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetNarudzbaStatus<T>(object idnarudzbestatus)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}/";
            url += $"GetNarudzbaStatus/{idnarudzbestatus}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetByStatus<T>(object status)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}/{status}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetDetaljiProizvoda<T>(object id)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}/{id}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetNarudzbu<T>(object id)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}/{id}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetStatusNarudzbe<T>(object idnarudzbe)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}/";
            url += $"GetStatusNarudzbe/{idnarudzbe}";
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> PromjenaStatusa<T>(object obj)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}";
            var result = await url.WithBasicAuth(Username, Password).PatchJsonAsync(obj).ReceiveJson<T>();

            return result;
        }

        public async Task<T> PromjenaStatusPrihvatanja<T>(int id)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}" + "/PromijeniStatusPrihvatanja/";
            url += id;
            var result = await url.WithBasicAuth(Username, Password).PatchJsonAsync(id).ReceiveJson<T>();

            return result;
        }

        public async Task<T> PromjenaStatusaNarudzbe<T>(object obj)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}";
            var result = await url.WithBasicAuth(Username, Password).PatchJsonAsync(obj).ReceiveJson<T>();

            return result;
        }

        public async Task<T> UrediNarudzbu<T>(object search)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}";

            if (search != null)
            {
                var keyValueContent = search.ToKeyValue();
                var keys = keyValueContent.Keys.ToList();
                var values = keyValueContent.Values.ToList();
                url += "?";
                int brojac = 0;
                foreach (var item in keys)
                {
                    if (brojac == keys.Count - 1)
                    {
                        url += item.ToString() + "=" + values[brojac].ToString();
                    }
                    else
                    {
                        url += item.ToString() + "=" + values[brojac].ToString() + "&";
                    }
                    brojac++;
                }
            }
            var result = await url.WithBasicAuth(Username, Password).PatchJsonAsync(search).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Insert<T>(object objectt)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(objectt).ReceiveJson<T>();

            return result;
        }

        public async Task<T> IzbrisiNarudzbu<T>(int id)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}";
            url += "?id=" + id;

            var result = await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();

            return result;
        }

        public async Task<T> InsertNovogProizvoda<T>(object objectt)
        {
            var url = $"{ Properties.Settings.Default.ApiURL}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(objectt).ReceiveJson<T>();

            return result;
        }
    }
}
