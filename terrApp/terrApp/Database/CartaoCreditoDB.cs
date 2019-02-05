using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using terrApp.Model;

namespace terrApp.Database
{
    public class CartaoCreditoDB
    {
        readonly SQLiteAsyncConnection database;

        public CartaoCreditoDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<CartaoCredito>().Wait();
        }

        public Task<List<CartaoCredito>> GetCartaoCreditosAsync()
        {
            return database.Table<CartaoCredito>().ToListAsync();
        }

        public Task<CartaoCredito> GetCartaoCreditoAsync(int ID)
        {
            return database.Table<CartaoCredito>().Where(i => i.ID == ID).FirstOrDefaultAsync();
        }

        public Task<int> SaveSecaoAsync(CartaoCredito cartaoCredito)
        {
            if (cartaoCredito.ID != 0)
            {
                return database.UpdateAsync(cartaoCredito);
            }
            else
            {
                return database.InsertAsync(cartaoCredito);
            }
        }
    }
}
