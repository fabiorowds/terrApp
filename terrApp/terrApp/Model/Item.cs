using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace terrApp.Model
{
    public class Item
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public byte[] Imagem { get; set; }
        public int IDUsuario { get; set; }
    }
}
