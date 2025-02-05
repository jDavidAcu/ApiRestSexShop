using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Detalle_Factura
    {
        Datos_Detalle_Factura op = new Datos_Detalle_Factura();

        public List<DETALLE_FACTURA> SeleccionarDetallesFactura()
        {
            return op.SeleccionarDetallesFactura();
        }

        public DETALLE_FACTURA SeleccionarDetalleFacturaPorID(string FacNum, string PrdNombre)
        {
            return op.SeleccionarDetalleFacturaPorID(FacNum, PrdNombre);
        }

        public bool InsertarDetalleFactura(DETALLE_FACTURA nuevoDetalleFactura)
        {
            return op.InsertarDetalleFactura(nuevoDetalleFactura);
        }

        public bool ActualizarDetalleFactura(DETALLE_FACTURA DetalleFacturaActualizados)
        {
            return op.ActualizarDetalleFactura(DetalleFacturaActualizados);
        }

        public bool EliminarDetalleFactura(string numFac, string prdNombre)
        {
            return op.EliminarDetalleFactura(numFac, prdNombre);     
        }
    }
}
