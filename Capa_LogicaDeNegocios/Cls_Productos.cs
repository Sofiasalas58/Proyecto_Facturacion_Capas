using System;
using System.Data;
using System.Globalization;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    /// <summary>CRUD TBLPRODUCTO; listados con descripción de categoría.</summary>
    public class Cls_Productos
    {
        private readonly Cls_Acceso_Datos AccesoDatos = new Cls_Acceso_Datos();

        public int IdProducto { get; set; }
        public string StrNombre { get; set; }
        public string StrCodigo { get; set; }
        public double NumPrecioCompra { get; set; }
        public double NumPrecioVenta { get; set; }
        public int IdCategoria { get; set; }
        public string StrDetalle { get; set; }
        public string StrFoto { get; set; }
        public int NumStock { get; set; }
        public string StrUsuarioModifica { get; set; }

        private static string Esc(string s) => (s ?? "").Replace("'", "''");

        /// <summary>Listado con nombre de categoría (no Id).</summary>
        public DataTable Consulta_Productos()
        {
            string sql =
                "SELECT p.IdProducto, p.StrNombre, p.StrCodigo, p.NumPrecioCompra, p.NumPrecioVenta, " +
                "ISNULL(c.StrDescripcion, '') AS StrCategoriaDesc, p.StrDetalle, p.NumStock " +
                "FROM TBLPRODUCTO p " +
                "LEFT JOIN TBLCATEGORIA_PROD c ON p.IdCategoria = c.IdCategoria " +
                "ORDER BY p.StrNombre";
            return AccesoDatos.EjecutarConsulta(sql);
        }

        public DataTable Consulta_Producto(int idProducto)
        {
            string sql =
                "SELECT p.IdProducto, p.StrNombre, p.StrCodigo, p.NumPrecioCompra, p.NumPrecioVenta, " +
                "p.IdCategoria, ISNULL(c.StrDescripcion, '') AS StrCategoriaDesc, " +
                "p.StrDetalle, ISNULL(p.strFoto, '') AS strFoto, p.NumStock " +
                "FROM TBLPRODUCTO p " +
                "LEFT JOIN TBLCATEGORIA_PROD c ON p.IdCategoria = c.IdCategoria " +
                "WHERE p.IdProducto = " + idProducto;
            return AccesoDatos.EjecutarConsulta(sql);
        }

        public DataTable Filtrar_Productos(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return Consulta_Productos();

            string esc = Esc(filtro.Trim());
            string sql =
                "SELECT p.IdProducto, p.StrNombre, p.StrCodigo, p.NumPrecioCompra, p.NumPrecioVenta, " +
                "ISNULL(c.StrDescripcion, '') AS StrCategoriaDesc, p.StrDetalle, p.NumStock " +
                "FROM TBLPRODUCTO p " +
                "LEFT JOIN TBLCATEGORIA_PROD c ON p.IdCategoria = c.IdCategoria " +
                "WHERE p.StrNombre LIKE '%" + esc + "%' OR p.StrCodigo LIKE '%" + esc + "%' " +
                "ORDER BY p.StrNombre";
            return AccesoDatos.EjecutarConsulta(sql);
        }

        public DataTable Combo_Categorias()
        {
            string sql =
                "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD ORDER BY StrDescripcion";
            return AccesoDatos.EjecutarConsulta(sql);
        }

        public string Guardar()
        {
            string usuario = string.IsNullOrEmpty(StrUsuarioModifica) ? "Sofia" : StrUsuarioModifica;
            usuario = Esc(usuario);
            string pc = NumPrecioCompra.ToString(CultureInfo.InvariantCulture);
            string pv = NumPrecioVenta.ToString(CultureInfo.InvariantCulture);
            string fotoSql = string.IsNullOrWhiteSpace(StrFoto) ? "NULL" : "'" + Esc(StrFoto) + "'";
            string sql;

            if (IdProducto == 0)
            {
                sql =
                    "INSERT INTO TBLPRODUCTO (StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, " +
                    "IdCategoria, StrDetalle, strFoto, NumStock, DtmFechaModifica, StrUsuarioModifica) VALUES (" +
                    "'" + Esc(StrNombre) + "', '" + Esc(StrCodigo) + "', " + pc + ", " + pv + ", " +
                    IdCategoria + ", '" + Esc(StrDetalle) + "', " + fotoSql + ", " + NumStock + ", " +
                    "GETDATE(), '" + usuario + "')";
            }
            else
            {
                sql =
                    "UPDATE TBLPRODUCTO SET " +
                    "StrNombre = '" + Esc(StrNombre) + "', " +
                    "StrCodigo = '" + Esc(StrCodigo) + "', " +
                    "NumPrecioCompra = " + pc + ", " +
                    "NumPrecioVenta = " + pv + ", " +
                    "IdCategoria = " + IdCategoria + ", " +
                    "StrDetalle = '" + Esc(StrDetalle) + "', " +
                    "strFoto = " + fotoSql + ", " +
                    "NumStock = " + NumStock + ", " +
                    "DtmFechaModifica = GETDATE(), " +
                    "StrUsuarioModifica = '" + usuario + "' " +
                    "WHERE IdProducto = " + IdProducto;
            }

            return AccesoDatos.EjecutarComando(sql);
        }

        public string Borrar_Producto(int idProducto)
        {
            string sql = "DELETE FROM TBLPRODUCTO WHERE IdProducto = " + idProducto;
            return AccesoDatos.EjecutarComando(sql);
        }
    }
}
