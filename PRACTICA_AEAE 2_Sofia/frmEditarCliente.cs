using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmEditarCliente : MaterialForm
    {
        public int IdCliente { get; set; }

        private readonly Cls_Clientes Obj_Clientes = new Cls_Clientes();

        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                lblTitulo.Text = "Ingreso nuevo cliente";
                return;
            }

            lblTitulo.Text = "Editar cliente";
            DataTable dt = Obj_Clientes.Consulta_Cliente(IdCliente);
            if (dt == null || dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];
            txtNombre.Text = row["StrNombre"].ToString();
            txtDocumento.Text = row["NumDocumento"].ToString();
            txtDireccion.Text = row["StrDireccion"].ToString();
            txtTelefono.Text = row["StrTelefono"].ToString();
            txtEmail.Text = row["StrEmail"].ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validar()
        {
            MensajeError.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MensajeError.SetError(txtNombre, "Debe ingresar el nombre del cliente.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "Debe ingresar el documento.");
                txtDocumento.Focus();
                return false;
            }

            if (!long.TryParse(txtDocumento.Text.Trim(), out _))
            {
                MensajeError.SetError(txtDocumento, "El documento debe ser numérico.");
                txtDocumento.Focus();
                return false;
            }

            return true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            Obj_Clientes.IdCliente = IdCliente;
            Obj_Clientes.StrNombre = txtNombre.Text.Trim();
            Obj_Clientes.NumDocumento = Convert.ToInt64(txtDocumento.Text.Trim());
            Obj_Clientes.StrDireccion = txtDireccion.Text.Trim();
            Obj_Clientes.StrTelefono = txtTelefono.Text.Trim();
            Obj_Clientes.StrEmail = txtEmail.Text.Trim();
            Obj_Clientes.StrUsuarioModifica = "Sofia";

            string mensaje = Obj_Clientes.Guardar();
            MessageBox.Show(mensaje);
            Close();
        }
    }
}
