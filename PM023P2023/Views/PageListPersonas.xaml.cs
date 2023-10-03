﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM023P2023.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListPersonas : ContentPage
    {
        public PageListPersonas()
        {
            InitializeComponent();
        }

        private async void tooladd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PagePersonas());
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            list.ItemsSource = await App.Instancia.listPersonas();
        }
    }
}