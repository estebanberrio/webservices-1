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
    public partial class frmtablainit : Form
    {
        public frmtablainit()
        {
            InitializeComponent();
        }

        private void btnagregarti_Click(object sender, EventArgs e)
        {
            Init Agregar = new Init
            {
                Idcompania = Convert.ToInt16(txtidcompaniati.Text),
                Usuario = txtusuarioti.Text,
                Contrasena = txtcontrasenati.Text,
                Token = txttokenti.Text
            };
            int retornoi = funciones.Agregarinit(Agregar);

            if (retornoi > 0)
            {
                MessageBox.Show("Registro exitoso!");
            }
            else
            {
                MessageBox.Show("Error en el registro");
            }            
        }

        private void btnconectarti_Click(object sender, EventArgs e)
        {
            conexion.obtenerconexion();
            MessageBox.Show("conexión éxitosa!");
        }

        private void btnmostrarti_Click(object sender, EventArgs e)
        {
            dgvti.DataSource = funciones.MostrarDatosinit();
        }
    }
}
