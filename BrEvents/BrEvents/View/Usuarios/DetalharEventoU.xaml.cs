using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrEvents.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrEvents.View.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalharEventoU : ContentPage
    {
        public DetalharEventoU()
        {
            InitializeComponent();
        }

        async void EditarEventoUPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditarEventoU() { BindingContext = BindingContext });
        }

        async void ExcluirEventoUPage(object sender, EventArgs e)
        {
            var evento = (Evento)BindingContext;
            await App.DB.DeletarEventoAsync(evento);
            await Navigation.PopAsync();
        }
    }
}