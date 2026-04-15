using System;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    /// <summary>CRUD TBLCATEGORIA_PROD.</summary>
    public class Cls_Categorias
    {
        private readonly Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public int IdCategoria { get; set; }
        public string StrDescripcion { get; set; }
        public string StrUsuarioModifico { get; set; }

        private static string Esc(string s) => (s ?? "").Replace("'", "''");

        public DataTable Consulta_Categorias()
        {
            string sql =
                "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD ORDER BY StrDescripcion";
            return AccesoDatos.EjecutarConsulta(sql);
        }

        public DataTable Consulta_Categoria(int idCategoria)
        {
            string sql =
                "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD WHERE IdCategoria = " +
                idCategoria;
            return AccesoDatos.EjecutarConsulta(sql);
        }

        public DataTable Filtrar_Categorias(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return Consulta_Categorias();

            string esc = Esc(filtro.Trim());
            string sql =
                "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD " +
                "WHERE StrDescripcion LIKE '%" + esc + "%' ORDER BY StrDescripcion";
            return AccesoDatos.EjecutarConsulta(sql);
        }

        public string Guardar()
        {
            string usuario = string.IsNullOrEmpty(StrUsuarioModifico) ? "Sofia" : StrUsuarioModifico;
            usuario = Esc(usuario);
            string sql;

            if (IdCategoria == 0)
            {
                sql =
                    "INSERT INTO TBLCATEGORIA_PROD (StrDescripcion, DtmFechaModifica, StrUsuarioModifico) VALUES (" +
                    "'" + Esc(StrDescripcion) + "', GETDATE(), '" + usuario + "')";
            }
            else
            {
                sql =
                    "UPDATE TBLCATEGORIA_PROD SET " +
                    "StrDescripcion = '" + Esc(StrDescripcion) + "', " +
                    "DtmFechaModifica = GETDATE(), " +
                    "StrUsuarioModifico = '" + usuario + "' " +
                    "WHERE IdCategoria = " + IdCategoria;
            }

            return AccesoDatos.EjecutarComando(sql);
        }

        public string Borrar_Categoria(int idCategoria)
        {
            string sql = "DELETE FROM TBLCATEGORIA_PROD WHERE IdCategoria = " + idCategoria;
            return AccesoDatos.EjecutarComando(sql);
        }
    }
}
