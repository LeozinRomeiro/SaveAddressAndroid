using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveAddress.DataBase;
using Xamarin.Forms;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using SaveAddress.DataBase.TabelaModelos;
using Xamarin.Essentials;
using static System.Net.Mime.MediaTypeNames;

namespace SaveAddress.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        DataBaseClass DataBaseClass=new DataBaseClass(App.DataBaseCaminho);
		public HomePage()
		{
			InitializeComponent();
            DisplayAlert("Teste", "teste", "Ok");
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        public async void SalvarLocalizacao()
		{
            try
            {
                var coordenadas = await Geolocation.GetLastKnownLocationAsync();
                
                Localizacao localizacao = new Localizacao();
                localizacao.Longitude = coordenadas.Longitude;
                localizacao.Latitude = coordenadas.Latitude;
                //localizacao.Latitude = -23.451808;
                //localizacao.Longitude = -52.036737;
                DataBaseClass.Inserir(localizacao);
                await DisplayAlert("Teste", localizacao.Nome, "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Falhou", ex.Message, "OK");
            }


        }

        private void Salvar_Clicked(object sender, EventArgs e)
        {
            SalvarLocalizacao();
            
        }
    }
}