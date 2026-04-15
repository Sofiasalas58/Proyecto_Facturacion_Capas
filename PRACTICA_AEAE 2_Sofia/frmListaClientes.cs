using System;
using System
    .Data;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmListaClientes : Form
    {
        private readonly Cls_Clientes Obj_Clientes = new Cls_Clientes();
        private DataTable dt;

        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            dgClientes.Rows.Clear();
            dt = Obj_Clientes.Consulta_Clientes();
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                dgClientes.Rows.Add(
                    row["IdCliente"],
                    row["StrNombre"],
                    row["NumDocumento"],
                    row["StrDireccion"],
                    row["StrTelefono"],
                    row["StrEmail"]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgClientes.Rows.Clear();
            string filtro = txtbuscarporcliente.Text.Trim();
            dt = Obj_Clientes.Filtrar_Clientes(filtro);
            if (dt == null) return;

            foreach (DataRow row in dt.Rows)
            {
                dgClientes.Rows.Add(
                    row["IdCliente"],
                    row["StrNombre"],
                    row["NumDocumento"],
                    row["StrDireccion"],
                    row["StrTelefono"],
                    row["StrEmail"]);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var frm = new frmEditarCliente { IdCliente = 0 };
            frm.ShowDialog();
            LlenarGrid();
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int pos = dgClientes.CurrentRow.Index;
                int idCliente = Convert.ToInt32(dgClientes.Rows[pos].Cells[0].Value);
                string nombre = dgClientes.Rows[pos].Cells[1].Value?.ToString() ?? "";

                if (MessageBox.Show(
                        $"¿Seguro de borrar al cliente {nombre}?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = Obj_Clientes.Borrar_Cliente(idCliente);
                    MessageBox.Show(mensaje);
                    LlenarGrid();
                }
                return;
            }

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int pos = dgClientes.CurrentRow.Index;
                int idCliente = Convert.ToInt32(dgClientes.Rows[pos].Cells[0].Value);
                var frm = new frmEditarCliente { IdCliente = idCliente };
                frm.ShowDialog();
                LlenarGrid();
            }
        }
    }
}
