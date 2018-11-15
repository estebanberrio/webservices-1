using ws.mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ws
{
    public partial class frmguardarinventario : Form
    {
        public frmguardarinventario()
        {
            InitializeComponent();
        }

        private void btnagregargi_Click(object sender, EventArgs e)
        {
            guardarinventario Agregar = new guardarinventario
            {
                Idcompania = Convert.ToInt16(txtidcompaniagi.Text),
                Sector = txtsectorgi.Text,
                Area = txtareagi.Text,
                Familia = txtfamiliagi.Text,
                Cliente = txtclientegi.Text,
                Articulo = txtarticulogi.Text,
                Articulodescripcion = txtarticulodescripciongi.Text,
                Boleta = txtboletagi.Text,
                Fecha = Convert.ToDateTime(txtfechagi.Text),
                Permanencia = Convert.ToInt16(txtpermanenciagi.Text),
                Saldo = Convert.ToDecimal(txtsaldogi.Text),
                Ventasanuales = Convert.ToDecimal(txtventasanualesgi.Text),
                Peso = Convert.ToDecimal(txtpesogi.Text),
                Costo = Convert.ToDecimal(txtcostogi.Text)
            };

            int retornogi = funciones.Agregargi(Agregar);

            if (retornogi > 0)
            {
                MessageBox.Show("Registro exitoso!");
            }
            else
            {
                MessageBox.Show("Error en el registro");
            }
        }

        private void btnmostrargi_Click(object sender, EventArgs e)
        {
            dgvgi.DataSource = funciones.MostrarDatosgi();
        }

        private void btnconectargi_Click(object sender, EventArgs e)
        {
            conexion.obtenerconexion();
            MessageBox.Show("conexión éxitosa!");
        }
    }
}
