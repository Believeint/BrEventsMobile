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
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
    }
}
