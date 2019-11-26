using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrEvents.View.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarUsuariosU : ContentPage
    {
        public ListarUsuariosU()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var usuarios = await App.DB.GetUsuariosAsync();

            lvwUsuarios.ItemsSource = usuarios;
        }
    }
}