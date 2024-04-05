using ActividadCuatro.Dal;
using GestionVentas.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.DAL
{
    public class DetalleVentaDAL
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from DETALLEVENTA";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        DetalleVenta p = new DetalleVenta();
        public DetalleVenta ObtenerDetalleVentaIdDal(int id)
        {
            string consulta = "select * from DETALLEVENTA where IDDETALLEVENTA=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                p.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["IDPRODUCTO"]);
                p.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                p.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                p.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
            }
            return p;
        }
        public void InsertarDetalleVentaDAL(DetalleVenta detalleventa)
        {
            string consulta = "insert into DETALLEVENTA values(" + detalleventa.IdVenta + "," +
                                                          "" + detalleventa.IdProducto + "," +
                                                          "'" + detalleventa.Cantidad + "'," +
                                                          "'" + detalleventa.PrecioVenta + "'," +
                                                          "'" + detalleventa.Total + "')";
            conexion.Ejecutar(consulta);
        }
        public void EditarDetalleVentaDal(DetalleVenta p)
        {
            string consulta = "update DETALLEVENTA set IDVENTA=" + p.IdVenta + "," +
                                                        "IDPRODUCTO=" + p.IdProducto + "," +
                                                        "cantidad=" + p.Cantidad + "," +
                                                        "precioventa=" + p.PrecioVenta + "," +
                                                        "total=" + p.Total + " " +
                                                "where iddetalleventa=" + p.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from DETALLEVENTA where IDDETALLEVENTA=" + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable DetalleVentaDatosDal(int id)
        {
            string consulta = "SELECT DETALLEVENTA.IDPRODUCTO, PRODUCTOS.NOMBREPRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, DETALLEVENTA.TOTAL " +
                  "FROM DETALLEVENTA " +
                  "INNER JOIN PRODUCTOS ON DETALLEVENTA.IDPRODUCTO = PRODUCTOS.IDPRODUCTO " +
                  "WHERE DETALLEVENTA.IDDETALLEVENTA = " + id;

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
