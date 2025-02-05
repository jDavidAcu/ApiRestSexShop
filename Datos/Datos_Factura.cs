using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Datos_Factura
    {
        EntitiesPEPE_SEX_SHOP _contexto;

        public Datos_Factura()
        {
            _contexto = new EntitiesPEPE_SEX_SHOP();
            _contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<FACTURA> SeleccionarFacturas()
        {
            return _contexto.FACTURA.ToList();
        }

        public FACTURA SeleccionarFacturasPorID(string FacNumero)
        {
            return _contexto.FACTURA.Where(d => d.FAC_NUMERO == FacNumero).SingleOrDefault();
        }

        public bool InsertarFactura(FACTURA nuevaFactura)
        {
            bool insert = false;
            if (insert == false)
            {
                _contexto.FACTURA.Add(nuevaFactura);
                _contexto.SaveChanges();
                insert = true;
                return insert;
            }
            return insert;
        }

        public bool ActualizarFactura(FACTURA facturaActualizada)
        {
            bool actualizado = false;
            var facturaExistente = _contexto.FACTURA.Find(facturaActualizada.FAC_NUMERO);
            if (facturaExistente != null)
            {
                facturaExistente.USU_NOMBRE = facturaActualizada.USU_NOMBRE;
                facturaExistente.USU_CORREO = facturaActualizada.USU_CORREO;
                facturaExistente.FAC_DIRECCION = facturaActualizada.FAC_DIRECCION;
                facturaExistente.FAC_TELEFONO = facturaActualizada.FAC_TELEFONO;
                facturaExistente.FAC_FECHA = facturaActualizada.FAC_FECHA;
                facturaExistente.FAC_TOTAL = facturaActualizada.FAC_TOTAL;
                facturaExistente.FAC_ESTADO = facturaActualizada.FAC_ESTADO;
                _contexto.SaveChanges();
                actualizado = true;
            }
            return actualizado;
        }

        public bool EliminarFactura(string numFactura)
        {
            bool eliminado = false;
            var facturaAEliminar = _contexto.FACTURA.Find(numFactura);
            if (facturaAEliminar != null)
            {
                _contexto.FACTURA.Remove(facturaAEliminar);
                _contexto.SaveChanges();
                eliminado = true;
            }
            return eliminado;
        }
    }
}
