using System;
using System.Data;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmEditaEmpleados : MaterialForm
    {
        public int IdEmpleado { get; set; }

        private readonly Cls_Empleados Obj_Empleados = new Cls_Empleados();
        private DataTable dt;

        public frmEditaEmpleados()
        {
            InitializeComponent();
        }

        private void frmEditaEmpleados_Load(object sender, EventArgs e)
        {
            llenar_combo();
            if (IdEmpleado != 0)
                llenar_campos();
        }

        private void llenar_combo()
        {
            dt = Obj_Empleados.Consulta_Roles();
            if (dt == null) return;
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "StrDescripcion";
            comboBox1.ValueMember = "IdRolEmpleado";
        }

        private void llenar_campos()
        {
            dt = Obj_Empleados.Consulta_Empleado(IdEmpleado);
            if (dt == null || dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];
            txtNombreEmpleados.Text = (row.Table.Columns.Contains("StrNombre") ? row["StrNombre"] : row["strNombre"]).ToString();
            txtDocumento.Text = row["NumDocumento"].ToString();
            txtdireccion.Text = row["StrDireccion"].ToString();
            txtTelefono.Text = row["StrTelefono"].ToString();
            txtEmail.Text = row["StrEmail"].ToString();

            if (row["IdRolEmpleado"] != DBNull.Value && comboBox1.DataSource != null)
                comboBox1.SelectedValue = row["IdRolEmpleado"];

            if (row["DtmIngreso"] != DBNull.Value)
                dateTimePicker1.Value = Convert.ToDateTime(row["DtmIngreso"]);
            if (row["DtmRetiro"] != DBNull.Value)
                dateTimePicker2.Value = Convert.ToDateTime(row["DtmRetiro"]);

            textBox2.Text = row["StrDatosAdicionales"].ToString();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombreEmpleados.Text))
            {
                MessageBox.Show("Debe ingresar el nombre.");
                txtNombreEmpleados.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Debe ingresar el documento.");
                txtDocumento.Focus();
                return false;
            }
            if (!long.TryParse(txtDocumento.Text, out _))
            {
                MessageBox.Show("El documento debe ser numérico.");
                txtDocumento.Focus();
                return false;
            }
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un rol.");
                comboBox1.Focus();
                return false;
            }
            return true;
        }

        private void Guardar()
        {
            if (!Validar()) return;

            Obj_Empleados.IdEmpleado = IdEmpleado;
            Obj_Empleados.StrNombre = txtNombreEmpleados.Text.Trim();
            Obj_Empleados.NumDocumento = Convert.ToInt64(txtDocumento.Text);
            Obj_Empleados.StrDireccion = txtdireccion.Text.Trim();
            Obj_Empleados.StrTelefono = txtTelefono.Text.Trim();
            Obj_Empleados.StrEmail = txtEmail.Text.Trim();
            Obj_Empleados.IdRolEmpleado = Convert.ToInt32(comboBox1.SelectedValue);
            Obj_Empleados.DtmIngreso = dateTimePicker1.Value;
            Obj_Empleados.DtmRetiro = dateTimePicker2.Checked ? dateTimePicker2.Value : (DateTime?)null;
            Obj_Empleados.StrDatosAdicionales = textBox2.Text.Trim();
            Obj_Empleados.StrUsuarioModifico = "Sofia";

            string mensaje = Obj_Empleados.Guardar();
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
