using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrEvents.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarEventos : ContentPage
    {
        public ListarEventos()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var eventos = await App.DB.GetEventosAsync();

            lvwUsuarios.ItemsSource = eventos;
        }

        async void NavAddEvento(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarEvento());
        }
    }
}