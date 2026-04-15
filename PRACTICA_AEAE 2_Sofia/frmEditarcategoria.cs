using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmEditarcategoria : MaterialForm
    {
        public int IdCategoria { get; set; }

        private readonly Cls_Categorias Obj_Categorias = new Cls_Categorias();

        public frmEditarcategoria()
        {
            InitializeComponent();
        }

        private void frmEditarcategoria_Load(object sender, EventArgs e)
        {
            if (IdCategoria == 0)
            {
                Titulo.Text = "Nueva categoría";
                txtDescripcion.Text = "";
                return;
            }

            Titulo.Text = "Editar categoría";
            DataTable dt = Obj_Categorias.Consulta_Categoria(IdCategoria);
            if (dt == null || dt.Rows.Count == 0) return;

            txtDescripcion.Text = dt.Rows[0]["StrDescripcion"].ToString();
        }

        private bool Validar()
        {
            MensajeError.Clear();
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MensajeError.SetError(txtDescripcion, "Debe ingresar la descripción.");
                txtDescripcion.Focus();
                return false;
            }

            return true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            Obj_Categorias.IdCategoria = IdCategoria;
            Obj_Categorias.StrDescripcion = txtDescripcion.Text.Trim();
            Obj_Categorias.StrUsuarioModifico = "Sofia";

            string mensaje = Obj_Categorias.Guardar();
            MessageBox.Show(mensaje);
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
