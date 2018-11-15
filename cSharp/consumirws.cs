using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharp.wsTesoreria;
using MySql.Data.MySqlClient;
using ws.mysql;

namespace cSharp
{
    public partial class consumirws : Form
    {
        public consumirws()
        {
            InitializeComponent();
        }

        //obtener token funcion Init
        private void btconsumirinit_Click(object sender, EventArgs e)
        {
            // llamada de funcionp para traer autenticacion inicial y obtener token
            var v1 = funciones.MostrarDatosinit();
            var i1 = v1.ElementAt(0);

            // variables segun campos
            var idcompania1 = i1.Idcompania;
            var usuario1 = i1.Usuario;
            var contrasena1 = i1.Contrasena;
            var token1 = System.String.Empty;

            MessageBox.Show("Elementos "+i1+"valores"+idcompania1 + usuario1 + contrasena1); 


            using (wsTesoreria.TesoreriaClient var1 = new wsTesoreria.TesoreriaClient())
            {
                var1.Init(usuario1, contrasena1, idcompania1, ref token1);
                MySqlCommand comando1 = new MySqlCommand(String.Format("update init set token='"+token1+"' where idcompania='"+idcompania1+"';"),conexion.obtenerconexion());
                comando1.ExecuteNonQuery();
            }
            MessageBox.Show("token: " + token1);
        }

        //consumir guardar tipo cambio
        private void btnconsumirgtc_Click(object sender, EventArgs e)
        {

            // llamada de funcionp para traer token almacenado.
            var v1 = funciones.MostrarDatosinit();
            var i1 = v1.ElementAt(0);
            var token1 = i1.Token;

            // recarga de lista y valores de conteo
            var v2 = funciones.MostrarDatosgtc();
            var i2 = v2.ElementAt(0);

            // variables segun campos
            var tipocambiocompra = i2.Tipocambiocompra;
            var tipocambioventa = i2.Tipocambioventa;
            var moneda = i2.Moneda;
            var token2 = token1;
            var mensaje2 = System.String.Empty;

            using (wsTesoreria.TesoreriaClient var1 = new wsTesoreria.TesoreriaClient())
            {
                var1.GuardarTipoCambio(tipocambiocompra, tipocambiocompra, moneda, token2, ref mensaje2);
                MessageBox.Show("retorno mensaje: " +mensaje2);
            }

        }

        // consumir guardar inventario
        private void btnconsumirgi_Click(object sender, EventArgs e)
        {

            int cont = 0; //contador para while

            // llamada de funcionp para traer token almacenado.
            var v1 = funciones.MostrarDatosinit();
            var i1 = v1.ElementAt(0);
            var token1 = i1.Token;

            // recarga de lista y valores de conteo
            var v3 = funciones.MostrarDatosgi();
            var i3 = v3.ElementAt(cont);
            var j3 = v3.Count();

            var idcompania = i3.Idcompania;
            var sector = i3.Sector;
            var area = i3.Area;
            var familia = i3.Familia;
            var cliente = i3.Cliente;
            var articulo = i3.Articulo;
            var articulodescripcion = i3.Articulodescripcion;
            var boleta = i3.Boleta;
            var fecha = i3.Fecha;
            var permanencia = i3.Permanencia;
            var saldo = i3.Saldo;
            var ventasanuales = i3.Ventasanuales;
            var peso = i3.Peso;
            var costo = i3.Costo;

            var token3 = token1;
            var mensaje3 = System.String.Empty;

            using (wsTesoreria.TesoreriaClient var1 = new wsTesoreria.TesoreriaClient())
            {

                while (cont < j3)
                {
                    //lista con los elementos
                    i3 = v3.ElementAt(cont);

                    // variables segun campos
                    idcompania = i3.Idcompania;
                    sector = i3.Sector;
                    area = i3.Area;
                    familia = i3.Familia;
                    cliente = i3.Cliente;
                    articulo = i3.Articulo;
                    articulodescripcion = i3.Articulodescripcion;
                    boleta = i3.Boleta;
                    fecha = i3.Fecha;
                    permanencia = i3.Permanencia;
                    saldo = i3.Saldo;
                    ventasanuales = i3.Ventasanuales;
                    peso = i3.Peso;
                    costo = i3.Costo;

                    //llamada a la clase en tesoreria.cs
                    var1.GuardarInventario(idcompania, sector, area, familia, cliente, articulo, articulodescripcion, boleta, fecha, permanencia, saldo, ventasanuales, peso, costo, token3, ref mensaje3);

                    //aumento del contador
                    cont++;
                }
                MessageBox.Show("retorno mensaje: " +mensaje3);
            }
            
        }

