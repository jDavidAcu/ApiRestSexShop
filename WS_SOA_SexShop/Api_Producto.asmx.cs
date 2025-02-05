using AccesoDatos;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace WS_SOA_SexShop
{
    /// <summary>
    /// Summary description for Api_Producto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_Producto : System.Web.Services.WebService
    {
        Logica_Producto op = new Logica_Producto();

        [WebMethod]
        public List<PRODUCTO> SeleccionarProductos()
        {
            return op.SeleccionarProductos();
        }

        [WebMethod]
        public PRODUCTO SeleccionarProductosPorID(string PrdNombre)
        {
            return op.SeleccionarProductosPorID(PrdNombre);
        }

        [WebMethod]
        public bool InsertarProducto(PRODUCTO nuevoProducto)
        {
            return op.InsertarProducto(nuevoProducto);
        }

        [WebMethod]
        public bool ActualizarProducto(PRODUCTO productoActualizado)
        {
            return op.ActualizarProducto(productoActualizado);
        }

        [WebMethod]
        public bool EliminarProducto(string prdNombre)
        {
            return op.EliminarProducto(prdNombre);
        }
    }
}
