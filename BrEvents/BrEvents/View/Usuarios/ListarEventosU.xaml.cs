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
    public partial class ListarEventosU : ContentPage
    {
        List<Evento> eventos = new List<Evento>();
        public ListarEventosU(string usuario)
        {
           InitializeComponent();
            _ = Initialize(usuario);

  
        }

        public async Task Initialize(string usuario)
        {
            eventos = await App.DB.GetEventosAsync();
            var u = new Usuario() { Nome = usuario };

            lvwUsuarios.ItemsSource = eventos;
            BindingContext = u;

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            eventos = await App.DB.GetEventosAsync();
            lvwUsuarios.ItemsSource = eventos;

            if (eventos.Count() > 0)
            {
                lvwUsuarios.ItemsSource = eventos;
            }
            else
            {
                lblMessage.IsVisible = true;
                lblMessage.Text = "Não encontramos eventos, Seja o primeiro a criar.";
            }
        }

        async void NavAddEvento(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastrarEventoU());
        }


        async void DetalharEventoUPage(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new DetalharEventoU() { BindingContext = e.Item as Evento });
        }

         async void SairBtnClicked(object sender, EventArgs e)
         {
            await DisplayAlert("Alerta","Sessão encerrada","OK");
            App.Current.MainPage = new Login();
         }

        
    }
}