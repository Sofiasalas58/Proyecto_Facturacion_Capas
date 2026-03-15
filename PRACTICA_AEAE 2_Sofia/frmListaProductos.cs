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
    public partial class frmListaProductos : Form
    {
        Acceso_datos Acceso = new Acceso_datos();
        DataTable dt =new DataTable();
        public frmListaProductos()
        {
            InitializeComponent();
        }

        private void LLENAR_GRID()
        {
            dataGridproductos.Rows.Clear();

            string sentencia = $"Select IdProducto, StrNombre, StrCodigo, " +
                               $"NumPrecioCompra, NumPrecioVenta, " +
                               $"IdCategoria, StrDetalle" +
                               $"NumStock, DtmFechaModifica," +
                               $"StrUsuarioModifica" +
                               $"From TBLPRODUCTO";

            dt = Acceso.EjecutarComandoDatos(sentencia);

            foreach (DataRow row in dt.Rows)
            {
                dataGridproductos.Rows.Add(
                    row[0],  // IdProducto
                    row[1],  // StrNombre
                    row[2],  // StrCodigo
                    row[3],  // NumPrecioCompra
                    row[4],  // NumPrecioVenta
                    row[5],  // IdCategoria
                    row[6],  // StrDetalle
                    row[7],  // NumStock
                    row[8],  // DtmFechaModifica
                    row[9]   // StrUsuarioModifica
                    
                );
            }
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarproducto frm = new frmEditarproducto();
            frm.IdProducto = 0;  
            frm.ShowDialog();
            LLENAR_GRID();
        }

        private void dataGridproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridproductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActual = dataGridproductos.CurrentRow.Index;

                frmEditarproducto frm = new frmEditarproducto();
                frm.IdProducto = Convert.ToInt32(dataGridproductos[0, posActual].Value.ToString());
                frm.ShowDialog();
            }

            //Borrar
            if (dataGridproductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {
                int posActual = dataGridproductos.CurrentRow.Index;

                if (MessageBox.Show($"Seguro de borrar el producto {dataGridproductos[1, posActual].Value.ToString()}",
                    "CONFIRMACION",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int IdProducto = Convert.ToInt32(dataGridproductos[0, posActual].Value.ToString());
                    string sentencia = $"DELETE FROM TBLPRODUCTO WHERE IdProducto = {IdProducto}";
                    string Mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(Mensaje);
                }
            }

            LLENAR_GRID();
        }
     
    }
}
