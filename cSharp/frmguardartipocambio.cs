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

namespace wd
{
    public partial class frmguardartipocambio : Form
    {
        public frmguardartipocambio()
        {
            InitializeComponent();
        }

        private void btnagregargtc_Click(object sender, EventArgs e)
        {
            guardartipocambio Agregar = new guardartipocambio
            {
                Tipocambiocompra = Convert.ToDecimal(txttipocambiocompragtc.Text),
                Tipocambioventa = Convert.ToDecimal(txttipocambioventagtc.Text),
                Moneda = Convert.ToInt16(txtmonedagtc.Text)
            };
            int retornogtc = funciones.Agregargtc(Agregar);

            if (retornogtc > 0)
            {
                MessageBox.Show("Registro exitoso!");
            }
            else
            {
                MessageBox.Show("Error en el registro");
            }
        }

        private void btnconectargtc_Click(object sender, EventArgs e)
        {
            conexion.obtenerconexion();
            MessageBox.Show("conexión éxitosa!");
        }

        private void btnmostrargtc_Click(object sender, EventArgs e)
        {
            dgvgtc.DataSource = funciones.MostrarDatosgtc();
        }
    }
}
