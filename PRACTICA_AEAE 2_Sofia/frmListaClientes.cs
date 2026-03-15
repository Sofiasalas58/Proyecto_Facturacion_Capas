using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();


        private void LLENAR_GRID()
        {
            dgClientes.Rows.Clear();

            string sentencia = $"SELECT IdCliente, StrNombre, NumDocumento, StrTelefono" +
                $"               FROM TBLCLIENTES";

            foreach(DataRow row in dt.Rows)
            {
                dgClientes.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCliente frm = new frmEditarCliente();
            frm.IdCliente = 0;
            frm.ShowDialog();
            LLENAR_GRID();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscarporcliente.Text !="")
            {
                dgClientes.Rows.Clear();
                string sentencia = $"select * from TBLCLIENTES where strNombre like '%{txtbuscarporcliente.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                { dgClientes.Rows.Add(row[0], row[1], row[2], row[3]); }
                txtbuscarporcliente.Text = "";
            }
            else { LLENAR_GRID(); }
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dgClientes.CurrentRow.Index;

                if (MessageBox.Show($"Seguro de borrar al cliente {dgClientes[1, posActual].Value.ToString()}", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    int IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value.ToString());
                    string sentencia = $"Exec Eliminar_cliente '{IdCliente}'";
                    string Mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(Mensaje);
                    }
            }

            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dgClientes.CurrentRow.Index;
                frmEditarCliente cliente = new frmEditarCliente();

                cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());
                cliente.ShowDialog();
            }

            LLENAR_GRID();
        }
    }
}
