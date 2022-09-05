using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenGym.Layeres.UI.Reporte
{
    public partial class frmRepRutinasPorCliente : Form
    {
        public frmRepRutinasPorCliente()
        {
            InitializeComponent();
        }

        private void frmRepRutinasPorCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examen2021CIIIDataSetReporte.PA_SeleccionarRutinasPorClientes' table. You can move, or remove it, as needed.
            this.pA_SeleccionarRutinasPorClientesTableAdapter.Fill(this.examen2021CIIIDataSetReporte.PA_SeleccionarRutinasPorClientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
