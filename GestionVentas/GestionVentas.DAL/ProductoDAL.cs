using ActividadCuatro.Dal;
using GestionVentas.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.DAL
{
    public class ProductoDAL
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "select * from PRODUCTOS";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public Producto ObtenerProductoIdDal(int id)
        {
            string consulta = "select * from PRODUCTOS where IDPRODUCTO=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Producto p = new Producto();
            if (tabla.Rows.Count > 0)
            {
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["IDPRODUCTO"]);
                p.NombreProducto = tabla.Rows[0]["NOMBREPRODUCTO"].ToString();
                p.PrecioUnitario = Convert.ToDecimal(tabla.Rows[0]["PRECIOUNITARIO"]);
            }
            return p;

        }
    }
}
