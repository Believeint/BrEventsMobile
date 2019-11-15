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
        public int Descricao { get; set; }
        public int DataInicio { get; set; }
        public int DataFim { get; set; }
        public int Custo { get; set; }
        public int Local { get; set; }
        public int Endereco { get; set; }
        public int CapacidadeMaxima { get; set; }
    }
}
