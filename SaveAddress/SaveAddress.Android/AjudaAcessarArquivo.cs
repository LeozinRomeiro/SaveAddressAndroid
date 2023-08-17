using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
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
        public static string LerLocalArquivoDataBase(string arquivo)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, arquivo);
        }

    }
}