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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            cmbSexo.DataSource = SexoBLL.SeleccionarSexos();
            cmbSexo.DisplayMember = "Nombre";
            cmbSexo.SelectedIndex = 0;
        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente oCliente = new Cliente();

                if (pbFoto.Image == null)
                {
                    MessageBox.Show("Debe insetar una imagen");
                    return;
                }
                else
                {
                    //Fotografia
                    MemoryStream ms = new MemoryStream();
                    pbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    oCliente.Foto = ms.ToArray();
                }

                if (string.IsNullOrEmpty(mtbCedula.Text) || string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Debe agregar informacion en todos los campos");
                    return;
                }

                long cedula = Convert.ToInt64(mtbCedula.Text);
                Cliente cliente = ClienteBLL.SeleccionarClientePorCedula(cedula);
                if (cliente.Cedula.Equals(cedula))
                {
                    MessageBox.Show("Usuario ya se encuentra agregado con el nombre de " + cliente.Nombre);
                    return;
                }


                //Combo Sexo
                Sexo oSexo = (Sexo)cmbSexo.SelectedItem;

                oCliente.Cedula = Convert.ToInt64(mtbCedula.Text);
                oCliente.Nombre = txtNombre.Text;
                oCliente.CodigoSexo = Convert.ToChar(oSexo.Codigo);
                oCliente.FechaNacimiento = dtpFechaNacimiento.Value;
                oCliente.Peso = Convert.ToInt16(nudPeso.Value);
                oCliente.Estatura = Convert.ToInt16(nudEstatura.Value);
                oCliente.Cintura = Convert.ToInt16(nudCintura.Value);

                ClienteBLL.InsertarCliente(oCliente);
                MessageBox.Show("Cliente Agregado");
                this.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
