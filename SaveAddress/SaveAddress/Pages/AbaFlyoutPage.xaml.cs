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
    public partial class AbaFlyoutPage : ContentPage
    {
        public AbaFlyoutPage()
        {
            InitializeComponent();
        }

        private void botao_enderecos_Clicked(object sender, EventArgs e)
        {
            ((MainPage)Application.Current.MainPage).Navegar(new AddressPage());
        }

        private void botao_home_Clicked(object sender, EventArgs e)
        {
            ((MainPage)Application.Current.MainPage).Navegar(new HomePage());
        }
    }
}