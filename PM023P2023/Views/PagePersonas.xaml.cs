using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM023P2023.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePersonas : ContentPage
    {
        public PagePersonas()
        {
            InitializeComponent();
        }

        private async void btnproceso_Clicked(object sender, EventArgs e)
        {
            var person = new Models.Personas
            {
                nombres = txtnombre.Text,
                apellidos = txtapellido.Text,
                fechanac = fechanac.Date,
                telefono = Convert.ToInt32(txttelefono.Text),
                foto = null
            };

            if (await App.Instancia.addPerson(person) > 0)
            {
                await DisplayAlert("Aviso", "Persona Agregada", "OK");
            }
            else
            {
                await DisplayAlert("Alerta", "Ocurrio un error", "OK");
           }
        }
    }
}