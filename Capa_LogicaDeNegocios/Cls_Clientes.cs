using System;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    /// <summary>CRUD TBLCLIENTES.</summary>
    public class Cls_Clientes
    {
        private readonly Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public int IdCliente { get; set; }
        public string StrNombre { get; set; }
        public long NumDocumento { get; set; }
        public string StrDireccion { get; set; }
        public string StrTelefono { get; set; }
        public string StrEmail { get; set; }
        public string StrUsuarioModifica { get; set; }

        private static string Esc(string s) => (s ?? "").Replace("'", "''");

        public DataTable Consulta_Clientes()
        {
            string sql =
                "SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail " +
                "FROM TBLCLIENTES ORDER BY StrNombre";
            return AccesoDatos.EjecutarConsulta(sql);
        }

        public DataTable Consulta_Cliente(int idCliente)
        {
            string sql =
                "SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail " +
                $"FROM TBLCLIENTES WHERE IdCliente = {idCliente}";
            return AccesoDatos.EjecutarConsulta(sql);
        }

        /// <summary>Filtra por nombre o documento (si el texto es numérico).</summary>
        public DataTable Filtrar_Clientes(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return Consulta_Clientes();

            string esc = Esc(filtro.Trim());
            string sql =
                "SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail " +
                "FROM TBLCLIENTES WHERE StrNombre LIKE '%" + esc + "%'";

            if (long.TryParse(filtro.Trim(), out long doc))
                sql += " OR NumDocumento = " + doc;

            sql += " ORDER BY StrNombre";
            return AccesoDatos.EjecutarConsulta(sql);
        }

        public string Guardar()
        {
            string usuario = string.IsNullOrEmpty(StrUsuarioModifica) ? "Sofia" : StrUsuarioModifica;
            usuario = Esc(usuario);
            string sql;

            if (IdCliente == 0)
            {
                sql =
                    "INSERT INTO TBLCLIENTES (StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, " +
                    "DtmFechaModifica, StrUsuarioModifica) VALUES (" +
                    "'" + Esc(StrNombre) + "', " + NumDocumento + ", " +
                    "'" + Esc(StrDireccion) + "', '" + Esc(StrTelefono) + "', '" + Esc(StrEmail) + "', " +
                    "GETDATE(), '" + usuario + "')";
            }
            else
            {
                sql =
                    "UPDATE TBLCLIENTES SET " +
                    "StrNombre = '" + Esc(StrNombre) + "', " +
                    "NumDocumento = " + NumDocumento + ", " +
                    "StrDireccion = '" + Esc(StrDireccion) + "', " +
                    "StrTelefono = '" + Esc(StrTelefono) + "', " +
                    "StrEmail = '" + Esc(StrEmail) + "', " +
                    "DtmFechaModifica = GETDATE(), " +
                    "StrUsuarioModifica = '" + usuario + "' " +
                    "WHERE IdCliente = " + IdCliente;
            }

            return AccesoDatos.EjecutarComando(sql);
        }

        public string Borrar_Cliente(int idCliente)
        {
            string sql = "DELETE FROM TBLCLIENTES WHERE IdCliente = " + idCliente;
            return AccesoDatos.EjecutarComando(sql);
        }
    }
}
