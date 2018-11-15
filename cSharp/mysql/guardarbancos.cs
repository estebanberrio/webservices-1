using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ws.mysql
{
    // clase para la tabla guardarbancos
    public class guardarbancos
    {
        
        public string Banco { get; set; }
        public short Moneda { get; set; }
        public string Cuentacliente { get; set; }
        public string Nombrecuenta { get; set; }
        public decimal Disponible { get; set; }
        public string Tipo { get; set; }
        public System.DateTime Fechasaldo { get; set; }
        public int Idcompania { get; set; }


        public guardarbancos() { }

        public guardarbancos(string Banco, short Moneda, string Cuentacliente, string Nombrecuenta, decimal Disponible, string Tipo, System.DateTime Fechasaldo, int Idcompania)
        {
            
            this.Banco = Banco;
            this.Moneda = Moneda;
            this.Cuentacliente = Cuentacliente;
            this.Nombrecuenta = Nombrecuenta;
            this.Disponible = Disponible;
            this.Tipo = Tipo;
            this.Fechasaldo = Fechasaldo;
            this.Idcompania = Idcompania;
        }
    }
}