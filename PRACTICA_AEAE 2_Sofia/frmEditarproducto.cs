using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmEditarproducto : MaterialForm
    {
        public int IdProducto { get; set; } 
        Acceso_datos Acceso = new Acceso_datos();
        DataTable dt = new DataTable();

        public frmEditarproducto()
        {
            InitializeComponent();
        }

        private void LLENAR_PRODUCTO()
        {
            if (IdProducto == 0)
            {
                _IDP.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                string sentencia = $"select * from TBLPRODUCTO where IdProducto = {IdProducto}";

                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    txtNombrep.Text = row["StrNombre"].ToString();
                    txtCodigo.Text = row["StrCodigo"].ToString();
                    txtDetalle.Text = row["StrDetalle"].ToString();
                    txtCategoria.Text = row["StrCategoria"].ToString();
                    txtPrecioC.Text = row["NumPrecioCompra"].ToString();
                    txtPrecioV.Text = row["NumPrecioVenta"].ToString();
                    txtCantidad.Text = row["NumStock"].ToString();
                   
                }
            }
        }
        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void frmEditarproducto_Load(object sender, EventArgs e)
        {
            LLENAR_PRODUCTO();
        }



        public bool Guardar()
        {
            bool actualizado = false;

            if (validar())
            {
                try
                {
                    decimal precioCompra = Convert.ToDecimal(txtPrecioC.Text);
                    decimal precioVenta = Convert.ToDecimal(txtPrecioV.Text);
                    int stock = Convert.ToInt32(txtCantidad.Text);

                    string sentencia =
                    $"Exec [actualizar_Producto] {IdProducto}, " +
                    $"'{txtNombrep.Text}', " +
                    $"'{txtCodigo.Text}', " +
                    $"'{txtDetalle.Text}', " +
                    $"'{txtCategoria.Text}', " +
                    $"{precioCompra.ToString(System.Globalization.CultureInfo.InvariantCulture)}, " +
                    $"{precioVenta.ToString(System.Globalization.CultureInfo.InvariantCulture)}, " +
                    $"{stock}, " +
                    $"'Sofia', " +
                    $"'{DateTime.Now.ToString("yyyy-MM-dd")}'";

                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló la operación: " + ex.Message);
                    actualizado = false;
                }
            }

            return actualizado;
        }

        private bool validar()
        {
            bool correcto = true;

            // Nombre
            if (string.IsNullOrWhiteSpace(txtNombrep.Text))
            {
                MensajeError.SetError(txtNombrep, "Debe ingresar el nombre del producto");
                txtNombrep.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtNombrep, "");
            }

            // Código
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MensajeError.SetError(txtCodigo, "Debe ingresar el código");
                txtCodigo.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtCodigo, "");
            }

            // Categoría
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MensajeError.SetError(txtCategoria, "Debe ingresar una categoría");
                txtCategoria.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtCategoria, "");
            }

            // Precio Compra
            if (!decimal.TryParse(txtPrecioC.Text, out decimal precioCompra))
            {
                MensajeError.SetError(txtPrecioC, "El precio de compra debe ser numérico");
                txtPrecioC.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtPrecioC, "");
            }

            // Precio Venta
            if (!decimal.TryParse(txtPrecioV.Text, out decimal precioVenta))
            {
                MensajeError.SetError(txtPrecioV, "El precio de venta debe ser numérico");
                txtPrecioV.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtPrecioV, "");
            }

            // Stock
            if (!int.TryParse(txtCantidad.Text, out int stock))
            {
                MensajeError.SetError(txtCantidad, "La cantidad debe ser numérica");
                txtCantidad.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtCantidad, "");
            }

            return correcto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Guardar())
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
