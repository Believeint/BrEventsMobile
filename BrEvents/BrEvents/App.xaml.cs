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
        // VARIÁVEL ESTÁTICA ONDE FICARÁ ARMAZENADO A INSTÂNCIA DA CONEXÃO
        static Banco banco;

        // METODO ACESSOR DA VARIÁVEL banco
        public static Banco DB
        {
            // CRIAÇÃO DO BANCO banco.db3, RETORNA SE JÁ EXISTIR 
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
            // SETA HORARIO E DATA PARA PORTUGUÊS BRASIL
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            // REDIRECIONA PARA A PAGINA DE LOGIN
            MainPage = new NavigationPage(new Login());

     
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
