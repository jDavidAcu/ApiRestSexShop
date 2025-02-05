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
    public class FacturaController : ApiController
    {
        Logica_Factura op = new Logica_Factura();
        // GET: api/Factura
        public List<FACTURA> Get()
        {
            return op.SeleccionarFacturas();
        }

        // GET: api/Factura/5
        public FACTURA Get(string FacNumero)
        {
            return op.SeleccionarFacturasPorID(FacNumero);
        }

        // POST: api/Factura
        public bool Post(FACTURA NuevaFactura)
        {
            return op.InsertarFactura(NuevaFactura);
        }

        // PUT: api/Factura/5
        public bool Put(FACTURA FacturaActualizada)
        {
            return op.ActualizarFactura(FacturaActualizada);
        }

        // DELETE: api/Factura/5
        public bool Delete(string FacNumero)
        {
            return op.EliminarFactura(FacNumero);
        }
    }
}
