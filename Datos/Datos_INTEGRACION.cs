using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Datos_INTEGRACION
    {
        // Método para seleccionar facturas pendientes
        public List<IntegracionARRIENDO> SeleccionarFactsPenDTO(string cliCI)
        {
            // Obtener clientes
            Datos_Usuario datosCliente = new Datos_Usuario();
            List<USUARIO> listaClientes = datosCliente.SeleccionarUsuarios().ToList();

            // Filtrar el cliente por la cédula proporcionada
            var clienteFiltrado = listaClientes.FirstOrDefault(c => c.USU_DNI.Trim().Equals(cliCI.Trim(), StringComparison.OrdinalIgnoreCase));

            if (clienteFiltrado == null)
            {
                // Si no se encuentra un cliente con la cédula proporcionada, devolver una lista vacía
                return new List<IntegracionARRIENDO>();
            }

            // Obtener facturas pendientes para ese cliente
            Datos_Factura datosFactura = new Datos_Factura();
            List<FACTURA> listaFacturasPendientes = datosFactura
                .SeleccionarFacturas()
                .Where(f => f.FAC_ESTADO.Trim().Equals("Pendiente", StringComparison.OrdinalIgnoreCase) && f.USU_DNI == clienteFiltrado.USU_DNI)
                .ToList();

            // Obtener detalles de facturas
            Datos_Detalle_Factura datosDetalleFactura = new Datos_Detalle_Factura();
            List<DETALLE_FACTURA> listaDetalleFactura = datosDetalleFactura.SeleccionarDetallesFactura().ToList();

            // Crear la lista de integración
            List<IntegracionARRIENDO> listaIntegracion = new List<IntegracionARRIENDO>();

            foreach (var factura in listaFacturasPendientes)
            {
                decimal montoTotal = factura.FAC_TOTAL;

                IntegracionARRIENDO integracion = new IntegracionARRIENDO
                {
                    Id_Cliente = clienteFiltrado.USU_DNI,
                    Id_Servicio = 18,  // Cambiar a ID correspondiente de SexShop
                    Monto = montoTotal,
                    Id_Factura = factura.FAC_NUMERO
                };
                listaIntegracion.Add(integracion);
            }

            return listaIntegracion;
        }


        // Método para verificar stock
        public bool VerificarStockPorFactura(string idFactura)
        {
            // Obtener detalles de la factura específica
            Datos_Detalle_Factura datosDetalleFactura = new Datos_Detalle_Factura();
            List<DETALLE_FACTURA> detallesFactura = datosDetalleFactura
                .SeleccionarDetallesFactura()
                .Where(df => df.FAC_NUMERO.Trim().Equals(idFactura.Trim(), StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Obtener productos
            Datos_Producto datosProducto = new Datos_Producto();
            List<PRODUCTO> listaProductos = datosProducto.SeleccionarProductos().ToList();

            // Verificar stock para cada producto en la factura
            foreach (var detalle in detallesFactura)
            {
                var producto = listaProductos.FirstOrDefault(p => p.PRD_ID.Trim().Equals(detalle.PRD_ID.Trim(), StringComparison.OrdinalIgnoreCase));

                if (producto == null || producto.PRD_STOCK < detalle.PRD_CANTIDAD)
                {
                    // Si no hay suficiente stock para algún producto, retornar false
                    return false;
                }
            }

            // Si todos los productos tienen suficiente stock, retornar true
            return true;
        }

        // Método para actualizar estado de la factura y reducir stock (GET)
        public bool ActualizarFacturaYStock(string idFactura)
        {
            // Obtener detalles de la factura específica
            Datos_Detalle_Factura datosDetalleFactura = new Datos_Detalle_Factura();
            List<DETALLE_FACTURA> detallesFactura = datosDetalleFactura
                .SeleccionarDetallesFactura()
                .Where(df => df.FAC_NUMERO.Trim().Equals(idFactura.Trim(), StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Obtener productos
            Datos_Producto datosProducto = new Datos_Producto();
            List<PRODUCTO> listaProductos = datosProducto.SeleccionarProductos().ToList();

            // Reducir el stock de los productos
            foreach (var detalle in detallesFactura)
            {
                var producto = listaProductos.FirstOrDefault(p => p.PRD_ID.Trim().Equals(detalle.PRD_ID.Trim(), StringComparison.OrdinalIgnoreCase));
                if (producto != null)
                {
                    producto.PRD_STOCK -= detalle.PRD_CANTIDAD; // Reducir stock
                    datosProducto.ActualizarProducto(producto); // Guardar cambios en el producto
                }
            }

            // Actualizar el estado de la factura a "Pagada"
            Datos_Factura datosFactura = new Datos_Factura();
            var factura = datosFactura
                .SeleccionarFacturas()
                .FirstOrDefault(f => f.FAC_NUMERO.Trim().Equals(idFactura.Trim(), StringComparison.OrdinalIgnoreCase));

            if (factura != null)
            {
                factura.FAC_ESTADO = "Pagado"; // Cambiar estado
                datosFactura.ActualizarFactura(factura); // Guardar cambios en la factura
            }

            return true; // Retornar True si todo se actualiza correctamente
        }
    }
}
