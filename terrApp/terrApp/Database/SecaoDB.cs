using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using terrApp.Model;

namespace terrApp.Database
{

    public class SecaoDB
    {
        readonly SQLiteAsyncConnection database;

        public SecaoDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Secao>().Wait();
        }

        public Task<Secao> GetSecaoAsync()
        {
            return database.Table<Secao>().FirstOrDefaultAsync();
        }

        public Task<int> SaveSecaoAsync(Secao secao)
        {
            if (secao.ID != 0)
            {
                return database.UpdateAsync(secao);
            }
            else
            {
                return database.InsertAsync(secao);
            }
        }
    }
}
