using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BrEvents.Models
{
    class Localizacao
    {
        [PrimaryKey, AutoIncrement]
        public int IDLocalizacao { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string NomeDoOrganizador { get; set; }
        public string SobrenomeDoOrganizador { get; set; }
        public string ContatoOrganizador { get; set; }
        public string CapMaxima { get; set; }
    }
}
