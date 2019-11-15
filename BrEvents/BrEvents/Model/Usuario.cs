using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BrEvents.Model
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int IdUsuario { get; set; }
        public string Senha { get; set; }
        public int Privilegio { get; set; }
        public string nome { get; set; }
        public string Sobrenome { get; set; }
        public string email { get; set; }
        public string contato { get; set; }
    }
}
