using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ws.mysql
{
    // clase para la tabla guardar antiguedad cxc   
    public class guardarantiguedadcxc
     {
        public short Idcompania { get; set; }
        public string Nombrecliente { get; set; }
        public short Moneda { get; set; }
        public string Cuentacxc { get; set; }
        public short Diascredito { get; set; }
        public System.DateTime Fechadocumento { get; set; }
        public System.DateTime Fechavencimiento { get; set; }
        public decimal Montooriginal { get; set; }
        public decimal Sinvencer { get; set; }
        public decimal De1a30 { get; set; }
        public decimal De31a60 { get; set; }
        public decimal De61a90 { get; set; }
        public decimal Mas90 { get; set; }
        public string Tipo { get; set; }
        
        

        public guardarantiguedadcxc() { }

        public guardarantiguedadcxc(short Idcompania, string Nombrecliente, short Moneda, string Cuentacxc, short Diascredito, System.DateTime Fechadocumento, System.DateTime Fechavencimiento, decimal Montooriginal, decimal Sinvencer, decimal De1a30, decimal De31a60, decimal De61a90, decimal Mas90, string Tipo)
        {
            this.Idcompania = Idcompania;
            this.Nombrecliente = Nombrecliente;
            this.Moneda = Moneda;
            this.Cuentacxc = Cuentacxc;
            this.Diascredito = Diascredito;
            this.Fechadocumento = Fechadocumento;
            this.Fechavencimiento = Fechavencimiento;
            this.Montooriginal = Montooriginal;
            this.Sinvencer = Sinvencer;
            this.De1a30 = De1a30;
            this.De31a60 = De31a60;
            this.De61a90 = De61a90;
            this.Mas90 = Mas90;
            this.Tipo = Tipo;                      
        }
     }
}
