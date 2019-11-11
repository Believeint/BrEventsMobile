using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BrEvents.Models
{
    class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int IDUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
    }
}
