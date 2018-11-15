using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ws.mysql
{
    // clase para la tabla guardar tipo cambio
    public class guardartipocambio
    {
        public Decimal Tipocambiocompra { get; set; }
        public Decimal Tipocambioventa { get; set; }
        public short Moneda { get; set; }
        
        

        public guardartipocambio() { }

        public guardartipocambio(Decimal Tipocambiocompra, Decimal Tipocambioventa, short Moneda)
        {

            this.Tipocambiocompra = Tipocambiocompra;
            this.Tipocambioventa = Tipocambioventa;
            this.Moneda = Moneda;

        }
    }
    
}
