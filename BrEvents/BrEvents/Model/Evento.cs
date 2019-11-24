using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BrEvents.Model
{
    public class Evento
    {
        [PrimaryKey, AutoIncrement]
        public int IdEvento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Detalhe { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public float Custo { get; set; }
        public string Local { get; set; }
        public string Endereco { get; set; }
        public int CapacidadeMaxima { get; set; }
        public string CaminhoImagem { get; set; }
    }
}
