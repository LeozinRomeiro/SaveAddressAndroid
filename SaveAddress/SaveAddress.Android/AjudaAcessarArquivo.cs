using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Xamarin.Forms;

namespace SaveAddress.Droid
{
    public class AjudaAcessarArquivo
    {
        public static SQLiteConnection LerLocalArquivoDataBase(string arquivo)
        {
            string caminho = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            SQLiteConnection path = new SQLiteConnection(System.IO.Path.Combine(caminho, arquivo));
            return path;
        }

    }
}