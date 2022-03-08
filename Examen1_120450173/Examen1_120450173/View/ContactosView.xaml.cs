using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen1_120450173.Controller;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1_120450173.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactosView : ContentPage
    {
        public ContactosView()
        {
            InitializeComponent();
        }

        private void listacontactos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Model.Contactos cont = (Model.Contactos)e.CurrentSelection.FirstOrDefault();
            }
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactosAdd());
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listacontactos.ItemsSource = await ContactosController.ObtenerContactos();
        }
    }
}