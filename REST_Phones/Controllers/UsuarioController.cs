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
    public class UsuarioController : ApiController
    {
        Logica_Usuario op = new Logica_Usuario();
        // GET: api/Usuario
        public List<USUARIO> Get()
        {
            return op.SeleccionarUsuarios();
        }

        // GET: api/Usuario/5
        public USUARIO Get(string DNI)
        {
            return op.SeleccionarUsuariosPorID(DNI);
        }

        // POST: api/Usuario
        public bool Post(USUARIO NuevoUsuario)
        {
            return op.InsertarUsuario(NuevoUsuario);
        }

        // PUT: api/Usuario/5
        public bool Put(USUARIO UsuarioActualizado)
        {
            return op.ActualizarUsuario(UsuarioActualizado);
        }

        // DELETE: api/Usuario/5
        public bool Delete(string DNI)
        {
            return op.EliminarUsuario(DNI);
        }
    }
}
