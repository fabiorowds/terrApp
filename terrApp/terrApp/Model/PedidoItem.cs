using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace terrApp.Model
{
    public class PedidoItem
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public int IDPedido { get; set; }
        public int IDItem { get; set; }
        public decimal Quantidade { get; set; }
    }
}
