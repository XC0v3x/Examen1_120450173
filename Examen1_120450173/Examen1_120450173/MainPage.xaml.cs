using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Examen1_120450173.View;

namespace Examen1_120450173
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BTNmainform_Pressed(object sender, EventArgs e)
        {
            await DisplayAlert("Alerta de prueba","Porque no carga","???");
            await Navigation.PushAsync(new ContactosView());
        }
    }
}
