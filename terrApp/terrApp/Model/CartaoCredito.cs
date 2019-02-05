using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace terrApp.Model
{
    public class CartaoCredito
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Numero { get; set; }
        public string Vencimento { get; set; }
        public int CVV { get; set; }
        public string NomeTitular { get; set; }
    }
}
