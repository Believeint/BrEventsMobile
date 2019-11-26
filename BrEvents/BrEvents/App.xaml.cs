using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BrEvents.Data;
using System.IO;
using BrEvents.View;
using System.Threading;
using System.Globalization;

namespace BrEvents
{

    public partial class App : Application
    {
        static Banco banco;
        public static Banco DB
        {
            get
            {
                if(banco == null)
                {
                    banco = new Banco(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "banco.db3"));
                }
                return banco;
            }
        }
        public App()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            //MainPage = new NavigationPage(new View.Usuarios.CadastrarEventoU());
            //MainPage = new NavigationPage(new Login());
            //MainPage = new View.Usuarios.CadastrarUsuarioU();
            MainPage = new View.Usuarios.ListarUsuariosU();
     
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
