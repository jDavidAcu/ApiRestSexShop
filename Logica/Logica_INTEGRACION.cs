using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class Logica_INTEGRACION
    {
        Datos_INTEGRACION op = new Datos_INTEGRACION();

        public List<IntegracionARRIENDO> SeleccionarFactsPenDTO(string cliCI)
        {
            return op.SeleccionarFactsPenDTO(cliCI);
        }

        // Método para verificar stock por factura
        public bool VerificarStockPorFactura(string idFactura)
        {
            return op.VerificarStockPorFactura(idFactura);
        }

        // Método para actualizar el stock y la factura
        public bool ActualizarFacturaYStock(string idFactura)
        {
            return op.ActualizarFacturaYStock(idFactura);
        }
    }
}
