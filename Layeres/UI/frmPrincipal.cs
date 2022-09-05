using ExamenGym.Layeres.UI.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenGym
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Layeres.UI.frmRegistrar frm = new Layeres.UI.frmRegistrar();
            frm.ShowDialog();
        }

        private void rutinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Layeres.UI.frmRutinas frm = new Layeres.UI.frmRutinas();
            frm.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepRutinasPorCliente frm = new frmRepRutinasPorCliente();
            frm.Show();
        }
    }
}
