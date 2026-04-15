using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmListaProductos : Form
    {
        private readonly Cls_Productos Obj_Productos = new Cls_Productos();
        private DataTable dt;

        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            dataGridproductos.Rows.Clear();
            dt = Obj_Productos.Consulta_Productos();
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                dataGridproductos.Rows.Add(
                    row["IdProducto"],
                    row["StrNombre"],
                    row["StrCodigo"],
                    row["NumPrecioCompra"],
                    row["NumPrecioVenta"],
                    row["StrCategoriaDesc"],
                    row["StrDetalle"],
                    row["NumStock"]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridproductos.Rows.Clear();
            string filtro = txtbuscarproducto.Text.Trim();
            dt = Obj_Productos.Filtrar_Productos(filtro);
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                dataGridproductos.Rows.Add(
                    row["IdProducto"],
                    row["StrNombre"],
                    row["StrCodigo"],
                    row["NumPrecioCompra"],
                    row["NumPrecioVenta"],
                    row["StrCategoriaDesc"],
                    row["StrDetalle"],
                    row["NumStock"]);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmEditarproducto { IdProducto = 0 };
            frm.ShowDialog();
            LlenarGrid();
        }

        private void dataGridproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridproductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int pos = dataGridproductos.CurrentRow.Index;
                int id = Convert.ToInt32(dataGridproductos.Rows[pos].Cells[0].Value);
                var frm = new frmEditarproducto { IdProducto = id };
                frm.ShowDialog();
                LlenarGrid();
                return;
            }

            if (dataGridproductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int pos = dataGridproductos.CurrentRow.Index;
                int idProducto = Convert.ToInt32(dataGridproductos.Rows[pos].Cells[0].Value);
                string nombre = dataGridproductos.Rows[pos].Cells[1].Value?.ToString() ?? "";

                if (MessageBox.Show(
                        $"¿Seguro de borrar el producto {nombre}?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = Obj_Productos.Borrar_Producto(idProducto);
                    MessageBox.Show(mensaje);
                    LlenarGrid();
                }
            }
        }
    }
}
