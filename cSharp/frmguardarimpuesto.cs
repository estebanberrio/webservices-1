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
    public partial class frmguardarimpuesto : Form
    {
        public frmguardarimpuesto()
        {
            InitializeComponent();
        }

        private void btnagregargim_Click(object sender, EventArgs e)
        {
            guardarimpuesto Agregar = new guardarimpuesto
            {
                Idcompania = Convert.ToInt16(txtidcompaniagim.Text),
                Cuentaimpuesto = txtcuentaimpuestogim.Text,
                Idclasificacion = Convert.ToInt16(txtidclasificaciongim.Text),
                Monto = Convert.ToDecimal(txtmontogim.Text),
                Descripcion = txtdescripciongim.Text
            };

            int retornoim = funciones.Agregargim(Agregar);

            if (retornoim > 0)
            {
                MessageBox.Show("Registro exitoso!");
            }
            else
            {
                MessageBox.Show("Error en el registro");
            }
        }

        private void btnconectargim_Click(object sender, EventArgs e)
        {
            conexion.obtenerconexion();
            MessageBox.Show("conexión éxitosa!");
        }

        private void btnmostrargim_Click(object sender, EventArgs e)
        {
            dgvgim.DataSource = funciones.MostrarDatosgim();
        }
    }
}
