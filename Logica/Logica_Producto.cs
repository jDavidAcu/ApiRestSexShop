using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Producto
    {
        Datos_Producto op = new Datos_Producto();

        public List<PRODUCTO> SeleccionarProductos()
        {
            return op.SeleccionarProductos();
        }

        public PRODUCTO SeleccionarProductosPorID(string PrdNombre)
        {
            return op.SeleccionarProductosPorID(PrdNombre);
        }

        public bool InsertarProducto(PRODUCTO nuevoProducto)
        {
            return op.InsertarProducto(nuevoProducto);
        }

        public bool ActualizarProducto(PRODUCTO productoActualizado)
        {
            return op.ActualizarProducto(productoActualizado);
        }

        public bool EliminarProducto(string prdNombre)
        {
            return op.EliminarProducto(prdNombre);
        }
    }
}
