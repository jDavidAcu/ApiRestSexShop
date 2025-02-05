using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos;
using Logica;

namespace WS_SOA_SexShop
{
    /// <summary>
    /// Summary description for Api_Detalle_Factura
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_Detalle_Factura : System.Web.Services.WebService
    {
        Logica_Detalle_Factura op = new Logica_Detalle_Factura();

        [WebMethod]
        public List<DETALLE_FACTURA> SeleccionarDetallesFactura()
        {
            return op.SeleccionarDetallesFactura();
        }

        [WebMethod]
        public DETALLE_FACTURA SeleccionarDetalleFacturaPorID(string FacNum, string PrdNombre)
        {
            return op.SeleccionarDetalleFacturaPorID(FacNum, PrdNombre);
        }
        [WebMethod]
        public bool InsertarDetalleFactura(DETALLE_FACTURA nuevoDetalleFactura)
        {
            return op.InsertarDetalleFactura(nuevoDetalleFactura);
        }
        [WebMethod]
        public bool ActualizarDetalleFactura(DETALLE_FACTURA DetalleFacturaActualizados)
        {
            return op.ActualizarDetalleFactura(DetalleFacturaActualizados);
        }
        [WebMethod]
        public bool EliminarDetalleFactura(string numFac, string prdNombre)
        {
            return op.EliminarDetalleFactura(numFac, prdNombre);
        }
    }
}
