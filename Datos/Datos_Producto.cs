using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Datos_Producto
    {
        EntitiesPEPE_SEX_SHOP _contexto;

        public Datos_Producto()
        {
            _contexto = new EntitiesPEPE_SEX_SHOP();
            _contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<PRODUCTO> SeleccionarProductos()
        {
            return _contexto.PRODUCTO.ToList();
        }

        public PRODUCTO SeleccionarProductosPorID(string PrdNombre)
        {
            return _contexto.PRODUCTO.Where(d => d.PRD_ID == PrdNombre).SingleOrDefault();
        }

        public bool InsertarProducto(PRODUCTO nuevoProducto)
        {
            bool insert = false;
            if (insert == false)
            {
                _contexto.PRODUCTO.Add(nuevoProducto);
                _contexto.SaveChanges();
                insert = true;
                return insert;
            }
            return insert;
        }

        public bool ActualizarProducto(PRODUCTO productoActualizado)
        {
            bool actualizado = false;
            var ProductoExistente = _contexto.PRODUCTO.Find(productoActualizado.PRD_ID);
            if (ProductoExistente != null)
            {
                ProductoExistente.PRD_NOMBRE = productoActualizado.PRD_NOMBRE;
                ProductoExistente.PRD_MARCA = productoActualizado.PRD_MARCA;
                ProductoExistente.PRD_STOCK = productoActualizado.PRD_STOCK;
                ProductoExistente.PRD_PRECIO = productoActualizado.PRD_PRECIO;
                ProductoExistente.PRD_DESC = productoActualizado.PRD_DESC;
                ProductoExistente.PRD_IMAGEN = productoActualizado.PRD_IMAGEN;
                _contexto.SaveChanges();
                actualizado = true;
            }
            return actualizado;
        }

        public bool EliminarProducto(string prdID)
        {
            bool eliminado = false;
            var productoAEliminar = _contexto.PRODUCTO.Find(prdID);
            if (productoAEliminar != null)
            {
                _contexto.PRODUCTO.Remove(productoAEliminar);
                _contexto.SaveChanges();
                eliminado = true;
            }
            return eliminado;
        }

    }
}
