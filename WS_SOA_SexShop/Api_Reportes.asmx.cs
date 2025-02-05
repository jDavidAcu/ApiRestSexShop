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
    /// Summary description for Api_Reportes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_Reportes : System.Web.Services.WebService
    {
        Logica_Reportes op = new Logica_Reportes();

        [WebMethod]
        public List<SP_GastoTotalPorUsuario_Result> GastoTotalPorUsuario()
        {
            return op.GastoTotalPorUsuario();
        }
        [WebMethod]
        public List<SP_ProductoConMasIngresos_Result> ProductoConMasIngresos()
        {
            return op.ProductoConMasIngresos();
        }
        [WebMethod]
        public List<SP_ProductosMasVendidos_Result> ProductosMasVendidos()
        {
            return op.ProductosMasVendidos();
        }
        [WebMethod]
        public List<SP_PromedioGastoPorUsuario_Result> PromedioGastoPorUsuario()
        {
            return op.PromedioGastoPorUsuario();
        }
        [WebMethod]
        public List<SP_UsuariosConGastoMayor_Result> UsuariosConGastoMayor(decimal valor)
        {
            return op.UsuariosConGastoMayor(valor);
        }
        [WebMethod]
        public List<SP_VentasPorMes_Result> VentasPorMes()
        {
            return op.VentasPorMes();
        }
    }
}
