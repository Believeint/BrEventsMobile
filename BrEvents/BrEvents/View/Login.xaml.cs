using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrEvents.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrEvents.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void NavListarEventos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListarEventos());
            //App.Current.MainPage = new NavigationPage(new ListarEventos());
            //await Navigation.PushAsync(new ListarEventos());
        }

        async void WelcomePage(object sender, EventArgs e)
        {
            //var usuario = new Usuario() { Nome = entUsuario.Text, Senha = entSenha.Text };
            //if(!string.IsNullOrEmpty(entUsuario.Text) || !string.IsNullOrEmpty(entSenha.Text))
            //{
            //    if(usuario.Nome == "teste" && usuario.Senha == "123")
            //    {
            //       //await Navigation.PushAsync(new Usuarios.ListarEventosU(usuario.Nome));
            //       App.Current.MainPage = new NavigationPage(new Usuarios.ListarEventosU(usuario.Nome));
            //    }
            //    else
            //    {
            //        await DisplayAlert("Alerta", "Usuario Inexistente/Dados incorretos, Tente novamente", "OK");
            //    }
            //} 
            //else
            //{
            //    await DisplayAlert("Alerta", "Preencha os Campos", "OK");
            //} 

            var usuario = new Usuario() { NomeUsuario = entUsuario.Text, Senha = entSenha.Text };
            if(!string.IsNullOrEmpty(entUsuario.Text) || !string.IsNullOrEmpty(entSenha.Text))
            {
                List<Usuario> usuarios = await App.DB.GetUsuariosAsync();
                var u1 = usuarios.Where(x => x.NomeUsuario == usuario.NomeUsuario && x.Senha == usuario.Senha).FirstOrDefault();

                if(u1 != null)
                {
                    usuario.Nome = u1.Nome;
                    App.Current.MainPage = new NavigationPage(new Usuarios.ListarEventosU(usuario.Nome));
                }
                else
                {
                    await DisplayAlert("Alerta", "Usuario Inexistente/Dados incorretos, Tente novamente", "OK");
                }

                //for(int i = 0; i > usuarios.Count; i++)
                //{
                //    if(usuario.NomeUsuario == usuarios[i][i])
                //    {

                //    }
                //}
                
            } 
            else 
            { 
                 await DisplayAlert("Alerta", "Preencha os Campos", "OK");
            }
        }

        async void SeInscreverPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Usuarios.CadastrarUsuarioU());
        }
    }
}