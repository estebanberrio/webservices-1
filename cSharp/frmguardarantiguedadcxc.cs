using System;
using ws.mysql;
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
    public partial class frmguardarantiguedadcxc : Form
    {
        public frmguardarantiguedadcxc()
        {
            InitializeComponent();
        }

        private void btnagregarcxc_Click(object sender, EventArgs e)
        {
            guardarantiguedadcxc Agregar = new guardarantiguedadcxc
            {
                Idcompania = Convert.ToInt16(txtidcompaniacxc.Text),
                Nombrecliente = txtnombreclientecxc.Text,
                Moneda = Convert.ToInt16(txtmonedacxc.Text),
                Cuentacxc = txtcuentacxc.Text,
                Diascredito = Convert.ToInt16(txtdiascreditocxc.Text),
                Fechadocumento = Convert.ToDateTime(txtfechadocumentocxc.Text),
                Fechavencimiento = Convert.ToDateTime(txtfechadocumentocxc.Text),
                Montooriginal = Convert.ToDecimal(txtmontooriginalcxc.Text),
                Sinvencer = Convert.ToDecimal(txtsinvencercxc.Text),
                De1a30 = Convert.ToDecimal(txtde1a30cxc.Text),
                De31a60 = Convert.ToDecimal(txtde31a60cxc.Text),
                De61a90 = Convert.ToDecimal(txtde61a90cxc.Text),
                Mas90 = Convert.ToDecimal(txtmasde90cxc.Text),
                Tipo = txttipocxc.Text
            };

            int retornob = funciones.Agregarcxc (Agregar);

            if (retornob > 0)
            {
                MessageBox.Show("Registro exitoso!");
            }
            else
            {
                MessageBox.Show("Error en el registro");
            }
        }

        private void btnconectarcxc_Click(object sender, EventArgs e)
        {
            conexion.obtenerconexion();
            MessageBox.Show("conexión éxitosa!");
        }

        private void btnmostrarcxc_Click(object sender, EventArgs e)
        {
            dgvcxc.DataSource = funciones.MostrarDatoscxc();
        }

        private void frmguardarantiguedadcxc_Load(object sender, EventArgs e)
        {

        }
    }
}
