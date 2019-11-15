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
        public int Senha { get; set; }
        public int Privilegio { get; set; }
        public int nome { get; set; }
        public int Sobrenome { get; set; }
        public int email { get; set; }
        public int contato { get; set; }
    }
}
