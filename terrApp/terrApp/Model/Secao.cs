using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace terrApp.Model
{
    public class Secao
    {
        [PrimaryKey]
        public int ID { get; set; }
        public int IDUsuario { get; set; }
        public bool ManterLogado { get; set; }
    }
}
