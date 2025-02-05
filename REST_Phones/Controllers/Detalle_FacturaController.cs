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
    public class Detalle_FacturaController : ApiController
    {
        Logica_Detalle_Factura op = new Logica_Detalle_Factura();
        // GET: api/DetalleFactura
        public List<DETALLE_FACTURA> Get()
        {
            return op.SeleccionarDetallesFactura();
        }

        // GET: api/DetalleFactura/5
        public DETALLE_FACTURA Get(string FacNum, string PrdNombre)
        {
            return op.SeleccionarDetalleFacturaPorID(FacNum, PrdNombre);
        }

        // POST: api/DetalleFactura
        public bool Post(DETALLE_FACTURA NuevoDetalleFacura)
        {
            return op.InsertarDetalleFactura(NuevoDetalleFacura);
        }

        // PUT: api/DetalleFactura/5
        public bool Put(DETALLE_FACTURA DetalleFacturaActualizado)
        {
            return op.ActualizarDetalleFactura(DetalleFacturaActualizado);
        }

        // DELETE: api/DetalleFactura/5
        public bool Delete(string numFac, string prdNombre)
        {
            return op.EliminarDetalleFactura(numFac, prdNombre);
        }
    }
}
