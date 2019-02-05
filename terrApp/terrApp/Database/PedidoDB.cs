using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using terrApp.Model;

namespace terrApp.Database
{
    public class PedidoDB
    {
        readonly SQLiteAsyncConnection database;

        public PedidoDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Pedido>().Wait();
        }

        public Task<List<Pedido>> GetPedidosAsync()
        {
            return database.Table<Pedido>().ToListAsync();
        }

        public Task<Pedido> GetPedidoAsync(int ID)
        {
            return database.Table<Pedido>().Where(i => i.ID == ID).FirstOrDefaultAsync();
        }

        public Task<int> SavePedidoAsync(Pedido pedido)
        {
            if (pedido.ID != 0)
            {
                return database.UpdateAsync(pedido);
            }
            else
            {
                return database.InsertAsync(pedido);
            }
        }
    }
}
