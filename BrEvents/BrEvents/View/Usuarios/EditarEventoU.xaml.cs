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

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();

        //    var evento = await App.DB.GetEventoAsync(7);
        //    BindingContext = evento;
        //}


        async void EditarEvento(object sender, EventArgs e)
        {
            var evento = (Evento)BindingContext;

            evento.Nome = entNome.Text;
            evento.Descricao = entDescricao.Text;
            evento.Detalhe = entDetalhe.Text;
            evento.DataInicio = dtpDtInicio.Date;
            evento.DataFim = dtpDtFim.Date;
            evento.Custo = float.Parse(entCusto.Text);
            evento.Local = entLocal.Text;
            evento.Endereco = entEndereco.Text;
            evento.CapacidadeMaxima = int.Parse(entCapMaxima.Text);
            evento.CaminhoImagem = entCamImagem.Text;
            

            await App.DB.EditarEventoAsync(evento);
            await DisplayAlert("Alerta","Evento Atualizado com sucesso"," OK");
            await Navigation.PopToRootAsync();
        }
    }
}