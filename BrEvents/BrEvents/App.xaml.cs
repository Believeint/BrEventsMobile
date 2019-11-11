using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BrEvents.Models;
using System.IO;

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

            MainPage = new MainPage();
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
