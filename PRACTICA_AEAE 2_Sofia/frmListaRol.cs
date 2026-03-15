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
    public partial class frmListaRol : Form
    {
        public frmListaRol()
        {
            InitializeComponent();
        }

        private void dataGridRolEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridRolEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmEditarcategoria frm = new frmEditarcategoria();
                frm.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
