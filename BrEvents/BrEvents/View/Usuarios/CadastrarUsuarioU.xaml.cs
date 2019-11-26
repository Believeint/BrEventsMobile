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
    public partial class CadastrarUsuarioU : ContentPage
    {
        public CadastrarUsuarioU()
        {
            InitializeComponent();
        }

        async void CadastrarUsuarioBtnClicked(object sender, EventArgs e)
        {
            var usuario = new Usuario()
            {
                NomeUsuario = entUsuario.Text,
                Senha = entSenha.Text,
                Nome = entNome.Text,
                Sobrenome = entSobrenome.Text,
                Email = entEmail.Text,
                Contato = entContato.Text,
                Privilegio = 1,
                DataCadastro = DateTime.UtcNow
                
            };

            await App.DB.IncluirUsuarioAsync(usuario);
            await DisplayAlert("Alerta","Cadastro Realizado com sucesso","OK");
            await Navigation.PopToRootAsync();

            

        }
    }
}