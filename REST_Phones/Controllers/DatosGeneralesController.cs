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
    public class DatosGeneralesController : ApiController
    {
        Logica_Datos_Generales op = new Logica_Datos_Generales();
        // GET: api/DatosGenerales
        // http:localhost:puerto/api/DatosGenerales
        public List<DATOS_GENERALES> Get()
        {
            return op.SeleccionarDGenerales();
        }

        // GET: api/DatosGenerales/5
        // http:localhost:puerto/api/DatosGenerales/5
        public DATOS_GENERALES Get(int id)
        {
            return op.SeleccionarDGeneralesPorID(id);
        }

        // POST: api/DatosGenerales
        public bool Post(DATOS_GENERALES NuevoDatoGeneral)
        {
            return op.InsertarDatosGenerales(NuevoDatoGeneral);
        }

        // PUT: api/DatosGenerales/5
        public bool Put(DATOS_GENERALES DatoGeneralActualizado)
        {
            return op.ActualizarDGenerales(DatoGeneralActualizado);
        }

        // DELETE: api/DatosGenerales/5
        public bool Delete(int empID)
        {
            return op.EliminarDGenerales(empID);
        }
    }
}
