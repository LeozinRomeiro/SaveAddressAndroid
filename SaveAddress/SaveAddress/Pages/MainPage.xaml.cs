using SaveAddress.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SaveAddress.Pages
{
    public partial class MainPage : FlyoutPage
    {
        public AbaFlyoutPage flyoutPage;
        public MainPage()
        {
            object value = InitializeComponent();
            flyoutPage = new AbaFlyoutPage();
            Flyout = flyoutPage;
            Detail = new NavigationPage(new SobrePage());
        }

        public void Navegar(ContentPage page)
        {
            Detail = new NavigationPage(page);
            IsPresented = false;
        }
    }
}
