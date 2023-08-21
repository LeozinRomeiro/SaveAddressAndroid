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
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        public async void SalvarLocalizacao()
		{
           


        }

        async void Salvar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var coordenadas = await Geolocation.GetLocationAsync(new GeolocationRequest()
                { DesiredAccuracy = GeolocationAccuracy.Best });

                Localizacao localizacao = new Localizacao();
                localizacao.Longitude = coordenadas.Longitude;
                localizacao.Latitude = coordenadas.Latitude;
                localizacao.Nome = textoNome.Text;
                //localizacao.Latitude = -23.451808;
                //localizacao.Longitude = -52.036737;
                DataBaseClass.Inserir(localizacao);
                await DisplayAlert("Sucesso!", "Seu endereço "+localizacao.Nome+" foi adicionado com sucesso.", "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Falhou", ex.Message, "OK");
            }
        }
    }
}