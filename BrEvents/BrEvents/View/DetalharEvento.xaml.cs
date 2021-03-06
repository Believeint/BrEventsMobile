﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrEvents.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalharEvento : ContentPage
    {
        public DetalharEvento()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(txtCusto.Detail == "0")
            {
                txtCusto.Detail = "Evento Gratuito";
                txtCusto.DetailColor = Color.Red;
            }
        }
    }
}