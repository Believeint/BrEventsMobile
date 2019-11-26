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
    public partial class CadastrarEventoU : ContentPage
    {
        public CadastrarEventoU()
        {
            InitializeComponent();
        }

        async void AddEvento(object sender, EventArgs e)
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




            await App.DB.InserirEventoAsync(evento);
            await DisplayAlert("Alerta", "Evento cadastrado com sucesso", "OK");
            await Navigation.PopAsync();

        }
    }
}