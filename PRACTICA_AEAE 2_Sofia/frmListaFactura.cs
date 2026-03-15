using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmListaFactura : Form
    {
        public frmListaFactura()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscarcategoria_Click(object sender, EventArgs e)
        {

        }

        private void dataGridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridFactura.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmEditaFactura frm = new frmEditaFactura();
                frm.ShowDialog();
            }
        }
    }
}
