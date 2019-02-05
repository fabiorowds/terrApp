using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using terrApp.Model;

namespace terrApp.Database
{
    public class UsuarioDB
    {
        readonly SQLiteAsyncConnection database;

        public UsuarioDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Usuario>().Wait();
        }

        public Task<List<Usuario>> GetUsuariosAsync()
        {
            return database.Table<Usuario>().ToListAsync();
        }

        public Task<Usuario> GetUsuarioAsync(int ID)
        {
            return database.Table<Usuario>().Where(i => i.ID == ID).FirstOrDefaultAsync();
        }

        public Task<int> SaveUsuarioAsync(Usuario usuario)
        {
            if (usuario.ID != 0)
            {
                return database.UpdateAsync(usuario);
            }
            else
            {
                return database.InsertAsync(usuario);
            }
        } 

    }
}
