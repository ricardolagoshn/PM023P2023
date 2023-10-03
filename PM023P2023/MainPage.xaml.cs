using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM023P2023
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnproceso_Clicked(object sender, EventArgs e)
        {
            Models.Personas person = new Models.Personas
            {
                nombres= txtnombre.Text,
                apellidos = txtapellido.Text,
                telefono = Convert.ToInt32(txttelefono.Text)
            };

            var PageResult = new Views.PageResult();
            PageResult.BindingContext = person;
            await Navigation.PushAsync(PageResult);
        }
    }
}
