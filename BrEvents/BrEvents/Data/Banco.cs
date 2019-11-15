using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using BrEvents.Model;

namespace BrEvents.Data
{
    public class Banco
    {
        readonly SQLiteAsyncConnection _database;
        public Banco(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            //_database.CreateTableAsync<Usuario>().Wait();
        }


    }
}
