using MobileApps.ViewModels;
using MobileApps.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileApps
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public static bool _pokreni { get; set; }
        public AppShell(bool pokreni)
        {
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(ProizvodiMainVM), typeof(ProizvodiMainVM));
            _pokreni = pokreni;
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
        public bool GetStatus()
        {
            return _pokreni;
        }
    }
}
