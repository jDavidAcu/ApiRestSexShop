using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AccesoDatos;
using Logica;

namespace REST_Phones.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductoController : ApiController
    {
        Logica_Producto op = new Logica_Producto();
        // GET: api/Producto
        public List<PRODUCTO> Get()
        {
            return op.SeleccionarProductos();
        }

        // GET: api/Producto/5
        public PRODUCTO Get(string PrdNombre)
        {
            return op.SeleccionarProductosPorID(PrdNombre);
        }

        // POST: api/Producto
        public bool Post(PRODUCTO NuevoProducto)
        {
            return op.InsertarProducto(NuevoProducto);
        }

        // PUT: api/Producto/5
        public bool Put(PRODUCTO ProductoActualizado)
        {
            return op.ActualizarProducto(ProductoActualizado);
        }

        // DELETE: api/Producto/5
        public bool Delete(string PrdNombre)
        {
            return op.EliminarProducto(PrdNombre);
        }
    }
}
