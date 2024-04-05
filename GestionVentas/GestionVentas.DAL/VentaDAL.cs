using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActividadCuatro.Dal;
using GestionVentas.MODELOS;

namespace GestionVentas.DAL
{
    public class VentaDAL
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from VENTA";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarVentaDAL(Venta venta)
        {
            string consulta = "insert into VENTA values ('" + venta.Fecha + "' , " +
                                                            venta.Total + ")";
            conexion.Ejecutar(consulta);

        }

        public Venta ObtenerVentaIdDal(int id)
        {
            string consulta = "select * from VENTA where IDVENTA=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Venta v = new Venta();
            if (tabla.Rows.Count > 0)
            {
                v.IdVenta = Convert.ToInt32(tabla.Rows[0]["IdVenta"]);
                v.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                v.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
            }
            return v;
        }
        public void EditarVentaDal(Venta v)
        {
            string consulta = "update VENTA set TOTAL='" + v.Total + "', " +
                                                    "fecha='" + v.Fecha + "' " +
                                                    "where IdVenta=" + v.IdVenta;

            conexion.Ejecutar(consulta);
        }
        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from VENTA where IDVENTA=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
