using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmEditaSeguridad : MaterialForm
    {
        public int IdSeguridad { get; set; }

        private readonly Cls_Seguridad Obj_Seguridad = new Cls_Seguridad();
        private DataTable dt;

        public frmEditaSeguridad()
        {
            InitializeComponent();
        }

        private void frmEditaSeguridad_Load(object sender, EventArgs e)
        {
            llenar_empleados();
            if (IdSeguridad != 0)
                llenar_datos_seguridad();
        }

        private void llenar_empleados()
        {
            dt = Obj_Seguridad.ConsultarEmpleados();
            if (dt == null) return;
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = dt.Columns.Contains("StrNombre") ? "StrNombre" : "strNombre";
            comboBox1.ValueMember = "IdEmpleado";
        }

        private void llenar_datos_seguridad()
        {
            DataTable dtSeg = Obj_Seguridad.ConsultarSeguridad(IdSeguridad);
            if (dtSeg == null || dtSeg.Rows.Count == 0) return;

            DataRow row = dtSeg.Rows[0];
            comboBox1.SelectedValue = row["IdEmpleado"];
            txtUsuario.Text = row["StrUsuario"].ToString();
            txtClave.Text = row["StrClave"].ToString();
        }

        private bool Validar()
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un empleado.");
                comboBox1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un usuario.");
                txtUsuario.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Debe ingresar una clave.");
                txtClave.Focus();
                return false;
            }
            return true;
        }

        private void Guardar()
        {
            if (!Validar()) return;

            Obj_Seguridad.IdSeguridad = IdSeguridad;
            Obj_Seguridad.IdEmpleado = Convert.ToInt32(comboBox1.SelectedValue);
            Obj_Seguridad.StrUsuario = txtUsuario.Text.Trim();
            Obj_Seguridad.StrClave = txtClave.Text.Trim();
            Obj_Seguridad.StrUsuarioModifico = "Sofia";

            string mensaje = Obj_Seguridad.Guardar();
            MessageBox.Show(mensaje);
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
