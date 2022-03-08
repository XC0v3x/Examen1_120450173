using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Examen1_120450173.Model;
using Examen1_120450173.Controller;
using System.IO;
using System.Threading;

namespace Examen1_120450173.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactosAdd : ContentPage
    {
        public ContactosAdd()
        {
            InitializeComponent();
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            if (nombre.Text == "")
            {
                await DisplayAlert("Aviso","Campo Nombre vacio porfavor llenarlo","Ok");
                return;
            }else if (apellido.Text == "")
            {
                await DisplayAlert("Aviso", "Campo Apellido vacio porfavor llenarlo", "Ok");
                return;
            }else if (edad.Text == "")
            {
                await DisplayAlert("Aviso", "Campo Edad vacio porfavor llenarlo", "Ok");
                return;
            }
            
            
                var cont = new Contactos();
                {
                    cont.Nombres = nombre.Text;
                    cont.Apellidos = apellido.Text;
                    cont.Edad = Convert.ToInt32(edad.Text);
                    cont.Pais = pais.SelectedIndex.ToString();
                    cont.Nota = notas.Text;
                    cont.Latitud = Convert.ToDouble(latitud.Text);
                    cont.Longitud = Convert.ToDouble(longitud.Text);
                };

            if (await ContactosController.AddRecord(cont) > 0)
                await DisplayAlert("Aviso", "Registro Adicionado", "Ok");
            else
                await DisplayAlert("Aviso","Error Transaccion Incompleta","Ok");
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            CancellationTokenSource cts;

            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    latitud.Text = Convert.ToString(location.Latitude);
                    longitud.Text = Convert.ToString(location.Longitude);
                }
                else
                {
                    var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                    cts = new CancellationTokenSource();
                    location = await Geolocation.GetLocationAsync(request, cts.Token);

                    if (location != null)
                    {
                        latitud.Text = Convert.ToString(location.Latitude);
                        longitud.Text = Convert.ToString(location.Longitude);
                    }
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                fnsEx.ToString();
                // Handle not supported on device exception
            }
        }

    }
}