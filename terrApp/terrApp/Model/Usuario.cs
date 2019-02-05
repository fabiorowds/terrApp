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
        public string Senha { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public string CPF { get; set; }
        public int IDCartao { get; set; }
    }
}
