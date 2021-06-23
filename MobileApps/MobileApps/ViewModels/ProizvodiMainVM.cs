using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileApps.ViewModels
{
    public class ProizvodiMainVM : BaseViewModel
    {
        private readonly APIService _proizvodiService = new APIService("ProizvodiUpravljanje");
        private APIService _narudzbeService = new APIService("Narudzbe");
        public ProizvodiMainVM()
        {
            InitCommad = new Command(async ()=> await Init());
            SpasiCommand = new Command(async ()=> await SnimiNarudzbu());
        }
        public ObservableCollection<ProizvodiVM> ListaProizvodaHrana { get; set; } = new ObservableCollection<ProizvodiVM>();
        public ObservableCollection<ProizvodiVM> ListaProizvodaPice { get; set; } = new ObservableCollection<ProizvodiVM>();
        public ObservableCollection<ProizvodiVM> ListaPreporuka { get; set; } = new ObservableCollection<ProizvodiVM>();
        public List<int> ListaProizvodaID { get; set; } = new List<int>();
        public List<int> ListaProizvodaIDUkupna { get; set; } = new List<int>();
        public List<int> ListaKolicinaID { get; set; } = new List<int>();
        public List<int> ListaKolicinaTrenutna { get; set; } = new List<int>();
        public Kucnadostavavm _Kucnadostavavm { get; set; } = new Kucnadostavavm();
        private double _cijena { get; set; }
        public ICommand InitCommad { get; set; }
        public ICommand SpasiCommand { get; set; }

        string _ukupnacijena = "0";

        public string UkupnaCijena
        {
            get { return _ukupnacijena; }
            set { SetProperty(ref _ukupnacijena, value); }
        }

        public void SetKucnaDostava(Kucnadostavavm objekat=null)
        {
            _Kucnadostavavm = objekat;
        }
        public async Task Init()        
        {
            var lista0 = await _proizvodiService.GetPreporuke<IList<ProizvodiVM>>(APIService.Username);

            ListaPreporuka.Clear();
            foreach (var item in lista0)
            {
                ListaPreporuka.Add(item);
                ListaProizvodaIDUkupna.Add(item.ProizvodID);
            }

            var lista = await _proizvodiService.GetSveProizvode<IList<ProizvodiVM>>(1);

            ListaProizvodaHrana.Clear();
            foreach (var item in lista)
            {
                if(Postoji(item.ProizvodID,lista0)==false)
                {
                    ListaProizvodaHrana.Add(item);
                    ListaProizvodaIDUkupna.Add(item.ProizvodID);
                }
            }

            var lista1 = await _proizvodiService.GetSveProizvode<IList<ProizvodiVM>>(2);

            ListaProizvodaPice.Clear();
            foreach (var item in lista1)
            {
                if (Postoji(item.ProizvodID, lista0) == false)
                {
                    ListaProizvodaPice.Add(item);
                    ListaProizvodaIDUkupna.Add(item.ProizvodID);
                }
            }
            for (int i = 0; i < ListaProizvodaHrana.Count + ListaProizvodaPice.Count + ListaPreporuka.Count; i++)
            {
                ListaKolicinaTrenutna.Add(1);
            }
        }
        private bool Postoji(int id, IList<ProizvodiVM> obj)
        {
            foreach (var item in obj)
            {
                if (item.ProizvodID == id)
                    return true;
            }
            return false;
        }

        public void DodajProizvod(int id,int kolicina,double cijena)
        {
            ListaProizvodaID.Add(id);
            ListaKolicinaID.Add(kolicina);
            _cijena += (cijena*kolicina);
            UkupnaCijena = _cijena.ToString();
            for (int i = 0; i < ListaProizvodaIDUkupna.Count; i++)
            {
                if (id == ListaProizvodaIDUkupna[i])
                {
                    ListaKolicinaTrenutna[i] = kolicina;
                }
            }
        }

        public void IzbrisiProizvod(int id, double cijena)
        {
            List<int> temp=new List<int>();
            List<int> temp1=new List<int>();
            for (int i = 0; i < ListaProizvodaID.Count; i++)
            {
                if (id != ListaProizvodaID[i])
                {
                    temp.Add(ListaProizvodaID[i]);
                    temp1.Add(ListaKolicinaID[i]);
                }
                else
                 _cijena -= (cijena* ListaKolicinaID[i]);
            }
            ListaProizvodaID = temp;
            ListaKolicinaID = temp1;
            UkupnaCijena = _cijena.ToString();

        }

        public void PromijeniKolicinu(int idproizvoda, int kolicina, double cijena)
        {
            for (int i = 0; i < ListaProizvodaID.Count; i++)
            {
                if (idproizvoda == ListaProizvodaID[i])
                {
                    if((kolicina- ListaKolicinaID[i]) > 0)
                    {
                        _cijena += (cijena * (kolicina - ListaKolicinaID[i]));
                    }
                    else
                    {
                        _cijena -= (cijena * (ListaKolicinaID[i] - kolicina));
                    }
                    ListaKolicinaID[i] = kolicina;
                }
            }
            UkupnaCijena = _cijena.ToString();
            for (int i = 0; i < ListaProizvodaIDUkupna.Count; i++)
            {
                if (idproizvoda == ListaProizvodaIDUkupna[i])
                {
                    ListaKolicinaTrenutna[i] = kolicina;
                }
            }
        }

        public async Task SnimiNarudzbu()
        {
            string username=APIService.Username;
            
            string narudzbanaziv = username + "_NovaNarudzba_"+ListaProizvodaID.Count.ToString();
            NarudzbaDetalji narudzbaDetalji = new NarudzbaDetalji{
                Cijena = _cijena,
                Količina=ListaProizvodaID.Count.ToString()
            };
            NovaNarudzba nova = new NovaNarudzba();
            nova.UserName = username;
            nova.NazivNarudzbe = narudzbanaziv;
            nova.ListaProizvodID = ListaProizvodaID;
            nova.ListaKolicina = ListaKolicinaID;
            nova.MjestoPosluzivanja = username;
            nova.Status = "Na čekanju";
            nova.VrijemeKreiranja = DateTime.Now;
            nova.Detalji = narudzbaDetalji;
            if(_Kucnadostavavm!=null)
            {
                nova.KucnaDostava = _Kucnadostavavm;
            }
            await _narudzbeService.DodajNarudzbu<NovaNarudzba>(nova);

            await Application.Current.MainPage.DisplayAlert("Nova narudžba", "Uspješno ste dodali novu narudžbu!", "OK");
            
            Application.Current.MainPage = new AppShell(true);
        }

        public int GetKolicina(int id)
        {
            int kolicina = 0;
            for (int i = 0; i < ListaProizvodaIDUkupna.Count; i++)
            {
                if (ListaProizvodaIDUkupna[i] == id)
                    kolicina= ListaKolicinaTrenutna[i];
            }
            return kolicina;
        }

        public List<Narudzba> GetNarudzbeBezNotifikacije() {
            List<Narudzba> model = _narudzbeService.GetBezNotifikacije<List<Narudzba>>(APIService.Username);
            return model;
        }
    }
}
