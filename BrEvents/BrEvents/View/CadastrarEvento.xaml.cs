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
    public partial class CadastrarEvento : ContentPage
    {
        public CadastrarEvento()
        {
            InitializeComponent();

        }

        async void AddEvento(object sender, EventArgs e)
        {
            var evento = new Evento()
            { 
                Nome = entNome.Text,
                Descricao = entDescricao.Text,
                DataInicio = dtpDtInicio.Date,
                DataFim = dtpDtFim.Date,
                Custo = float.Parse(entCusto.Text),
                Local = entLocal.Text,
                Endereco = entEndereco.Text,
                CapacidadeMaxima = int.Parse(entCapMaxima.Text),
                CaminhoImagem = entCamImagem.Text
            };


          

            await App.DB.InserirEventoAsync(evento);
            await Navigation.PopAsync();

        }
    }
}