using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;
using System.Data.SqlClient;



namespace Capa_LogicaDeNegocios
{
    public class Validar_Usuario
    {
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public int C_Idempleado { get; private set; }


        public void ValidarUsuario()
        {
            C_Idempleado = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection(
                    "Data Source=DESKTOP-JTSB21H;Initial Catalog=Facturacion_Cliente_Servidor;Integrated Security=True"))
                {
                    string sentencia =
                        "SELECT e.IdEmpleado " +
                        "FROM TBLSEGURIDAD s " +
                        "JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado " +
                        "WHERE s.StrUsuario = @usuario AND s.StrClave = @clave";

                    using (SqlCommand cmd = new SqlCommand(sentencia, conexion))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@usuario", C_StrUsuario);
                        cmd.Parameters.AddWithValue("@clave", C_StrClave);

                        conexion.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            C_Idempleado = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta " + ex);
            }   

        }

    }
}
