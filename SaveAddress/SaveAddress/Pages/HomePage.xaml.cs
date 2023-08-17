using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveAddress.DataBase;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SaveAddress.DataBase.TabelaModelos;

namespace SaveAddress.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        DataBaseClass DataBaseClass=new DataBaseClass(App.DataBaseCaminho);
        public HomePage (Localizacao localizacao)
		{
			InitializeComponent ();
            
        }
	}
}