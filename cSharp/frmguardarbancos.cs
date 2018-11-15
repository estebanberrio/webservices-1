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
    public partial class frmguardarbancos : Form
    {
        public frmguardarbancos()
        {
            InitializeComponent();
        }

        private void btnagregargb_Click(object sender, EventArgs e)
        {
            guardarbancos Agregar = new guardarbancos
            {
                Idcompania = Convert.ToInt16(txtidcompaniagb.Text),
                Banco = txtbancogb.Text,
                Moneda = Convert.ToInt16(txtmonedagb.Text),
                Cuentacliente = txtcuentaclientegb.Text,
                Nombrecuenta = txtnombrecuentagb.Text,
                Disponible = Convert.ToDecimal(txtdisponiblegb.Text),
                Tipo = txttipogb.Text,
                Fechasaldo = Convert.ToDateTime(txtfechasaldogb.Text)
            };

            int retornob = funciones.Agregarbanco(Agregar);

            if (retornob > 0)
            {
                MessageBox.Show("Registro exitoso!");
            }
            else
            {
                MessageBox.Show("Error en el registro");
            }
        }

        private void btnconectargb_Click(object sender, EventArgs e)
        {
            conexion.obtenerconexion();
            MessageBox.Show("conexión éxitosa!");
        }

        private void btnmostrargb_Click(object sender, EventArgs e)
        {
            dgvgb.DataSource = funciones.MostrarDatosgb();
        }
    }
}
