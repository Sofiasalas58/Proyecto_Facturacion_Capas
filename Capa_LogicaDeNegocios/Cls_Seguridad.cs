using System;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    /// <summary>
    /// Clase para administración de la seguridad del sistema (usuarios y claves por empleado).
    /// </summary>
    public class Cls_Seguridad
    {
        private readonly Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public int IdSeguridad { get; set; }
        public int IdEmpleado { get; set; }
        public string StrUsuario { get; set; }
        public string StrClave { get; set; }
        public string StrUsuarioModifico { get; set; }

        /// <summary>Lista de empleados para el combo (IdEmpleado, StrNombre).</summary>
        public DataTable ConsultarEmpleados()
        {
            string sentencia =
                "SELECT IdEmpleado, StrNombre " +
                "FROM TBLEMPLEADO " +
                "ORDER BY StrNombre";
            return AccesoDatos.EjecutarConsulta(sentencia);
        }

        /// <summary>Consulta todos los registros de seguridad para el grid (IdSeguridad, nombre empleado, usuario, clave).</summary>
        public DataTable ConsultarSeguridad()
        {
            string sentencia =
                "SELECT s.IdSeguridad, e.StrNombre, s.StrUsuario, s.StrClave " +
                "FROM TBLSEGURIDAD s " +
                "JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado";
            return AccesoDatos.EjecutarConsulta(sentencia);
        }

        /// <summary>Consulta un registro de seguridad por IdSeguridad (para editar).</summary>
        public DataTable ConsultarSeguridad(int idSeguridad)
        {
            string sentencia =
                "SELECT IdSeguridad, IdEmpleado, StrUsuario, StrClave " +
                "FROM TBLSEGURIDAD " +
                $"WHERE IdSeguridad = {idSeguridad}";
            return AccesoDatos.EjecutarConsulta(sentencia);
        }

        /// <summary>Elimina un registro de seguridad.</summary>
        public string Borrar_Seguridad(int idSeguridad)
        {
            string sentencia = $"DELETE FROM TBLSEGURIDAD WHERE IdSeguridad = {idSeguridad}";
            return AccesoDatos.EjecutarComando(sentencia);
        }

        /// <summary>Inserta o actualiza. IdSeguridad = 0 → INSERT, sino UPDATE.</summary>
        public string Guardar()
        {
            string usuarioModifico = string.IsNullOrEmpty(StrUsuarioModifico) ? "Sofia" : StrUsuarioModifico;
            string usuario = StrUsuario?.Replace("'", "''") ?? "";
            string clave = StrClave?.Replace("'", "''") ?? "";
            string sentencia;

            if (IdSeguridad == 0)
            {
                sentencia =
                    "INSERT INTO TBLSEGURIDAD (IdEmpleado, StrUsuario, StrClave, DtmFechaModifica, StrUsuarioModifico) " +
                    $"VALUES ({IdEmpleado}, '{usuario}', '{clave}', GETDATE(), '{usuarioModifico}')";
            }
            else
            {
                sentencia =
                    "UPDATE TBLSEGURIDAD SET " +
                    $"IdEmpleado = {IdEmpleado}, StrUsuario = '{usuario}', StrClave = '{clave}', " +
                    $"DtmFechaModifica = GETDATE(), StrUsuarioModifico = '{usuarioModifico}' " +
                    $"WHERE IdSeguridad = {IdSeguridad}";
            }

            return AccesoDatos.EjecutarComando(sentencia);
        }
    }
}
