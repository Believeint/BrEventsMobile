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
    public partial class EditarEventoU : ContentPage
    {
        public EditarEventoU()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var evento = await App.DB.GetEventoAsync(7);
            BindingContext = evento;
        }


        async void EditarEvento(object sender, EventArgs e)
        {
            var evento = new Evento()
            {
                Nome = entNome.Text,
                Descricao = entDescricao.Text,
                Detalhe = entDetalhe.Text,
                DataInicio = dtpDtInicio.Date,
                DataFim = dtpDtFim.Date,
                Custo = float.Parse(entCusto.Text),
                Local = entLocal.Text,
                Endereco = entEndereco.Text,
                CapacidadeMaxima = int.Parse(entCapMaxima.Text),
                CaminhoImagem = entCamImagem.Text
            };

            await App.DB.EditarEventoAsync(evento);
            await DisplayAlert("Alerta","Evento Atualizado com sucesso"," OK");
            await Navigation.PopAsync();
        }
    }
}