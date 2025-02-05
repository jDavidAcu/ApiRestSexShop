using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos;

namespace WS_SOA_SexShop
{
    /// <summary>
    /// Summary description for Api_Datos_Generales
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_Datos_Generales : System.Web.Services.WebService
    {
        Logica_Datos_Generales op = new Logica_Datos_Generales();

        [WebMethod]
        public List<DATOS_GENERALES> SeleccionarDGenerales()
        {
            return op.SeleccionarDGenerales();
        }
        [WebMethod]
        public DATOS_GENERALES SeleccionarDGeneralesPorID(int ID)
        {
            return op.SeleccionarDGeneralesPorID(ID);
        }

        [WebMethod]
        public bool InsertarDatosGenerales(DATOS_GENERALES nuevosDatosGenerales)
        {
            return op.InsertarDatosGenerales(nuevosDatosGenerales);
        }

        [WebMethod]
        public bool ActualizarDGenerales(DATOS_GENERALES DGeneralesActualizados)
        {
            return op.ActualizarDGenerales(DGeneralesActualizados);
        }

        [WebMethod]
        public bool EliminarDGenerales(int empID)
        {
            return op.EliminarDGenerales(empID);
        }
    }
}
