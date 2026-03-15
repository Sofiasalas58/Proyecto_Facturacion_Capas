using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace PRACTICA_AEAE_2_Sofia
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {            
            if (TxtUsuario.Text !="" && Txtpasword.Text != string.Empty)
            {
               Validar_Usuario Obj_validar = new Validar_Usuario();

               Obj_validar.C_StrClave = Txtpasword.Text;
               Obj_validar.C_StrUsuario = TxtUsuario.Text;

                Obj_validar.ValidarUsuario();

                if (Obj_validar.C_Idempleado != 0) 
                {
                    MessageBox.Show("Datos de identificación validos");
                    frmPrincipal frmppal = new frmPrincipal();
                    this.Hide();
                    frmppal.Show();
                }

                else
                {
                    MessageBox.Show("USUARIOS Y CLAVE NO ENCONTRADOS");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    Txtpasword.Text = "";
                }
            }

            else { MessageBox.Show("Debes ingresar un usuario y una clave"); }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
