using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace terrApp.Model
{
    public class Usuario
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string IdnVendedor { get; set; }
        public int IDCartao { get; set; }
    }
}
