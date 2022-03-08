using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Examen1_120450173.Controller;
using System.IO;
using Examen1_120450173.View;

namespace Examen1_120450173
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DB.conexion(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DBPR3"));

            MainPage = new ContactosAdd();
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
