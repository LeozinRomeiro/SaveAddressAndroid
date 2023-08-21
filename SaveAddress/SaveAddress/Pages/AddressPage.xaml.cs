using SaveAddress.DataBase;
using SaveAddress.DataBase.TabelaModelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaveAddress.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressPage : ContentPage
    {
        DataBaseClass dataBase = new DataBaseClass(App.DataBaseCaminho);
        public AddressPage()
        {
            InitializeComponent();
            AtualizaLista();
            
        }

        public void AtualizaLista()
        {
            string nome = "";
            if (textobuscado.Text != null) nome = textobuscado.Text;
            ListAddress.ItemsSource = dataBase.Procurar(nome);
            //DisplayAlert("Teste", teste.ToString(), "Ok");
        }

        private async void ListAddress_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Localizacao localizacao = (Localizacao)ListAddress.SelectedItem;
            await ((MainPage)Application.Current.MainPage).Mostrar(localizacao);
        }

        private void mapa_Clicked(object sender, EventArgs e)
        {

        }

        private void editar_Clicked(object sender, EventArgs e)
        {

        }

        private void Procurar_Clicked(object sender, EventArgs e)
        {
            string nome = textobuscado.Text;
            ListAddress.ItemsSource = dataBase.Procurar(nome);
        }
    }
}