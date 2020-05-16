using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using BrEvents.Model;
using System.Threading.Tasks;

namespace BrEvents.Data
{
    // CLASSE BANCO DE DADOS SQLITE
    public class Banco
    {
        // INSTÂNCIA DA CLASSE
        readonly SQLiteAsyncConnection _database;

        // CONSTRUTOR DA CLASSE, AO ENTRAR NO CONSTRUTOR CRIA AS TABELAS USUARIO E EVENTO
        public Banco(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Usuario>().Wait();
            _database.CreateTableAsync<Evento>().Wait();
        }


        #region "Metodos Usuario"
        // RETORNA TODOS OS USUÁRIOS DA TABELA USUARIO
        public Task<List<Usuario>> GetUsuariosAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        // RETORNA USUÁRIO ESPECÍFICO DA TABELA USUARIO
        public Task<Usuario> GetUsuarioAsync(int id)
        {
            return _database.Table<Usuario>()
                            .Where(u => u.IdUsuario == id).FirstOrDefaultAsync();
        }

        // INCLUI USUÁRIO NA TABELA USUARIO
        public Task<int> IncluirUsuarioAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }

        // EDITA USUÁRIO DA TABELA USUARIO
        public Task<int> EditarUsuarioAsync(Usuario usuario)
        {
            return _database.UpdateAsync(usuario);
        }

        // DELETA USUÁRIO DA TABELA USUARIO
        public Task<int> DeleteUsuarioAsync(Usuario usuario)
        {
            return _database.DeleteAsync(usuario);
        }

        #endregion

        #region "Metodos Evento"

        // RETORNA TODOS OS EVENTOS DA TABELA EVENTO
        public Task<List<Evento>> GetEventosAsync()
        {
            return _database.Table<Evento>().ToListAsync();
        }

        // RETORNA EVENTO ESPECÍFICO DA TABELA EVENTO
        public Task<Evento> GetEventoAsync(int id)
        {
            return _database.Table<Evento>()
                            .Where(e => e.IdEvento == id)
                            .FirstOrDefaultAsync();
        }

        // INCLUI EVENTO NA TABELA EVENTO
        public Task<int> InserirEventoAsync(Evento evento)
        {
            return _database.InsertAsync(evento);
        }

        // EDITA EVENTO NA TABELA EVENTO
        public Task<int> EditarEventoAsync(Evento evento)
        {       
            return _database.UpdateAsync(evento);
        }

        // DELETA EVENTOS DA TABELA EVENTO
        public Task<int> DeletarEventoAsync(Evento evento)
        {
            return _database.DeleteAsync(evento);
        }

        #endregion


       


    }

}
