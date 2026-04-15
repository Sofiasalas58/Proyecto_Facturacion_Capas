using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmEditarproducto : MaterialForm
    {
        public int IdProducto { get; set; }

        private readonly Cls_Productos Obj_Productos = new Cls_Productos();

        public frmEditarproducto()
        {
            InitializeComponent();
        }

        private void frmEditarproducto_Load(object sender, EventArgs e)
        {
            LlenarComboCategorias();
            LlenarProducto();
        }

        private void LlenarComboCategorias()
        {
            DataTable dt = Obj_Productos.Combo_Categorias();
            cboCategoria.DataSource = dt;
            cboCategoria.DisplayMember = "StrDescripcion";
            cboCategoria.ValueMember = "IdCategoria";
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LlenarProducto()
        {
            if (IdProducto == 0)
            {
                Titulo.Text = "Ingreso nuevo producto";
                txtNombrep.Text = "";
                txtCodigo.Text = "";
                txtPrecioC.Text = "";
                txtPrecioV.Text = "";
                txtCantidad.Text = "";
                txtDetalle.Text = "";
                txtFoto.Text = "";
                if (cboCategoria.Items.Count > 0)
                    cboCategoria.SelectedIndex = 0;
                return;
            }

            Titulo.Text = "Editar producto";
            DataTable dt = Obj_Productos.Consulta_Producto(IdProducto);
            if (dt == null || dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];
            txtNombrep.Text = row["StrNombre"].ToString();
            txtCodigo.Text = row["StrCodigo"].ToString();
            txtPrecioC.Text = row["NumPrecioCompra"].ToString();
            txtPrecioV.Text = row["NumPrecioVenta"].ToString();
            txtCantidad.Text = row["NumStock"].ToString();
            txtDetalle.Text = row["StrDetalle"].ToString();
            txtFoto.Text = LeerFoto(row);

            if (row["IdCategoria"] != DBNull.Value && cboCategoria.DataSource != null)
                cboCategoria.SelectedValue = Convert.ToInt32(row["IdCategoria"]);
        }

        private static string LeerFoto(DataRow row)
        {
            if (row.Table.Columns.Contains("strFoto") && row["strFoto"] != DBNull.Value)
                return row["strFoto"].ToString();
            if (row.Table.Columns.Contains("StrFoto") && row["StrFoto"] != DBNull.Value)
                return row["StrFoto"].ToString();
            return "";
        }

        private bool Validar()
        {
            MensajeError.Clear();

            if (string.IsNullOrWhiteSpace(txtNombrep.Text))
            {
                MensajeError.SetError(txtNombrep, "Debe ingresar el nombre del producto.");
                txtNombrep.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MensajeError.SetError(txtCodigo, "Debe ingresar el código.");
                txtCodigo.Focus();
                return false;
            }

            if (cboCategoria.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                cboCategoria.Focus();
                return false;
            }

            if (!double.TryParse(txtPrecioC.Text, out _))
            {
                MensajeError.SetError(txtPrecioC, "El precio de compra debe ser numérico.");
                txtPrecioC.Focus();
                return false;
            }

            if (!double.TryParse(txtPrecioV.Text, out _))
            {
                MensajeError.SetError(txtPrecioV, "El precio de venta debe ser numérico.");
                txtPrecioV.Focus();
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out _))
            {
                MensajeError.SetError(txtCantidad, "La cantidad debe ser numérica entera.");
                txtCantidad.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            Obj_Productos.IdProducto = IdProducto;
            Obj_Productos.StrNombre = txtNombrep.Text.Trim();
            Obj_Productos.StrCodigo = txtCodigo.Text.Trim();
            Obj_Productos.NumPrecioCompra = Convert.ToDouble(txtPrecioC.Text);
            Obj_Productos.NumPrecioVenta = Convert.ToDouble(txtPrecioV.Text);
            Obj_Productos.IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
            Obj_Productos.StrDetalle = txtDetalle.Text.Trim();
            Obj_Productos.StrFoto = txtFoto.Text.Trim();
            Obj_Productos.NumStock = Convert.ToInt32(txtCantidad.Text);
            Obj_Productos.StrUsuarioModifica = "Sofia";

            string mensaje = Obj_Productos.Guardar();
            MessageBox.Show(mensaje);
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
