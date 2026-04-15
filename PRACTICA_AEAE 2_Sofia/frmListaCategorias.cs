using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmListaCategorias : Form
    {
        private readonly Cls_Categorias Obj_Categorias = new Cls_Categorias();
        private DataTable dt;

        public frmListaCategorias()
        {
            InitializeComponent();
        }

        private void frmListaCategorias_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            dataGridcategoria.Rows.Clear();
            dt = Obj_Categorias.Consulta_Categorias();
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                dataGridcategoria.Rows.Add(row["IdCategoria"], row["StrDescripcion"]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridcategoria.Rows.Clear();
            string filtro = txtbuscarcategoria.Text.Trim();
            dt = Obj_Categorias.Filtrar_Categorias(filtro);
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                dataGridcategoria.Rows.Add(row["IdCategoria"], row["StrDescripcion"]);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmEditarcategoria { IdCategoria = 0 };
            frm.ShowDialog();
            LlenarGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridcategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridcategoria.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int pos = dataGridcategoria.CurrentRow.Index;
                int id = Convert.ToInt32(dataGridcategoria.Rows[pos].Cells[0].Value);
                var frm = new frmEditarcategoria { IdCategoria = id };
                frm.ShowDialog();
                LlenarGrid();
                return;
            }

            if (dataGridcategoria.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int pos = dataGridcategoria.CurrentRow.Index;
                int id = Convert.ToInt32(dataGridcategoria.Rows[pos].Cells[0].Value);
                string desc = dataGridcategoria.Rows[pos].Cells[1].Value?.ToString() ?? "";

                if (MessageBox.Show(
                        $"¿Seguro de borrar la categoría «{desc}»? (No podrá borrarse si hay productos asociados.)",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = Obj_Categorias.Borrar_Categoria(id);
                    MessageBox.Show(mensaje);
                    LlenarGrid();
                }
            }
        }
    }
}
