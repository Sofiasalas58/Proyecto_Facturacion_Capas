using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;



namespace Capa_AccesoDatos
{
    public class Cls_parametros
    {
        public string Nombre {  get; set; }
        public object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection Direccionparametro { get; set; }

        public Cls_parametros(string Objnombre, Object ObjValor)

        {
            Nombre = Objnombre;
            Valor = ObjValor;
            Direccionparametro =ParameterDirection.Input;
        }

        public Cls_parametros(string Objnombre, SqlDbType ObjTipoDato, Int32 ObjTamaño)

        {
            Nombre = Objnombre;
            TipoDato = ObjTipoDato;
            Tamaño = ObjTamaño;
            Direccionparametro = ParameterDirection.Output;
        }
    }

    public class Cls_Acceso_Datos
    {

        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader LectorDatos = null;
        SqlDataAdapter da;
        DataTable dt;

        public string AbrirBd()
        {
            string resultado = "";
            try
            {
                conexion = new SqlConnection(
                "Data Source=DESKTOP-JTSB21H;Initial Catalog=Facturacion_Cliente_Servidor;Integrated Security=True");

                conexion.Open();
            }
            catch (Exception ex)
            {
                resultado = "ERROR: No se establecio conexión con la base de datos" + ex;
            }
            return resultado;
        }

        public string CerrarBd()
        {
            string resultado = "";
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                resultado = "Falló cerrar conexión: " + ex;
            }
            return resultado;
        }


        public string Ejecutar_procedimiento(string procedimiento, List<Cls_parametros> lst)
        {
            string salida = "";
            try
            {
                int retornado;
                AbrirBd();
                SqlCommand comando = new SqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccionparametro == ParameterDirection.Input)
                        {
                            comando.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }

                        if (lst[i].Direccionparametro == ParameterDirection.Output)
                        {
                            comando.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }

                    }
                }

                retornado = comando.ExecuteNonQuery();
                CerrarBd();

                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron actualizados";
                }
            }
            catch (Exception ex) 
            {
                salida = "Error: Falló en la operación: " + ex;
            }
            return salida;

        }

        public string EjecutarComando(string sentencia)
        {
            string salida = "";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                CerrarBd();

                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }   
                else
                {
                    salida = "Los datos no fueron actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "Error: Falló en la operación: " + ex;
            }
            return salida;

        }

        public DataTable EjecutarConsulta(string cmd)
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
                return null;
            }
        }

    } 
}
