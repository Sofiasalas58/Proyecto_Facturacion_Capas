using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmEditarCliente : MaterialForm
    {
        public int IdCliente { get; set; }
        Acceso_datos Acceso = new Acceso_datos();
        DataTable dt = new DataTable();
        
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void LLENAR_CLIENTE()
        {
            if (IdCliente == 0)
            {
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else
            {
                string sentencia = $"select * from TBLCLIENTES where IdCliente = {IdCliente}";

                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    txtNombre.Text = row[1].ToString();
                    txtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                }
            }
        }


        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            LLENAR_CLIENTE();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Actualizaciones

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Cliente] {IdCliente},'{txtNombre.Text}',{txtDocumento.Text} ,'{txtDireccion.Text}','{txtTelefono.Text}', '{txtEmail.Text}','Javier','{DateTime.Now.ToShortDateString()}'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }
        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "debeingresar el nombre del Cliente");
                txtNombre.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombre, ""); }

            if (txtDocumento.Text == "")
            {
                MensajeError.SetError(txtDocumento, "debe ingresar el documento");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtDocumento, ""); }
            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El Documento debe ser numerico");

                txtDocumento.Focus();
                return false;
            }
            MensajeError.SetError(txtDocumento, "");
            return errorCampos;
        }

        //validar si un valor es númerico
        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
