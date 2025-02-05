using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Datos_Detalle_Factura
    {
        EntitiesPEPE_SEX_SHOP _contexto;

        public Datos_Detalle_Factura()
        {
            _contexto = new EntitiesPEPE_SEX_SHOP();
            _contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<DETALLE_FACTURA> SeleccionarDetallesFactura()
        {
            return _contexto.DETALLE_FACTURA.ToList();
        }

        public DETALLE_FACTURA SeleccionarDetalleFacturaPorID(string FacNum, string PrdNombre)
        {
            return _contexto.DETALLE_FACTURA.Where(d => d.FAC_NUMERO == FacNum && d.PRD_ID == PrdNombre).SingleOrDefault();
        }

        public bool InsertarDetalleFactura(DETALLE_FACTURA nuevoDetalleFactura)
        {
            try
            {
                _contexto.Database.ExecuteSqlCommand(
                    "INSERT INTO DETALLE_FACTURA (FAC_NUMERO, PRD_ID, PRD_CANTIDAD, PRD_SUBTOTAL) " +
                    "VALUES (@FAC_NUMERO, @PRD_ID, @PRD_CANTIDAD, @PRD_SUBTOTAL)",
                    new SqlParameter("@FAC_NUMERO", nuevoDetalleFactura.FAC_NUMERO),
                    new SqlParameter("@PRD_ID", nuevoDetalleFactura.PRD_ID),
                    new SqlParameter("@PRD_CANTIDAD", nuevoDetalleFactura.PRD_CANTIDAD),
                    new SqlParameter("@PRD_SUBTOTAL", nuevoDetalleFactura.PRD_SUBTOTAL)
                );

                return true;
            }
            catch (Exception ex)
            {
                return false ;
            }
        }

        public bool ActualizarDetalleFactura(DETALLE_FACTURA DetalleFacturaActualizados)
        {
            try
            {
                _contexto.Database.ExecuteSqlCommand(
                    "UPDATE DETALLE_FACTURA SET PRD_CANTIDAD = @PRD_CANTIDAD, PRD_SUBTOTAL = @PRD_SUBTOTAL " +
                    "WHERE FAC_NUMERO = @FAC_NUMERO AND PRD_ID = @PRD_ID",
                    new SqlParameter("@FAC_NUMERO", DetalleFacturaActualizados.FAC_NUMERO),
                    new SqlParameter("@PRD_ID", DetalleFacturaActualizados.PRD_ID),
                    new SqlParameter("@PRD_CANTIDAD", DetalleFacturaActualizados.PRD_CANTIDAD),
                    new SqlParameter("@PRD_SUBTOTAL", DetalleFacturaActualizados.PRD_SUBTOTAL)
                );

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarDetalleFactura(string numFac, string prdId)
        {
            try
            {
                _contexto.Database.ExecuteSqlCommand(
                    "DELETE FROM DETALLE_FACTURA WHERE FAC_NUMERO = @FAC_NUMERO AND PRD_ID = @PRD_ID",
                    new SqlParameter("@FAC_NUMERO", numFac),
                    new SqlParameter("@PRD_ID", prdId)
                );

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
