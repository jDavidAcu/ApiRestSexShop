using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Factura
    {
        Datos_Factura op = new Datos_Factura();

        public List<FACTURA> SeleccionarFacturas()
        {
            return op.SeleccionarFacturas();
        }

        public FACTURA SeleccionarFacturasPorID(string FacNumero)
        {
            return op.SeleccionarFacturasPorID(FacNumero);
        }

        public bool InsertarFactura(FACTURA nuevaFactura)
        {
            return op.InsertarFactura(nuevaFactura);
        }

        public bool ActualizarFactura(FACTURA facturaActualizada)
        {
            return op.ActualizarFactura(facturaActualizada);
        }

        public bool EliminarFactura(string numFactura)
        {
            return op.EliminarFactura(numFactura);
        }
    }
}
