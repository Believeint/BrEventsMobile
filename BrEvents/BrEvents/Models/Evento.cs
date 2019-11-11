using System;
using System.Collections.Generic;
using System.Text;

namespace BrEvents.Models
{
    class Evento
    {
        public int IDEvento { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }
    }
}
