using System;
using System.Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmListaEmpleados : Form
    {
        private readonly Cls_Empleados Obj_Empleados = new Cls_Empleados();
        private DataTable dt;

        public frmListaEmpleados()
        {
            InitializeComponent();
        }

        private void frmListaEmpleados_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void llenar_grid()
        {
            dataGridEmpleados.Rows.Clear();
            dt = Obj_Empleados.Consulta_Empleado();
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                object nombre = row.Table.Columns.Contains("StrNombre") ? row["StrNombre"] : row["strNombre"];
                dataGridEmpleados.Rows.Add(
                    row["IdEmpleado"],
                    nombre,
                    row["NumDocumento"],
                    row["StrDireccion"],
                    row["StrTelefono"],
                    row["StrEmail"]
                );
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridEmpleados.Rows.Clear();
            string filtro = txtbuscarEmpleado.Text.Trim();
            dt = Obj_Empleados.Filtrar_Empleado(filtro);
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                object nombre = row.Table.Columns.Contains("StrNombre") ? row["StrNombre"] : row["strNombre"];
                dataGridEmpleados.Rows.Add(
                    row["IdEmpleado"],
                    nombre,
                    row["NumDocumento"],
                    row["StrDireccion"],
                    row["StrTelefono"],
                    row["StrEmail"]
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditaEmpleados frm = new frmEditaEmpleados();
            frm.IdEmpleado = 0;
            frm.ShowDialog();
            llenar_grid();
        }

        private void dataGridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int pos = dataGridEmpleados.CurrentRow.Index;
                int idEmpleado = Convert.ToInt32(dataGridEmpleados.Rows[pos].Cells["IdEmpleado"].Value);
                frmEditaEmpleados frm = new frmEditaEmpleados();
                frm.IdEmpleado = idEmpleado;
                frm.ShowDialog();
                llenar_grid();
            }

            if (dataGridEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int pos = dataGridEmpleados.CurrentRow.Index;
                int idEmpleado = Convert.ToInt32(dataGridEmpleados.Rows[pos].Cells["IdEmpleado"].Value);
                string nombre = dataGridEmpleados.Rows[pos].Cells["strnombreEmpleado"].Value?.ToString() ?? "";

                if (MessageBox.Show(
                    $"¿Seguro de borrar al empleado {nombre}?",
                    "CONFIRMACIÓN",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = Obj_Empleados.Borrar_Empleado(idEmpleado);
                    MessageBox.Show(mensaje);
                    llenar_grid();
                }
            }
        }
    }
}
