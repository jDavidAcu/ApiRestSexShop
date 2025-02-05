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
    /// Descripción breve de API_Integracion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class API_Integracion : System.Web.Services.WebService
    {
        Logica_INTEGRACION op = new Logica_INTEGRACION();

        [WebMethod]
        public List<IntegracionARRIENDO> SeleccionarFactsPenDTO(string cliCI)
        {
            return op.SeleccionarFactsPenDTO(cliCI);
        }

        [WebMethod]
        public bool VerificarStockPorFactura(string idFactura)
        {
            return op.VerificarStockPorFactura(idFactura);
        }

        [WebMethod]
        public bool ActualizarFacturaYStock(string idFactura)
        {
            return op.ActualizarFacturaYStock(idFactura);
        }
    }
}
