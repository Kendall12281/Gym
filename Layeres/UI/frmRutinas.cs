using ExamenGym.Layeres.BLL;
using ExamenGym.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenGym.Layeres.UI
{
    public partial class frmRutinas : Form
    {
        public frmRutinas()
        {
            InitializeComponent();
        }

        private void frmRutinas_Load(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = ClienteBLL.SeleccionarClientes();
        }

        private void Refresh()
        {
            try
            {
                Cliente oCliente = dgvArticulos.SelectedRows[0].DataBoundItem as Cliente;
                List<Entrenamiento> ListadeRutinasCliente = EntrenamientoBLL.SeleccionarEntrenamientosPorCedula(oCliente.Cedula);
                List<Entrenamiento> ListaTodasDiposnibles = EntrenamientoBLL.SeleccionarEntrenamientosPorSexoEdad(oCliente.CodigoSexo, oCliente.Edad);
                List<Entrenamiento> ListaDisponibles = new List<Entrenamiento>();

                if(ListadeRutinasCliente.Count > 0)
                {
                    for (int i = 0; i < ListaTodasDiposnibles.Count; i++)
                    {
                        for (int e = 0; e < ListadeRutinasCliente.Count; e++)
                        {
                            if(ListaTodasDiposnibles.ElementAt(i).Id == ListadeRutinasCliente.ElementAt(e).Id)
                            {
                                ListaTodasDiposnibles.RemoveAt(i);
                            }
                        }
                    }

                    ListaDisponibles = ListaTodasDiposnibles;
                }
                else
                {
                    ListaDisponibles = EntrenamientoBLL.SeleccionarEntrenamientosPorSexoEdad(oCliente.CodigoSexo, oCliente.Edad);
                }

                lstEntrenamientosDisponibles.DataSource = null;
                lstEntrenamientosDisponibles.DataSource = ListaDisponibles;
                lstEntrenamientosDisponibles.DisplayMember = "Descripcion";

                lstEntrenamientosAsignados.DataSource = null;
                lstEntrenamientosAsignados.DataSource = ListadeRutinasCliente;
                lstEntrenamientosAsignados.DisplayMember = "Descripcion";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvArticulos.SelectedRows.Count > 0)
                {
                    Cliente oCliente = dgvArticulos.SelectedRows[0].DataBoundItem as Cliente;

                    txtIMC.Text = ClienteBLL.ObtenerIMC(oCliente).ToString("00.00");
                    txtIMB.Text = ClienteBLL.ObtenerIMB(oCliente).ToString("00.00");
                    txtICA.Text = ClienteBLL.ObtenerICA(oCliente).ToString("00.00");

                    Refresh();

                    pbFoto.Image = Image.FromStream(new MemoryStream(oCliente.Foto));
                }
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((lstEntrenamientosDisponibles.SelectedIndex < 0))
                {
                    MessageBox.Show("Debe seleccionar un entrenamiento");
                    return;
                }

                Cliente oCliente = dgvArticulos.SelectedRows[0].DataBoundItem as Cliente;
                Entrenamiento oEntrenamiento = (Entrenamiento)lstEntrenamientosDisponibles.SelectedItem;

                Rutina oRutina = new Rutina()
                {
                    Cedula = oCliente.Cedula,
                    EntrenamientoId = oEntrenamiento.Id
                };

                RutinaBLL.InsertarRutina(oRutina);

                Refresh();

                MessageBox.Show("Rutina Insertada");
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if((lstEntrenamientosAsignados.SelectedIndex < 0))
                {
                    MessageBox.Show("Debe seleccionar un entrenamiento");
                    return;
                }

                Cliente oCliente = dgvArticulos.SelectedRows[0].DataBoundItem as Cliente;
                Entrenamiento oEntrenamiento = (Entrenamiento)lstEntrenamientosAsignados.SelectedItem;

                Rutina oRutina = new Rutina()
                {
                    Cedula = oCliente.Cedula,
                    EntrenamientoId = oEntrenamiento.Id
                };

                RutinaBLL.EliminarRutina(oRutina);

                Refresh();

                MessageBox.Show("Rutina Eliminada");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
