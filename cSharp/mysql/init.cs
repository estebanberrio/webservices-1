using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ws.mysql
{
    // clase para la tabla INIT
    public class Init
    {
        public short Idcompania { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Token { get; set; }

        public Init() { }

        public Init(short Idcompania, string Usuario, string Contrasena, string Token)
        {
            this.Idcompania = Idcompania;
            this.Usuario = Usuario;
            this.Contrasena = Contrasena;
            this.Token = Token;            
        }
    }
}
