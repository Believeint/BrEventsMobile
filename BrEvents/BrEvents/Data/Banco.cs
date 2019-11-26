using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using BrEvents.Model;
using System.Threading.Tasks;

namespace BrEvents.Data
{
    public class Banco
    {
        readonly SQLiteAsyncConnection _database;
        public Banco(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Usuario>().Wait();
            _database.CreateTableAsync<Evento>().Wait();
        }


        #region "Metodos Usuario"
        public Task<List<Usuario>> GetUsuariosAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        public Task<Usuario> GetUsuarioAsync(int id)
        {
            return _database.Table<Usuario>()
                            .Where(u => u.IdUsuario == id).FirstOrDefaultAsync();
        }

        public Task<int> IncluirUsuarioAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }

        public Task<int> EditarUsuarioAsync(Usuario usuario)
        {
            return _database.UpdateAsync(usuario);
        }

        public Task<int> DeleteUsuarioAsync(Usuario usuario)
        {
            return _database.DeleteAsync(usuario);
        }

        #endregion

        #region "Metodos Evento"

        public Task<List<Evento>> GetEventosAsync()
        {
            return _database.Table<Evento>().ToListAsync();
        }

        public Task<Evento> GetEventoAsync(int id)
        {
            return _database.Table<Evento>()
                            .Where(e => e.IdEvento == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> InserirEventoAsync(Evento evento)
        {
            return _database.InsertAsync(evento);
        }

        public Task<int> EditarEventoAsync(Evento evento)
        {       
            return _database.UpdateAsync(evento);
        }

        public Task<int> DeletarEventoAsync(Evento evento)
        {
            return _database.DeleteAsync(evento);
        }

        #endregion


        #region "Métodos Usuário"
        public Task<List<Usuario>> GetUsuariosAsyncc()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        public Task<int> InserirUsuarioAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }

        public Task<int> DeletarUsuarioAsync(Usuario usuario)
        {
            return _database.DeleteAsync(usuario);
        }

        public Task<int> EditarUsuarioAsyncc(Usuario usuario)
        {
            return _database.UpdateAsync(usuario);
        }


        #endregion



    }

}
