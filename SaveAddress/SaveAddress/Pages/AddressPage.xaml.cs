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
            string Nome = "";
            //if (txtNota.Text != null) Nome = txtNota.Text;
            var teste = dataBase.Procurar(Nome);
            ListAddress.ItemsSource = teste;
            DisplayAlert("Teste", teste.ToString(), "Ok");
        }

        private void ListAddress_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Localizacao localizacao = (Localizacao)ListAddress.SelectedItem;
        }
    }
}