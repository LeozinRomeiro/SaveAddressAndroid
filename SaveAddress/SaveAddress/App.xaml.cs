using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SaveAddress
{
    public partial class App : Application
    {
        public static string DataBaseNome;
        public static SQLiteConnection DataBaseCaminho;
        public App()
        {
            InitializeComponent();

            MainPage = new Pages.MainPage();
        }

        public App(SQLiteConnection DataBaseCaminho, string DataBaseNome)
        {
            InitializeComponent();
            App.DataBaseCaminho = DataBaseCaminho;
            App.DataBaseNome = DataBaseNome;
            MainPage = new Pages.MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
