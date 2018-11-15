using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws.mysql
{
    //clase para la tabla guardarimpuesto
    public class guardarimpuesto
    {
        public short Idcompania { get; set; }
        public string Cuentaimpuesto { get; set; }
        public short Idclasificacion { get; set; }
        public Decimal Monto { get; set; }
        public string Descripcion { get; set; }
        
        

        public guardarimpuesto() { }

        public guardarimpuesto(short Idcompania, string Cuentaimpuesto, short Idclasificacion, Decimal Monto, string Descripcion)
        {
            this.Idcompania = Idcompania;
            this.Cuentaimpuesto = Cuentaimpuesto;
            this.Idclasificacion = Idclasificacion;
            this.Monto = Monto;
            this.Descripcion = Descripcion;         
        }
    }
}
