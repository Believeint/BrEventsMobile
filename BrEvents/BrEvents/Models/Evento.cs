using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BrEvents.Models
{
    class Evento
    {
        [PrimaryKey, AutoIncrement]
        public int IDEvento { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
    }
}
