using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using ws.mysql;
using ws;
using SpreadsheetLight;
using MySql.Data.Entity;
using System.Data.Common;
using System.Data.Entity;

namespace cSharp
{
    public partial class frmcargararchivos : Form
    {
        public static string archivo = string.Empty;
        public static string ruta = string.Empty;
        public static string tabla = string.Empty;

        public frmcargararchivos()
        {
            InitializeComponent();
            
        }    

        private void btnexaminarca_Click(object sender, EventArgs e)
        {         
            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = OpenFileDialog.FileName;
            }

            tbca.Text = archivo;
            ruta = archivo;
        }

        public void btncargararchivoca_Click(object sender, EventArgs e)
        {
            int dato = 0;
            
            // validar check en radiobutton init
            if (rbtinit.Checked == true)
            {
                dato = 1;
                tabla = "init";
            }
            // validar check en radiobutton guardartipocambio
            if (rbttipocambio.Checked == true)
            {
                dato = 2;
                tabla = "guardartipocambio";
            }
            // validar check en radiobutton guardarinventario
            if (rbtcinventario.Checked == true)
            {
                dato = 3;
                tabla = "guardarinventario";
            }
            // validar check en radiobutton guardarimpuesto
            if (rbtimpuesto.Checked == true)
            {
                dato = 4;
                tabla = "guardarimpuesto";
            }
            // validar check en radiobutton guardarbancos
            if (rbtbancos.Checked == true)
            {
                dato = 5;
                tabla = "guardarbancos";
            }
            // validar check en radiobutton guardarantiguedadcxc
            if (rbtcxc.Checked == true)
            {
                dato = 6;
                tabla = "guardarantiguedadcxc";
            }
            // validar error
            if (ruta.Length == 0)
            {
                MessageBox.Show("Debes Seleccionar un Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //string prueba = "Debe ingresar datos";
            switch (dato)
            {
                case 1:
                    DialogResult respuesta1 = MessageBox.Show("Archivo a Cargar: " + archivo+ "\n \nEn la tabla: INIT", "Alerta", MessageBoxButtons.OKCancel);
                    if (respuesta1 == DialogResult.Cancel)
                    {
                        MessageBox.Show("Ha cancelado la carga! debe seleccionar el archivo y la opcion nuevamente!", "Alerta");
                        rbtinit.Checked=false;
                        tbca.Text = "";

                    }
                    break;
                case 2:
                    DialogResult respuesta2 = MessageBox.Show("Archivo a Cargar: " + archivo + "\n \nEn la tabla: Guardar Tipo Cambio", "Alerta", MessageBoxButtons.OKCancel);
                    if (respuesta2 == DialogResult.Cancel)
                    {
                        MessageBox.Show("Ha cancelado la carga! debe seleccionar el archivo y la opcion nuevamente!", "Alerta");
                        rbttipocambio.Checked = false;
                        tbca.Text = "";
                    }
                    break;
                case 3:
                    DialogResult respuesta3 = MessageBox.Show("Archivo a Cargar: " + archivo + "\n \nEn la tabla: Guardar Inventario", "Alerta", MessageBoxButtons.OKCancel);
                    if (respuesta3 == DialogResult.Cancel)
                    {
                        MessageBox.Show("Ha cancelado la carga! debe seleccionar el archivo y la opcion nuevamente!", "Alerta");
                        rbtcinventario.Checked = false;
                        tbca.Text = "";
                    }
                    break;
                case 4:
                    DialogResult respuesta4 = MessageBox.Show("Archivo a Cargar: " + archivo + "\n \nEn la tabla: Guardar Impuesto", "Alerta", MessageBoxButtons.OKCancel);
                    if (respuesta4 == DialogResult.Cancel)
                    {
                        MessageBox.Show("Ha cancelado la carga! debe seleccionar el archivo y la opcion nuevamente!", "Alerta");
                        rbtimpuesto.Checked = false;
                        tbca.Text = "";
                    }
                    break;

                case 5:
                    DialogResult respuesta5 = MessageBox.Show("Archivo a Cargar: " + archivo + "\n \nEn la tabla: Guardar Bancos", "Alerta", MessageBoxButtons.OKCancel);
                    if (respuesta5 == DialogResult.Cancel)
                    {
                        MessageBox.Show("Ha cancelado la carga! debe seleccionar el archivo y la opcion nuevamente!", "Alerta");
                        rbtbancos.Checked = false;
                        tbca.Text = "";
                    }
                    break;
                case 6:
                    DialogResult respuesta6 = MessageBox.Show("Archivo a Cargar: " + archivo + "\n \nEn la tabla: Guardar Antiguedad CXC", "Alerta", MessageBoxButtons.OKCancel);
                    if (respuesta6 == DialogResult.Cancel)
                    {
                        MessageBox.Show("Ha cancelado la carga! debe seleccionar el archivo y la opcion nuevamente!", "Alerta");
                        rbtcxc.Checked = false;
                        tbca.Text = "";
                    }
                    break;
                default:
                     MessageBox.Show("Debes Seleccionar una Opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            string conexion = ("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + ruta + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\"");

            OleDbConnection origen = default(OleDbConnection);
            origen = new OleDbConnection(conexion);
            origen.Open();

            OleDbCommand seleccion = default(OleDbCommand);
            seleccion = new OleDbCommand("Select * From [Hoja1$]", origen);

            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = seleccion;

            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            DataSet ds2 = new DataSet();
            adaptador.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];

            DataSet ds3 = new DataSet();
            adaptador.Fill(ds3);
            dataGridView1.DataSource = ds3.Tables[0];

            DataSet ds4 = new DataSet();
            adaptador.Fill(ds4);
            dataGridView1.DataSource = ds4.Tables[0];

            DataSet ds5 = new DataSet();
            adaptador.Fill(ds5);
            dataGridView1.DataSource = ds5.Tables[0];

            DataSet ds6 = new DataSet();
            adaptador.Fill(ds6);
            dataGridView1.DataSource = ds6.Tables[0];


            if (dato > 0 && tbca.Text != "" && tabla !="")
            {
                //case para controlar la carga en las diferentes tablas.
                switch (dato)
                {
                    // caso 1 para carga de archivo init.  
                    case 1:
                        DataTable dt = new DataTable();
                        dt.Columns.Add("IdCompania", typeof(Int16));
                        dt.Columns.Add("Usuario", typeof(String));
                        dt.Columns.Add("Contraseña", typeof(String));
                        dt.Columns.Add("TOKEN", typeof(String));

                        foreach (DataGridViewRow rowGrid in dataGridView1.Rows)
                        {
                            DataRow row1 = dt.NewRow();
                            row1["IdCompania"] = Convert.ToInt16(rowGrid.Cells[0].Value);
                            row1["Usuario"] = Convert.ToString(rowGrid.Cells[1].Value);
                            row1["Contraseña"] = Convert.ToString(rowGrid.Cells[2].Value);
                            row1["TOKEN"] = Convert.ToString(rowGrid.Cells[3].Value);
                            dt.Rows.Add(row1);

                            Init Agregar1 = new Init
                            {
                                Idcompania = Convert.ToInt16(rowGrid.Cells[0].Value),
                                Usuario = Convert.ToString(rowGrid.Cells[1].Value),
                                Contrasena = Convert.ToString(rowGrid.Cells[2].Value),
                                Token = Convert.ToString(rowGrid.Cells[3].Value),
                            };
                            funciones.Agregarinit(Agregar1);
                        }
                        break;

                    //case 2 para cargar de archivo guardar tipo cambio.
                    case 2:

                        DataTable dt2 = new DataTable();
                        dt2.Columns.Add("Tipocambiocompra", typeof(Decimal));
                        dt2.Columns.Add("Tipocambioventa", typeof(Decimal));
                        dt2.Columns.Add("Moneda", typeof(String));

                        foreach (DataGridViewRow rowGrid in dataGridView1.Rows)
                        {

                            DataRow row2 = dt2.NewRow();
                            row2["Tipocambiocompra"] = Convert.ToDecimal(rowGrid.Cells[0].Value);
                            row2["Tipocambioventa"] = Convert.ToDecimal(rowGrid.Cells[1].Value);
                            row2["Moneda"] = Convert.ToString(rowGrid.Cells[2].Value);
                            dt2.Rows.Add(row2);

                            guardartipocambio Agregar2 = new guardartipocambio
                            {
                                Tipocambiocompra = Convert.ToDecimal(rowGrid.Cells[0].Value),
                                Tipocambioventa = Convert.ToDecimal(rowGrid.Cells[1].Value),
                                Moneda = Convert.ToInt16(rowGrid.Cells[2].Value),
                            };
                            funciones.Agregargtc(Agregar2);
                        }
                        break;

                    //case 3 para cargar de archivo guardar inventario
                    case 3:

                        DataTable dt3 = new DataTable();
                        dt3.Columns.Add("Idcompania", typeof(Int16));
                        dt3.Columns.Add("Sector", typeof(String));
                        dt3.Columns.Add("Area", typeof(String));
                        dt3.Columns.Add("Familia", typeof(String));
                        dt3.Columns.Add("Cliente", typeof(String));
                        dt3.Columns.Add("Articulo", typeof(String));
                        dt3.Columns.Add("Articulodescripcion", typeof(String));
                        dt3.Columns.Add("Boleta", typeof(String));
                        dt3.Columns.Add("Fecha", typeof(DateTime));
                        dt3.Columns.Add("Permanencia", typeof(Int16));
                        dt3.Columns.Add("Saldo", typeof(Decimal));
                        dt3.Columns.Add("Ventasanuales", typeof(Decimal));
                        dt3.Columns.Add("Peso", typeof(Decimal));
                        dt3.Columns.Add("Costo", typeof(Decimal));

                        foreach (DataGridViewRow rowGrid in dataGridView1.Rows)
                        {
                            DataRow row3 = dt3.NewRow();
                            row3["Idcompania"] = Convert.ToInt16(rowGrid.Cells[0].Value);
                            row3["Sector"] = Convert.ToString(rowGrid.Cells[1].Value);
                            row3["Area"] = Convert.ToString(rowGrid.Cells[2].Value);
                            row3["Familia"] = Convert.ToString(rowGrid.Cells[3].Value);
                            row3["Cliente"] = Convert.ToString(rowGrid.Cells[4].Value);
                            row3["Articulo"] = Convert.ToString(rowGrid.Cells[5].Value);
                            row3["Articulodescripcion"] = Convert.ToString(rowGrid.Cells[6].Value);
                            row3["Boleta"] = Convert.ToString(rowGrid.Cells[7].Value);
                            row3["Fecha"] = Convert.ToDateTime(rowGrid.Cells[8].Value);
                            row3["Permanencia"] = Convert.ToInt16(rowGrid.Cells[9].Value);
                            row3["Saldo"] = Convert.ToDecimal(rowGrid.Cells[10].Value);
                            row3["Ventasanuales"] = Convert.ToDecimal(rowGrid.Cells[11].Value);
                            row3["Peso"] = Convert.ToDecimal(rowGrid.Cells[12].Value);
                            row3["Costo"] = Convert.ToDecimal(rowGrid.Cells[13].Value);
                            dt3.Rows.Add(row3);

                            guardarinventario Agregar3 = new guardarinventario
                            {
                                Idcompania = Convert.ToInt16(rowGrid.Cells[0].Value),
                                Sector = Convert.ToString(rowGrid.Cells[1].Value),
                                Area = Convert.ToString(rowGrid.Cells[2].Value),
                                Familia = Convert.ToString(rowGrid.Cells[3].Value),
                                Cliente = Convert.ToString(rowGrid.Cells[4].Value),
                                Articulo = Convert.ToString(rowGrid.Cells[5].Value),
                                Articulodescripcion = Convert.ToString(rowGrid.Cells[6].Value),
                                Boleta = Convert.ToString(rowGrid.Cells[7].Value),
                                Fecha = Convert.ToDateTime(rowGrid.Cells[8].Value),
                                Permanencia = Convert.ToInt16(rowGrid.Cells[9].Value),
                                Saldo = Convert.ToDecimal(rowGrid.Cells[10].Value),
                                Ventasanuales = Convert.ToDecimal(rowGrid.Cells[11].Value),
                                Peso = Convert.ToDecimal(rowGrid.Cells[12].Value),
                                Costo = Convert.ToDecimal(rowGrid.Cells[13].Value),
                            };
                            funciones.Agregargi(Agregar3);
                        }
                        break;
                    //case 4 para cargar de archivo guardar impuesto
                    case 4:

                        DataTable dt4 = new DataTable();
                        dt4.Columns.Add("Idcompania", typeof(Int16));
                        dt4.Columns.Add("Cuentaimpuesto", typeof(String));
                        dt4.Columns.Add("Idclasificacion", typeof(Int16));
                        dt4.Columns.Add("Monto", typeof(Decimal));
                        dt4.Columns.Add("Descripcion", typeof(String));

                        foreach (DataGridViewRow rowGrid in dataGridView1.Rows)
                        {

                            DataRow row4 = dt4.NewRow();
                            row4["Idcompania"] = Convert.ToInt16(rowGrid.Cells[0].Value);
                            row4["Cuentaimpuesto"] = Convert.ToString(rowGrid.Cells[1].Value);
                            row4["Idclasificacion"] = Convert.ToInt16(rowGrid.Cells[2].Value);
                            row4["Monto"] = Convert.ToDecimal(rowGrid.Cells[3].Value);
                            row4["Descripcion"] = Convert.ToString(rowGrid.Cells[4].Value);
                            dt4.Rows.Add(row4);

                            guardarimpuesto Agregar4 = new guardarimpuesto
                            {
                                Idcompania = Convert.ToInt16(rowGrid.Cells[0].Value),
                                Cuentaimpuesto = Convert.ToString(rowGrid.Cells[1].Value),
                                Idclasificacion = Convert.ToInt16(rowGrid.Cells[2].Value),
                                Monto = Convert.ToDecimal(rowGrid.Cells[3].Value),
                                Descripcion = Convert.ToString(rowGrid.Cells[4].Value),
                            };

                            funciones.Agregargim(Agregar4);
                        }
                        break;
                    //case 3 para cargar de archivo guardar banco
                    case 5:

                        DataTable dt5 = new DataTable();
                        dt5.Columns.Add("Idcompania", typeof(Int16));
                        dt5.Columns.Add("Banco", typeof(String));
                        dt5.Columns.Add("Moneda", typeof(Int16));
                        dt5.Columns.Add("Cuentacliente", typeof(String));
                        dt5.Columns.Add("Nombrecuenta", typeof(String));
                        dt5.Columns.Add("Disponible", typeof(Decimal));
                        dt5.Columns.Add("Tipo", typeof(String));
                        dt5.Columns.Add("Fechasaldo", typeof(DateTime));

                        foreach (DataGridViewRow rowGrid in dataGridView1.Rows)
                        {
                            DataRow row5 = dt5.NewRow();
                            row5["Idcompania"] = Convert.ToInt16(rowGrid.Cells[0].Value);
                            row5["Banco"] = Convert.ToString(rowGrid.Cells[1].Value);
                            row5["Moneda"] = Convert.ToInt16(rowGrid.Cells[2].Value);
                            row5["Cuentacliente"] = Convert.ToString(rowGrid.Cells[3].Value);
                            row5["Nombrecuenta"] = Convert.ToString(rowGrid.Cells[4].Value);
                            row5["Disponible"] = Convert.ToDecimal(rowGrid.Cells[5].Value);
                            row5["Tipo"] = Convert.ToString(rowGrid.Cells[6].Value);
                            row5["Fechasaldo"] = Convert.ToDateTime(rowGrid.Cells[7].Value);
                            dt5.Rows.Add(row5);

                            guardarbancos Agregar5 = new guardarbancos
                            {
                                Idcompania = Convert.ToInt16(rowGrid.Cells[0].Value),
                                Banco = Convert.ToString(rowGrid.Cells[1].Value),
                                Moneda = Convert.ToInt16(rowGrid.Cells[2].Value),
                                Cuentacliente = Convert.ToString(rowGrid.Cells[3].Value),
                                Nombrecuenta = Convert.ToString(rowGrid.Cells[4].Value),
                                Disponible = Convert.ToDecimal(rowGrid.Cells[5].Value),
                                Tipo = Convert.ToString(rowGrid.Cells[6].Value),
                                Fechasaldo = Convert.ToDateTime(rowGrid.Cells[7].Value),
                            };
                            funciones.Agregarbanco(Agregar5);
                        }
                        break;

                    case 6:

                        DataTable dt6 = new DataTable();
                        dt6.Columns.Add("Idcompania", typeof(Int16));
                        dt6.Columns.Add("Nombrecliente", typeof(String));
                        dt6.Columns.Add("Moneda", typeof(Int16));
                        dt6.Columns.Add("Cuentacxc", typeof(String));
                        dt6.Columns.Add("Diascredito", typeof(Int16));
                        dt6.Columns.Add("Fechadocumento", typeof(DateTime));
                        dt6.Columns.Add("Fechavencimiento", typeof(DateTime));
                        dt6.Columns.Add("Montooriginal", typeof(Decimal));
                        dt6.Columns.Add("Sinvencer", typeof(Decimal));
                        dt6.Columns.Add("De1a30", typeof(Decimal));
                        dt6.Columns.Add("De31a60", typeof(Decimal));
                        dt6.Columns.Add("De61a90", typeof(Decimal));
                        dt6.Columns.Add("Mas90", typeof(Decimal));
                        dt6.Columns.Add("Tipo", typeof(String));


                        foreach (DataGridViewRow rowGrid in dataGridView1.Rows)
                        {

                            DataRow row6 = dt6.NewRow();
                            row6["Idcompania"] = Convert.ToInt16(rowGrid.Cells[0].Value);
                            row6["Nombrecliente"] = Convert.ToString(rowGrid.Cells[1].Value);
                            row6["Moneda"] = Convert.ToInt16(rowGrid.Cells[2].Value);
                            row6["Cuentacxc"] = Convert.ToString(rowGrid.Cells[3].Value);
                            row6["Diascredito"] = Convert.ToInt16(rowGrid.Cells[4].Value);
                            row6["Fechadocumento"] = Convert.ToDateTime(rowGrid.Cells[5].Value);
                            row6["Fechavencimiento"] = Convert.ToDateTime(rowGrid.Cells[6].Value);
                            row6["Montooriginal"] = Convert.ToDecimal(rowGrid.Cells[7].Value);
                            row6["Sinvencer"] = Convert.ToDecimal(rowGrid.Cells[8].Value);
                            row6["De1a30"] = Convert.ToDecimal(rowGrid.Cells[9].Value);
                            row6["De31a60"] = Convert.ToDecimal(rowGrid.Cells[10].Value);
                            row6["De61a90"] = Convert.ToDecimal(rowGrid.Cells[11].Value);
                            row6["Mas90"] = Convert.ToDecimal(rowGrid.Cells[12].Value);
                            row6["Tipo"] = Convert.ToString(rowGrid.Cells[13].Value);
                            dt6.Rows.Add(row6);

                            guardarantiguedadcxc Agregar6 = new guardarantiguedadcxc
                            {
                                Idcompania = Convert.ToInt16(rowGrid.Cells[0].Value),
                                Nombrecliente = Convert.ToString(rowGrid.Cells[1].Value),
                                Moneda = Convert.ToInt16(rowGrid.Cells[2].Value),
                                Cuentacxc = Convert.ToString(rowGrid.Cells[3].Value),
                                Diascredito = Convert.ToInt16(rowGrid.Cells[4].Value),
                                Fechadocumento = Convert.ToDateTime(rowGrid.Cells[5].Value),
                                Fechavencimiento = Convert.ToDateTime(rowGrid.Cells[6].Value),
                                Montooriginal = Convert.ToDecimal(rowGrid.Cells[7].Value),
                                Sinvencer = Convert.ToDecimal(rowGrid.Cells[8].Value),
                                De1a30 = Convert.ToDecimal(rowGrid.Cells[9].Value),
                                De31a60 = Convert.ToDecimal(rowGrid.Cells[10].Value),
                                De61a90 = Convert.ToDecimal(rowGrid.Cells[11].Value),
                                Mas90 = Convert.ToDecimal(rowGrid.Cells[12].Value),
                                Tipo = Convert.ToString(rowGrid.Cells[13].Value),
                            };
                            funciones.Agregarcxc(Agregar6);
                        }
                    break;                 
                }
                origen.Close();
                MessageBox.Show("Se ha guardado de forma éxitosa!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void frmcargararchivos_Load(object sender, EventArgs e)
        {

        }
    }
}
