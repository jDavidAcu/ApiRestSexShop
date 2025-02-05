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
    /// Summary description for Api_Factura
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_Factura : System.Web.Services.WebService
    {
        Logica_Factura op = new Logica_Factura();

        [WebMethod]
        public List<FACTURA> SeleccionarFacturas()
        {
            return op.SeleccionarFacturas();
        }
        [WebMethod]
        public FACTURA SeleccionarFacturasPorID(string FacNumero)
        {
            return op.SeleccionarFacturasPorID(FacNumero);
        }
        [WebMethod]
        public bool InsertarFactura(FACTURA nuevaFactura)
        {
            return op.InsertarFactura(nuevaFactura);
        }
        [WebMethod]
        public bool ActualizarFactura(FACTURA facturaActualizada)
        {
            return op.ActualizarFactura(facturaActualizada);
        }
        [WebMethod]
        public bool EliminarFactura(string numFactura)
        {
            return op.EliminarFactura(numFactura);
        }
    }
}
