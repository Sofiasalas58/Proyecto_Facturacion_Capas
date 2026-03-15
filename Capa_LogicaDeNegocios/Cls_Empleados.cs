using System;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    /// <summary>
    /// Clase para administración de Empleados (CRUD). Comunica presentación con Capa_AccesoDatos.
    /// </summary>
    public class Cls_Empleados
    {
        private readonly Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        // Atributos según campos de TBLEMPLEADO
        public int IdEmpleado { get; set; }
        public string StrNombre { get; set; }
        public long NumDocumento { get; set; }
        public string StrDireccion { get; set; }
        public string StrTelefono { get; set; }
        public string StrEmail { get; set; }
        public int IdRolEmpleado { get; set; }
        public DateTime DtmIngreso { get; set; }
        public DateTime? DtmRetiro { get; set; }
        public string StrDatosAdicionales { get; set; }
        public string StrUsuarioModifico { get; set; }

        /// <summary>Consulta todos los empleados.</summary>
        public DataTable Consulta_Empleado()
        {
            string sentencia =
                "SELECT IdEmpleado, StrNombre, NumDocumento, StrDireccion, " +
                "       StrTelefono, StrEmail " +
                "FROM TBLEMPLEADO";
            return AccesoDatos.EjecutarConsulta(sentencia);
        }

        /// <summary>Consulta un empleado por IdEmpleado.</summary>
        public DataTable Consulta_Empleado(int idEmpleado)
        {
            string sentencia =
                "SELECT IdEmpleado, StrNombre, NumDocumento, StrDireccion, " +
                "       StrTelefono, StrEmail, IdRolEmpleado, DtmIngreso, DtmRetiro, StrDatosAdicionales " +
                "FROM TBLEMPLEADO " +
                $"WHERE IdEmpleado = {idEmpleado}";
            return AccesoDatos.EjecutarConsulta(sentencia);
        }

        /// <summary>Filtra empleados por nombre (StrNombre).</summary>
        public DataTable Filtrar_Empleado(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return Consulta_Empleado();
            string sentencia =
                "SELECT IdEmpleado, StrNombre, NumDocumento, StrDireccion, " +
                "       StrTelefono, StrEmail " +
                "FROM TBLEMPLEADO " +
                $"WHERE StrNombre LIKE '%{filtro.Replace("'", "''")}%'";
            return AccesoDatos.EjecutarConsulta(sentencia);
        }

        /// <summary>Consulta todos los roles para llenar combo (TBLROLES).</summary>
        public DataTable Consulta_Roles()
        {
            string sentencia =
                "SELECT IdRolEmpleado, StrDescripcion " +
                "FROM TBLROLES " +
                "ORDER BY StrDescripcion";
            return AccesoDatos.EjecutarConsulta(sentencia);
        }

        /// <summary>Inserta o actualiza un empleado. IdEmpleado = 0 → INSERT, sino UPDATE.</summary>
        public string Guardar()
        {
            string usuarioModifico = string.IsNullOrEmpty(StrUsuarioModifico) ? "Sofia" : StrUsuarioModifico;
            string sentencia;

            if (IdEmpleado == 0)
            {
                sentencia =
                    "INSERT INTO TBLEMPLEADO " +
                    "(StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, " +
                    " IdRolEmpleado, DtmIngreso, DtmRetiro, StrDatosAdicionales, DtmFechaModifica, StrUsuarioModifico) VALUES (" +
                    $"'{StrNombre?.Replace("'", "''")}', {NumDocumento}, '{StrDireccion?.Replace("'", "''")}', '{StrTelefono?.Replace("'", "''")}', '{StrEmail?.Replace("'", "''")}', " +
                    $"{IdRolEmpleado}, '{DtmIngreso:yyyy-MM-dd}', " +
                    (DtmRetiro.HasValue ? $"'{DtmRetiro:yyyy-MM-dd}'" : "NULL") + ", " +
                    $"'{StrDatosAdicionales?.Replace("'", "''")}', GETDATE(), '{usuarioModifico}')";
            }
            else
            {
                sentencia =
                    "UPDATE TBLEMPLEADO SET " +
                    $"StrNombre = '{StrNombre?.Replace("'", "''")}', NumDocumento = {NumDocumento}, " +
                    $"StrDireccion = '{StrDireccion?.Replace("'", "''")}', StrTelefono = '{StrTelefono?.Replace("'", "''")}', StrEmail = '{StrEmail?.Replace("'", "''")}', " +
                    $"IdRolEmpleado = {IdRolEmpleado}, DtmIngreso = '{DtmIngreso:yyyy-MM-dd}', " +
                    $"DtmRetiro = " + (DtmRetiro.HasValue ? $"'{DtmRetiro:yyyy-MM-dd}', " : "NULL, ") +
                    $"StrDatosAdicionales = '{StrDatosAdicionales?.Replace("'", "''")}', DtmFechaModifica = GETDATE(), StrUsuarioModifico = '{usuarioModifico}' " +
                    $"WHERE IdEmpleado = {IdEmpleado}";
            }

            return AccesoDatos.EjecutarComando(sentencia);
        }

        /// <summary>Elimina un empleado por IdEmpleado.</summary>
        public string Borrar_Empleado(int idEmpleado)
        {
            string sentencia = $"DELETE FROM TBLEMPLEADO WHERE IdEmpleado = {idEmpleado}";
            return AccesoDatos.EjecutarComando(sentencia);
        }
    }
}
