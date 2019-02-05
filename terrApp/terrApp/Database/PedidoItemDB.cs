using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using terrApp.Model;

namespace terrApp.Database
{
    public class PedidoItemDB
    {
        readonly SQLiteAsyncConnection database;

        public PedidoItemDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<PedidoItem>().Wait();
        }

        public Task<List<PedidoItem>> GetPedidoItemsAsync()
        {
            return database.Table<PedidoItem>().ToListAsync();
        }

        public Task<PedidoItem> GetPedidoItemAsync(int ID)
        {
            return database.Table<PedidoItem>().Where(i => i.ID == ID).FirstOrDefaultAsync();
        }

        public Task<int> SavePedidoItemAsync(PedidoItem PedidoItem)
        {
            if (PedidoItem.ID != 0)
            {
                return database.UpdateAsync(PedidoItem);
            }
            else
            {
                return database.InsertAsync(PedidoItem);
            }
        }
    }
}
