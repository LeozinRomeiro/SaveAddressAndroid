using SaveAddress.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SaveAddress.Pages
{
    public partial class MainPage : FlyoutPage
    {
        public AbaFlyoutPage flyoutPage;
        public MainPage()
        {
            InitializeComponent();
            flyoutPage = new AbaFlyoutPage();
            Flyout = flyoutPage;
            Detail = new NavigationPage(new HomePage());
        }

        public void Navegar(ContentPage page)
        {
            Detail = new NavigationPage(page);
            IsPresented = false;
        }
        public Task<Location> Localizar()
        {
            return Geolocation.GetLocationAsync(new GeolocationRequest()
            { DesiredAccuracy = GeolocationAccuracy.Best });
        }
        public async Task Mostrar()
        {
            var localizacao = await Localizar();
            var localizacao_info = new Location(localizacao.Latitude, localizacao.Longitude);
            var opcao = new MapLaunchOptions();
            opcao.Name += "Meu local";
            await Map.OpenAsync(localizacao_info, opcao);
        }
        
    }
}
