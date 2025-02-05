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
    /// Summary description for Api_Usuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_Usuario : System.Web.Services.WebService
    {
        Logica_Usuario op = new Logica_Usuario  ();

        [WebMethod]
        public List<USUARIO> SeleccionarUsuarios()
        {
            return op.SeleccionarUsuarios();
        }
        [WebMethod]
        public USUARIO SeleccionarUsuariosPorID(string DNI)
        {
            return op.SeleccionarUsuariosPorID(DNI);
        }
        [WebMethod]
        public bool InsertarUsuario(USUARIO nuevoUsuario)
        {
            return op.InsertarUsuario(nuevoUsuario);
        }
        [WebMethod]
        public bool ActualizarUsuario(USUARIO usuarioActualizado)
        {
            return op.ActualizarUsuario(usuarioActualizado);
        }
        [WebMethod]
        public bool EliminarUsuario(string id)
        {
            return op.EliminarUsuario(id);
        }
    }
}
