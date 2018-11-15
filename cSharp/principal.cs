using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wd;

namespace ws
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }
        //boton formulario init
        private void btninit_Click(object sender, EventArgs e)
        {
            frmtablainit i1 = new frmtablainit();
            Hide();
            i1.ShowDialog();
            Show();
        }
        //boton formulario guardar tipo cambio
        private void btnguardartipocambio_Click(object sender, EventArgs e)
        {
            frmguardartipocambio i2 = new frmguardartipocambio();
            Hide();
            i2.ShowDialog();
            Show();

        }
        //boton formulario guardar inventario
        private void btnguardarinventario_Click(object sender, EventArgs e)
        {
            frmguardarinventario i3 = new frmguardarinventario();
            Hide();
            i3.ShowDialog();
            Show();
        }
        //boton formulario guardar impuesto
        private void btnguardarimpuesto_Click(object sender, EventArgs e)
        {
            frmguardarimpuesto i4 = new frmguardarimpuesto();
            Hide();
            i4.ShowDialog();
            Show();
        }
        //boton formulario guardar bancos
        private void btnguardarbancos_Click(object sender, EventArgs e)
        {
            frmguardarbancos i5 = new frmguardarbancos();
            Hide();
            i5.ShowDialog();
            Show();
        }
        //boton formulario guardar antiguedad cxc
        private void btnguardarantiguedadcxc_Click(object sender, EventArgs e)
        {
            frmguardarantiguedadcxc i6 = new frmguardarantiguedadcxc();
            Hide();
            i6.ShowDialog();
            Show();
        }
    }
}
