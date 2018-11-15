using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws.mysql
{
    // clase para la tabla guardarinventario
    public class guardarinventario
    {
        public short Idcompania { get; set; }
        public string Sector { get; set; }
        public string Area { get; set; }
        public string Familia { get; set; }
        public string Cliente { get; set; }
        public string Articulo { get; set; }
        public string Articulodescripcion { get; set; }
        public string Boleta { get; set; }
        public System.DateTime Fecha { get; set; }
        public short Permanencia { get; set; }
        public decimal Saldo { get; set; }
        public decimal Ventasanuales { get; set; }
        public decimal Peso { get; set; }
        public decimal Costo { get; set; }
        
        

        public guardarinventario() { }

        public guardarinventario(short Idcompania, string Sector, string Area, string Familia, string Cliente, string Articulo, string Articulodescripcion, string Boleta, System.DateTime Fecha, short Permanencia, decimal Saldo, decimal Ventasanuales, decimal Peso, decimal Costo)
        {
            this.Idcompania = Idcompania;
            this.Sector = Sector;
            this.Area = Area;
            this.Familia = Familia;
            this.Cliente = Cliente;
            this.Articulo = Articulo;
            this.Articulodescripcion = Articulodescripcion;
            this.Boleta = Boleta;
            this.Fecha = Fecha;
            this.Permanencia = Permanencia;
            this.Saldo = Saldo;
            this.Ventasanuales = Ventasanuales;
            this.Peso = Peso;
            this.Costo = Costo;           
            
        }
    }
}
