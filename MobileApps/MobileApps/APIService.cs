using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using SmartRestaurant.Model.ViewModels;
namespace MobileApps
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
#if DEBUG
        private string _apiUrl = "http://localhost:10046/api";
#endif
#if RELEASE
        private string _apiUrl = "https://myapp.com/api";
#endif

        public T PregledNarudzbi<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

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
            var result = url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result.Result;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}"+"/GetIspisNarudzbi";

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

        public T GetBezNotifikacije<T>(string search)
        {
           var url = $"{_apiUrl}/{_route}" + "/GetBezNot/";
            url += search;
            
            var result = url.WithBasicAuth(Username, Password).GetJsonAsync<T>().Result;

            return result;
        }

        public async Task<T> GetNeplacene<T>(string username)
        {
            var url = $"{_apiUrl}/{_route}" + "/GetNeplacene/";
            url += username;

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> PromijeniStatusNotifikacije<T>(int idnarudzbe)
        {
            var url = $"{_apiUrl}/{_route}" + "/PromijeniStatusNotifikacije/";
            url += idnarudzbe;
            var result=await url.WithBasicAuth(Username, Password).PatchJsonAsync(idnarudzbe).ReceiveJson<T>();

            return result;
        }

        public T PlatiNarudzbu<T>(int idnarudzbe)
        {
            var url = $"{_apiUrl}/{_route}" + "/PlatiNarudzbu/";
            url += idnarudzbe;
            var result = url.WithBasicAuth(Username, Password).PatchJsonAsync(idnarudzbe).ReceiveJson<T>();

            return result.Result;
        }

        public async Task<T> DodajNarudzbu<T>(object objekat)
        {
            var url = $"{_apiUrl}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(objekat).ReceiveJson<T>();

            return result;
        }

        public T GetIzvjestaj<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

            if (search != null)
            {
                var keyValueContent = search.ToKeyValue();
                var DO = keyValueContent.Where(a => a.Key == "DO").FirstOrDefault();
                var dovalue = DO.Value.ToString();
                url += "?";
                url += "OD" + "=" + keyValueContent.Values.FirstOrDefault().ToString() + "&";
                url += "DO" + "=" + dovalue + "&naziv=" + keyValueContent.Values.LastOrDefault().ToString();

            }

            var result = url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result.Result;
        }

        public async Task<T> GetNoviProizvod<T>()
        {
            var url = $"{_apiUrl}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetSveProizvode<T>(int id)
        {
            var url = $"{_apiUrl}/{_route}/GetSveProizvode/{id}";
            
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetPreporuke<T>(string korisnik)
        {
            var url = $"{_apiUrl}/{_route}/{korisnik}/GetPreporuke";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetUloge<T>()
        {
            var url = $"{_apiUrl}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public T GetNarudzbaDetalji<T>(object idnarudzbe)
        {
            var url = $"{_apiUrl}/{_route}/{idnarudzbe}";

            var result = url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result.Result;
        }

        public T GetNarudzbaStatus<T>(object idnarudzbestatus)
        {
            var url = $"{_apiUrl}/{_route}/";
            url += $"GetNarudzbaStatus/{idnarudzbestatus}";

            var result = url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result.Result;
        }

        public async Task<T> GetByStatus<T>(object status)
        {
            var url = $"{_apiUrl}/{_route}/{status}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetDetaljiProizvoda<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public T GetNarudzbu<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            var result = url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result.Result;
        }

        public T GetStatusNarudzbe<T>(object idnarudzbe)
        {
            var url = $"{_apiUrl}/{_route}/";
            url += $"GetStatusNarudzbe/{idnarudzbe}";
            var result = url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result.Result;
        }

        public T PromjenaStatusa<T>(object obj)
        {
            var url = $"{_apiUrl}/{_route}";
            var result = url.WithBasicAuth(Username, Password).PatchJsonAsync(obj).ReceiveJson<T>();

            return result.Result;
        }

        public async Task<T> OcijeniProizvod<T>(object obj)
        {
            var url = $"{_apiUrl}/{_route}/OcijeniProizvod";
            var result = await url.WithBasicAuth(Username, Password).PatchJsonAsync(obj).ReceiveJson<T>();

            return result;
        }

        public T PromjenaStatusaNarudzbe<T>(object obj)
        {
            var url = $"{_apiUrl}/{_route}";
            var result = url.WithBasicAuth(Username, Password).PatchJsonAsync(obj).ReceiveJson<T>();

            return result.Result;
        }

        public T UrediNarudzbu<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

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
            var result = url.WithBasicAuth(Username, Password).PatchJsonAsync(search).ReceiveJson<T>();

            return result.Result;
        }

        public T Insert<T>(object objectt)
        {
            var url = $"{_apiUrl}/{_route}";

            var result = url.WithBasicAuth(Username, Password).PostJsonAsync(objectt).ReceiveJson<T>();

            return result.Result;
        }

        public T IzbrisiNarudzbu<T>(int id)
        {
            var url = $"{_apiUrl}/{_route}";
            url += "?id=" + id;

            var result = url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();

            return result.Result;
        }

        public async Task<T> InsertNovogProizvoda<T>(object objectt)
        {
            var url = $"{_apiUrl}/{_route}";

            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(objectt).ReceiveJson<T>();

            return result;
        }
    }
}