        // consumir guardar impuesto
        private void btnconsumirgim_Click(object sender, EventArgs e)
        {

            int cont = 0; //contador para while

            // llamada de funcion para traer token almacenado.
            var v1 = funciones.MostrarDatosinit();
            var i1 = v1.ElementAt(0);
            var token1 = i1.Token;

            // recarga de lista y valores de conteo
            var v4 = funciones.MostrarDatosgim();
            var i4 = v4.ElementAt(cont);
            var j4 = v4.Count();

            // variables segun campos
            var idcompania = i4.Idcompania;
            var cuentaimpuesto = i4.Cuentaimpuesto;
            var idclasificacion = i4.Idclasificacion;
            var monto = i4.Monto;
            var descripcion = i4.Descripcion;

            var mensaje4 = System.String.Empty;
            var token4 = token1;
   

            using (wsTesoreria.TesoreriaClient var1 = new wsTesoreria.TesoreriaClient())
            {

                while (cont < j4)
                {
                    //lista con los elementos
                    i4 = v4.ElementAt(cont);
                   
                    // variables segun campos
                    idcompania = i4.Idcompania;
                    cuentaimpuesto = i4.Cuentaimpuesto;
                    idclasificacion = i4.Idclasificacion;
                    monto = i4.Monto;
                    descripcion = i4.Descripcion;

                    //llamada a la clase en tesoreria.cs
                    var1.GuardarImpuesto(idcompania,cuentaimpuesto, idclasificacion, monto, descripcion, token4, ref mensaje4);

                    //aumento del contador
                    cont++;
                }
                MessageBox.Show("retorno mensaje: " + mensaje4);
            }



        }


        // consumir guardar bancos
        private void btnconsumirgb_Click(object sender, EventArgs e)
        {
            int cont = 0; //contador para while

            // llamada de funcionp para traer token almacenado.
            var v1 = funciones.MostrarDatosinit();
            var i1 = v1.ElementAt(0);
            var token1 = i1.Token;

            // recarga de lista y valores de conteo
            var v5 = funciones.MostrarDatosgb();
            var i5 = v5.ElementAt(cont);
            var j5 = v5.Count();

            // variables segun campos
            var idcompania = i5.Idcompania;
            var banco = i5.Banco;
            var moneda = i5.Moneda;
            var cuentacliente = i5.Cuentacliente;
            var nombrecuenta = i5.Nombrecuenta;
            var disponible = i5.Disponible;
            var tipo = i5.Tipo;
            var fechasaldo = i5.Fechasaldo;

            var mensaje5 = System.String.Empty;
            var token5 = token1;

            using (wsTesoreria.TesoreriaClient var1 = new wsTesoreria.TesoreriaClient())
            {

                while (cont < j5)
                {
                    //lista con los elementos
                    i5 = v5.ElementAt(cont);

                    // variables segun campos
                    idcompania = i5.Idcompania;
                    banco = i5.Banco;
                    moneda = i5.Moneda;
                    cuentacliente = i5.Cuentacliente;
                    nombrecuenta = i5.Nombrecuenta;
                    disponible = i5.Disponible;
                    tipo = i5.Tipo;
                    fechasaldo = i5.Fechasaldo;

                    //llamada a la clase en tesoreria.cs
                    var1.GuardarBancos(banco, moneda, cuentacliente, nombrecuenta, disponible, tipo, fechasaldo, idcompania, token5, ref mensaje5);

                    //aumento del contador
                    cont++;
                }
                MessageBox.Show("retorno mensaje: " + mensaje5);
            }

        }

        // consumir guardar antiguedad CXC
        private void btnconsumircxc_Click(object sender, EventArgs e)
        {
            int cont = 0; //contador para while

            // llamada de funcionp para traer token almacenado.
            var v1 = funciones.MostrarDatosinit();
            var i1 = v1.ElementAt(0);
            var token1 = i1.Token;

            // recarga de lista y valores de conteo
            var v6 = funciones.MostrarDatoscxc();
            var i6 = v6.ElementAt(0);
            var j6 = v6.Count();

            // variables segun campos
            var idcompania = i6.Idcompania;
            var nombrecliente = i6.Nombrecliente;
            var moneda = i6.Moneda;
            var cuentacxc = i6.Cuentacxc;
            var diascredito = i6.Diascredito;
            var fechadocumento = i6.Fechadocumento;
            var fechavencimiento = i6.Fechavencimiento;
            var montooriginal = i6.Montooriginal;
            var sinvencer = i6.Sinvencer;
            var de1a30 = i6.De1a30;
            var de31a60 = i6.De31a60;
            var de61a90 = i6.De61a90;
            var mas90 = i6.Mas90;
            var tipo = i6.Tipo;

            var mensaje6 = System.String.Empty;
            var token6 = token1;


            using (wsTesoreria.TesoreriaClient var1 = new wsTesoreria.TesoreriaClient())
            {
                while (cont < j6)
                {
                    //lista con los elementos
                    i6 = v6.ElementAt(cont);

                    // variables segun campos
                    idcompania = i6.Idcompania;
                    nombrecliente = i6.Nombrecliente;
                    moneda = i6.Moneda;
                    cuentacxc = i6.Cuentacxc;
                    diascredito = i6.Diascredito;
                    fechadocumento = i6.Fechadocumento;
                    fechavencimiento = i6.Fechavencimiento;
                    montooriginal = i6.Montooriginal;
                    sinvencer = i6.Sinvencer;
                    de1a30 = i6.De1a30;
                    de31a60 = i6.De31a60;
                    de61a90 = i6.De61a90;
                    mas90 = i6.Mas90;
                    tipo = i6.Tipo;

                    //llamada a la clase en tesoreria.cs
                    var1.GuardarAntiguedadCXC(idcompania, nombrecliente, moneda, cuentacxc, diascredito, fechadocumento, fechavencimiento, montooriginal, sinvencer, de1a30, de31a60, de61a90, mas90, tipo, token6, ref mensaje6);

                    //aumento del contador
                    cont++;
                }
                MessageBox.Show("retorno mensaje: " + mensaje6);
            }

        }


    
    }
}
