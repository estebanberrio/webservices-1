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
    public partial class Excel : Form
    {
        public Excel()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string ruta1 = frmcargararchivos.ruta;            

            string conexion = ("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" +ruta1+ ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\"");

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

            DataTable dt = new DataTable();
            dt.Columns.Add("IdCompania", typeof(Int16));
            dt.Columns.Add("Usuario", typeof(String));
            dt.Columns.Add("Contraseña", typeof(String));
            dt.Columns.Add("TOKEN", typeof(String));

            foreach (DataGridViewRow rowGrid in dataGridView1.Rows)
            {
                DataRow row = dt.NewRow();
                row["IdCompania"] = Convert.ToInt16(rowGrid.Cells[0].Value);
                row["Usuario"] = (rowGrid.Cells[1].Value);
                row["Contraseña"] = (rowGrid.Cells[2].Value);
                row["TOKEN"] = (rowGrid.Cells[3].Value);
                dt.Rows.Add(row);

                Init Agregar1 = new Init
                {
                    Idcompania = Convert.ToInt16(rowGrid.Cells[0].Value),
                    Usuario = Convert.ToString(rowGrid.Cells[1].Value),
                    Contrasena = Convert.ToString(rowGrid.Cells[2].Value),
                    Token = Convert.ToString(rowGrid.Cells[3].Value),
                };
                int retornoi = funciones.Agregarinit(Agregar1);                
            }

            dataGridView2.DataSource = dt;
            origen.Close();            
        }
    }
}