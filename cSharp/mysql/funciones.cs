using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ws.mysql
{
    public class funciones
    {
        // funciones formulario Init
        public static int Agregarinit(Init add)
        {
            int retornoi = 0;
            MySqlCommand comandoi = new MySqlCommand(String.Format("insert into Init(IdCompania, Usuario, Contraseña, TOKEN) values ('{0}','{1}','{2}','{3}');", add.Idcompania, add.Usuario, add.Contrasena, add.Token), conexion.obtenerconexion());
            retornoi = comandoi.ExecuteNonQuery();
            return retornoi;
        }

        public static List<Init> MostrarDatosinit()
        {
            List<Init> lista = new List<Init>();
            MySqlCommand comandoi = new MySqlCommand(String.Format("select * from init;"), conexion.obtenerconexion());
            MySqlDataReader readeri = comandoi.ExecuteReader();

            while (readeri.Read())
            {
                Init ai = new Init
                {
                    Idcompania = readeri.GetInt16(0),
                    Usuario = readeri.GetString(1),
                    Contrasena = readeri.GetString(2),
                    Token = readeri.GetString(3)
                };
                lista.Add(ai);
            }
            return lista;
        }

        // funciones formulario Guardar Tipo Cambio
        public static int Agregargtc(guardartipocambio add)
        {
            int retornogtc = 0;
            MySqlCommand comandogtc = new MySqlCommand(String.Format("insert into guardartipocambio(Tipocambiocompra, Tipocambioventa, Moneda) values ('{0}','{1}','{2}');", add.Tipocambiocompra, add.Tipocambioventa, add.Moneda), conexion.obtenerconexion());
            retornogtc = comandogtc.ExecuteNonQuery();
            return retornogtc;
        }

        public static List<guardartipocambio> MostrarDatosgtc()
        {
            List<guardartipocambio> lista = new List<guardartipocambio>();
            MySqlCommand comandogtc = new MySqlCommand(String.Format("select * from guardartipocambio;"), conexion.obtenerconexion());
            MySqlDataReader readergtc = comandogtc.ExecuteReader();

            while (readergtc.Read())
            {
                guardartipocambio agtc = new guardartipocambio
                {
                    Tipocambiocompra = readergtc.GetDecimal(0),
                    Tipocambioventa = readergtc.GetDecimal(1),
                    Moneda = readergtc.GetInt16(2)
                };
                lista.Add(agtc);
            }
            return lista;
        }

        // funciones formulario Guardar Inventario
        public static int Agregargi(guardarinventario add)
        {
            int retornogi = 0;
            MySqlCommand comandogi = new MySqlCommand(String.Format("insert into guardarinventario(Idcompania, Sector, Area, Familia, Cliente, Articulo, ArticuloDescripcion, Boleta, Fecha, Permanencia, Saldo, VentasAnuales, Peso, Costo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}');", add.Idcompania, add.Sector, add.Area, add.Familia, add.Cliente, add.Articulo, add.Articulodescripcion, add.Boleta, add.Fecha, add.Permanencia, add.Saldo, add.Ventasanuales, add.Peso, add.Costo), conexion.obtenerconexion());
            retornogi = comandogi.ExecuteNonQuery();
            return retornogi;
        }

        public static List<guardarinventario> MostrarDatosgi()
        {
            List<guardarinventario> lista = new List<guardarinventario>();
            MySqlCommand comandogi = new MySqlCommand(String.Format("select * from guardarinventario;"), conexion.obtenerconexion());
            MySqlDataReader readergi = comandogi.ExecuteReader();

            while (readergi.Read())
            {
                guardarinventario agi = new guardarinventario
                {
                    Idcompania = readergi.GetInt16(0),
                    Sector = readergi.GetString(1),
                    Area = readergi.GetString(2),
                    Familia = readergi.GetString(3),
                    Cliente = readergi.GetString(4),
                    Articulo = readergi.GetString(5),
                    Articulodescripcion = readergi.GetString(6),
                    Boleta = readergi.GetString(7),
                    Fecha = readergi.GetDateTime(8),
                    Permanencia = readergi.GetInt16(9),
                    Saldo = readergi.GetDecimal(10),
                    Ventasanuales = readergi.GetDecimal(11),
                    Peso = readergi.GetDecimal(12),
                    Costo = readergi.GetDecimal(13)
                };
                lista.Add(agi);
            }
            return lista;

        }
        
        // funciones formulario Guardar Impuesto
        public static int Agregargim(guardarimpuesto add)
        {
            int retornogim = 0;
            MySqlCommand comandogim = new MySqlCommand(String.Format("insert into guardarimpuesto(Idcompania, CuentaImpuesto, IdClasificacion, Monto, Descripcion) values ('{0}','{1}','{2}','{3}','{4}');", add.Idcompania, add.Cuentaimpuesto, add.Idclasificacion, add.Monto, add.Descripcion), conexion.obtenerconexion());
            retornogim = comandogim.ExecuteNonQuery();
            return retornogim;
        }

        public static List<guardarimpuesto> MostrarDatosgim()
        {
            List<guardarimpuesto> lista = new List<guardarimpuesto>();
            MySqlCommand comandogim = new MySqlCommand(String.Format("select * from guardarimpuesto;"), conexion.obtenerconexion());
            MySqlDataReader readergim = comandogim.ExecuteReader();

            while (readergim.Read())
            {
                guardarimpuesto agim = new guardarimpuesto
                {
                    Idcompania = readergim.GetInt16(0),
                    Cuentaimpuesto = readergim.GetString(1),
                    Idclasificacion = readergim.GetInt16(2),
                    Monto = readergim.GetDecimal(3),
                    Descripcion = readergim.GetString(4),
                };
                lista.Add(agim);
            }
            return lista;

        }
        
        // funciones formulario Guardar Bancos
        public static int Agregarbanco(guardarbancos add)
        {
            int retornogb = 0;
            MySqlCommand comandogb = new MySqlCommand(String.Format("insert into guardarbancos(Banco, Moneda, CuentaCliente, NombreCuenta, Disponible, Tipo, FechaSaldo, Idcompania) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');", add.Banco, add.Moneda, add.Cuentacliente, add.Nombrecuenta ,add.Disponible, add.Tipo, add.Fechasaldo, add.Idcompania), conexion.obtenerconexion());
            retornogb = comandogb.ExecuteNonQuery();
            return retornogb;
        }

        public static List<guardarbancos> MostrarDatosgb()
        {
            List<guardarbancos> lista = new List<guardarbancos>();
            MySqlCommand comandogb = new MySqlCommand(String.Format("select * from guardarbancos;"), conexion.obtenerconexion());
            MySqlDataReader readergb = comandogb.ExecuteReader();

            while (readergb.Read())
            {
                guardarbancos ab = new guardarbancos
                {
                    
                    Banco = readergb.GetString(0),
                    Moneda = readergb.GetInt16(1),
                    Cuentacliente = readergb.GetString(2),
                    Nombrecuenta = readergb.GetString(3),
                    Disponible = readergb.GetDecimal(4),
                    Tipo = readergb.GetString(5),
                    Fechasaldo = readergb.GetDateTime(6),
                    Idcompania = readergb.GetInt16(7)
                };
                lista.Add(ab);
            }
            return lista;
        }

        // funciones formulario Guardar Antiguedad CXC
        public static int Agregarcxc(guardarantiguedadcxc add)
        {
            int retornocxc = 0;
            MySqlCommand comandocxc = new MySqlCommand(String.Format("insert into guardarantiguedadcxc(Idcompania, NombreCliente, Moneda, CuentaCXC, DiasCredito, FechaDocumento, FechaVencimiento, MontoOriginal, Sinvencer, De1a30, De31a60, De61a90, Mas90, Tipo) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}');", add.Idcompania, add.Nombrecliente, add.Moneda, add.Cuentacxc, add.Diascredito, add.Fechadocumento, add.Fechavencimiento, add.Montooriginal, add.Sinvencer, add.De1a30, add.De31a60, add.De61a90, add.Mas90, add.Tipo), conexion.obtenerconexion());
            retornocxc = comandocxc.ExecuteNonQuery();
            return retornocxc;
        }

        public static List<guardarantiguedadcxc> MostrarDatoscxc()
        {
            List<guardarantiguedadcxc> lista = new List<guardarantiguedadcxc>();
            MySqlCommand comandocxc = new MySqlCommand(String.Format("select * from guardarantiguedadcxc;"), conexion.obtenerconexion());
            MySqlDataReader readercxc = comandocxc.ExecuteReader();

            while (readercxc.Read())
            {
                guardarantiguedadcxc acxc = new guardarantiguedadcxc
                {
                    Idcompania = readercxc.GetInt16(0),
                    Nombrecliente = readercxc.GetString(1),
                    Moneda = readercxc.GetInt16(2),
                    Cuentacxc = readercxc.GetString(3),
                    Diascredito = readercxc.GetInt16(4),
                    Fechadocumento = readercxc.GetDateTime(5),
                    Fechavencimiento = readercxc.GetDateTime(6),
                    Montooriginal = readercxc.GetDecimal(7),
                    Sinvencer = readercxc.GetDecimal(8),
                    De1a30 = readercxc.GetDecimal(9),
                    De31a60 = readercxc.GetDecimal(10),
                    De61a90 = readercxc.GetDecimal(11),
                    Mas90 = readercxc.GetDecimal(12),
                    Tipo = readercxc.GetString(13)
                };
                lista.Add(acxc);
            }
            return lista;

        }

        // funciones para borrar la información de la tablas excepto INIT
        public static int Borrartablas()
        {
            MySqlCommand borrar1 = new MySqlCommand(String.Format("DELETE from init;"), conexion.obtenerconexion());
            borrar1.ExecuteNonQuery();

            MySqlCommand borrar2 = new MySqlCommand(String.Format("DELETE FROM guardartipocambio;"), conexion.obtenerconexion());
            borrar2.ExecuteNonQuery();

            MySqlCommand borrar3 = new MySqlCommand(String.Format("DELETE FROM guardarbancos;"), conexion.obtenerconexion());
            borrar3.ExecuteNonQuery();

            MySqlCommand borrar4 = new MySqlCommand(String.Format("DELETE FROM guardarimpuesto;"), conexion.obtenerconexion());
            borrar4.ExecuteNonQuery();

            MySqlCommand borrar5 = new MySqlCommand(String.Format("DELETE FROM guardarantiguedadcxc;"), conexion.obtenerconexion());
            borrar5.ExecuteNonQuery();

            MySqlCommand borrar6 = new MySqlCommand(String.Format("DELETE FROM guardarinventario;"), conexion.obtenerconexion());
            borrar6.ExecuteNonQuery();

            return 0;
        }

        // cierra la clase funcioens
    }

// cierra namespace
}
