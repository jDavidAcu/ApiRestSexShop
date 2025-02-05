using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Logica;
using AccesoDatos;
using System.Web.Http.Cors;

namespace REST_Phones.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class IntegracionController : ApiController
    {
        Logica_INTEGRACION op = new Logica_INTEGRACION();

        // GET: api/integracion/SeleccionarFactsPenDTO?cliCI={cliCI}
        [HttpGet]
        [Route("api/integracion/SeleccionarFactsPenDTO")]
        public List<IntegracionARRIENDO> SeleccionarFactsPenDTO(string cliCI)
        {
            return op.SeleccionarFactsPenDTO(cliCI);
        }

        // GET: api/integracion/VerificarStockPorFactura?idFactura={idFactura}
        [HttpGet]
        [Route("api/integracion/VerificarStockPorFactura")]
        public bool VerificarStockPorFactura(string idFactura)
        {
            return op.VerificarStockPorFactura(idFactura);
        }

        // GET: api/integracion/ActualizarFacturaYStock?idFactura={idFactura}
        [HttpGet]
        [Route("api/integracion/ActualizarFacturaYStock")]
        public bool ActualizarFacturaYStock(string idFactura)
        {
            return op.ActualizarFacturaYStock(idFactura);
        }
    }
}
