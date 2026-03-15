using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            frmListaClientes frm = new frmListaClientes();
            AbrirForm(frm);
        }

        private void AbrirForm(Form formHijo)
        {
            if (this.pnlcontenedor.Controls.Count > 0)
                this.pnlcontenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.pnlcontenedor.Controls.Add(formHijo);

            formHijo.Show();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            frmListaProductos frm = new frmListaProductos();
            AbrirForm(frm);
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            frmListaCategorias frm = new frmListaCategorias();
            AbrirForm(frm);
        }

        private void btnfacturas_Click(object sender, EventArgs e)
        {
            frmListaFactura frm = new frmListaFactura();
            AbrirForm(frm);
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            frmListaEmpleados frm = new frmListaEmpleados();
            AbrirForm(frm);
        }

        private void btnroles_Click(object sender, EventArgs e)
        {
            frmListaRol frm = new frmListaRol();
            AbrirForm(frm);
        }

        private void btnseguridad_Click(object sender, EventArgs e)
        {
            frmListaSeguridad frm = new frmListaSeguridad();
            AbrirForm(frm);
        }

        private void btninformes_Click(object sender, EventArgs e)
        {
            //frm frm = new frm();
            //AbrirForm(frm);
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            frmAyuda frm = new frmAyuda();
            AbrirForm(frm);
        }

        private void btnacercade_Click(object sender, EventArgs e)
        {
            frmAcercade frm = new frmAcercade();
            AbrirForm(frm);
        }

        private void pnlcontenedor_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
