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
            var evento = new Evento();
            evento.Nome = entNome.Text;
            evento.Descricao = entDescricao.Text;
            evento.DataInicio = dtpDtInicio.Date;
            evento.DataFim = dtpDtFim.Date;
            evento.Custo = float.Parse(entCusto.Text);
            evento.Local = entLocal.Text;
            evento.Endereco = entEndereco.Text;
            evento.CapacidadeMaxima = int.Parse(entCapMaxima.Text);
            evento.CaminhoImagem = entCamImagem.Text.ToString();

            await App.DB.InserirEventoAsync(evento);
            await Navigation.PopAsync();

        }
    }
}