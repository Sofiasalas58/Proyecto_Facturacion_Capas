using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_AEAE_2_Sofia
{
    public class Acceso_datos
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void AbrirBd()
        {
            try
            {
                conexion = new SqlConnection(
                "Data Source=DESKTOP-JTSB21H;Initial Catalog=Facturacion_Cliente_Servidor;Integrated Security=True");

                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló conexión: " + ex.Message);
            }
        }

        public void CerrarBd()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló cerrar conexión: " + ex.Message);
            }
        }


        //Validar usuario
            public string ValidarUsuario(string usuario, string clave)
            {
                try
                {
                    string strEmpleado = "";
                    string sentencia = $"select e.strNombre, e.IdRolEmpleado " +
                    $"                 from TBLSEGURIDAD s " +
                    $"                 JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado " +
                        $"             where StrUsuario = @usuario " +
                        $"             and StrClave = @clave";
                    AbrirBd();
                    cmd = new SqlCommand();
                    cmd.Connection = conexion;
                    cmd.CommandText = sentencia;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 10;

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                LectorDatos = cmd.ExecuteReader();

                    while (LectorDatos.Read())
                    {
                        strEmpleado = Convert.ToString(LectorDatos.GetValue(0));
                    }
                    if (LectorDatos != null)
                    {
                        LectorDatos.Close();
                    }

                LectorDatos.Close();
                CerrarBd();

                return strEmpleado;

                }

                catch (Exception ex)
                {
                    MessageBox.Show("FALLA LECTURA: " + ex.Message);
                    return "";
                }

            }

        public string EjecutarComando(string sentencia)
        {
            string salida = "LOS DATOS SE ACTUALIZARON SATISFACTORIAMENTE";

            try
            {
                int retornado;

                AbrirBd();

                cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text;

                retornado = cmd.ExecuteNonQuery();

                CerrarBd();

                if (retornado > 0)
                {
                    salida = "Los datos fueron Actualizados";
                }
                else
                {
                    salida = "Los datos no fueron Actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "Falló operación: " + ex.Message;
            }

            return salida;
        }

        //Metodo consulta tabla y recuperar un conjunto de datos

        public DataTable cargartabla(string tabla, string strCondicion)
        {
            try
            {
                AbrirBd();
                string Sql = "Select * from " + tabla + " " + strCondicion;
                da = new SqlDataAdapter(Sql, conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN LA CONSULTA: " + ex.ToString());
                return null;
            }
        }

        //Método que permite consultar con una sentencia (select) o invocar un procidimiento alm

        public DataTable EjecutarComandoDatos(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLÓ OPERACIÓN: " + ex);
                return null;
            }
        }

    }

}
