using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmListaSeguridad : Form
    {
        private readonly Cls_Seguridad Obj_Seguridad = new Cls_Seguridad();
        private DataTable dt;

        public frmListaSeguridad()
        {
            InitializeComponent();
        }

        private void frmListaSeguridad_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void llenar_grid()
        {
            dataGridSeguridad.Rows.Clear();
            dt = Obj_Seguridad.ConsultarSeguridad();
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                object nombre = row.Table.Columns.Contains("StrNombre") ? row["StrNombre"] : row["strNombre"];
                dataGridSeguridad.Rows.Add(
                    row["IdSeguridad"],
                    nombre,
                    row["StrUsuario"],
                    row["StrClave"]
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditaSeguridad frm = new frmEditaSeguridad();
            frm.IdSeguridad = 0;
            frm.ShowDialog();
            llenar_grid();
        }

        private void dataGridSeguridad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridSeguridad.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int pos = dataGridSeguridad.CurrentRow.Index;
                int idSeguridad = Convert.ToInt32(dataGridSeguridad.Rows[pos].Cells["IdSeguridad"].Value);
                frmEditaSeguridad frm = new frmEditaSeguridad();
                frm.IdSeguridad = idSeguridad;
                frm.ShowDialog();
                llenar_grid();
            }

            if (dataGridSeguridad.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int pos = dataGridSeguridad.CurrentRow.Index;
                int idSeguridad = Convert.ToInt32(dataGridSeguridad.Rows[pos].Cells["IdSeguridad"].Value);
                string nombreEmpleado = dataGridSeguridad.Rows[pos].Cells["strnombreEmpleado"].Value?.ToString() ?? "";

                if (MessageBox.Show(
                    $"¿Seguro de borrar el registro de seguridad de {nombreEmpleado}?",
                    "CONFIRMACIÓN",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = Obj_Seguridad.Borrar_Seguridad(idSeguridad);
                    MessageBox.Show(mensaje);
                    llenar_grid();
                }
            }
        }
    }
}
