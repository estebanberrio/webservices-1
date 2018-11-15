using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ws;
using ws.mysql;

namespace cSharp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnllenardirecta_Click(object sender, EventArgs e)
        {
            principal j1 = new principal();
            Hide();
            j1.ShowDialog();
            Show();
        }

        private void btnconsumirws_Click(object sender, EventArgs e)
        {
            consumirws j2 = new consumirws();
            Hide();
            j2.ShowDialog();
            Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncargarexcel_Click(object sender, EventArgs e)
        {
            frmcargararchivos j3 = new frmcargararchivos();
            Hide();
            j3.ShowDialog();
            Show();
        }

        private void btneliminardatos_Click(object sender, EventArgs e)
        {
            DialogResult respuestaborrar = MessageBox.Show("Esta acción no se puede revertir, estar seguro de la acción?", "Alerta", MessageBoxButtons.OKCancel);
            if (respuestaborrar == DialogResult.Cancel)
            {
                MessageBox.Show("Ha cancelado el borrado de la informacion de las tablas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                funciones.Borrartablas();
                MessageBox.Show("Se ha borrado la información de las tablas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }       

        }

        private void btnvalidarconexion_Click(object sender, EventArgs e)
        {
            var validar = conexion.obtenerconexion();

            if (conexion.prueba == true)
            {
                MessageBox.Show("Conexión Correcta con la Base de Datos!", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{
                       MessageBox.Show("La Conexión ha fallado, revise los parametros!", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}
