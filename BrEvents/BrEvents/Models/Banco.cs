using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace BrEvents.Models
{
    public class Banco
    {
        readonly SQLiteAsyncConnection _banco;

        public Banco(string strPath)
        {
            _banco = new SQLiteAsyncConnection(strPath);
            _banco.CreateTableAsync<Usuario>().Wait();
            _banco.CreateTableAsync<Evento>().Wait();
            _banco.CreateTableAsync<Usuario>().Wait();
            _banco.CreateTableAsync<Usuario>().Wait();
        }
    }
}
