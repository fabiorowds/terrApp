using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace terrApp.Model
{
    public class Pedido
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public int IDUsuario { get; set; }
        public string Status { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
