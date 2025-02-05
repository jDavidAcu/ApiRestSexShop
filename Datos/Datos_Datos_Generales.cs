using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class Datos_Datos_Generales
    {
        EntitiesPEPE_SEX_SHOP _contexto;

        public Datos_Datos_Generales()
        {
            _contexto = new EntitiesPEPE_SEX_SHOP();
            _contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<DATOS_GENERALES> SeleccionarDGenerales()
        {
            return _contexto.DATOS_GENERALES.ToList();
        }

        public DATOS_GENERALES SeleccionarDGeneralesPorID(int ID)
        {
            return _contexto.DATOS_GENERALES.Where(d => d.EMP_ID == ID).SingleOrDefault();
        }

        public bool InsertarDatosGenerales(DATOS_GENERALES nuevosDatosGenerales)
        {
            bool insert = false;
            if (insert == false)
            {
                _contexto.DATOS_GENERALES.Add(nuevosDatosGenerales);
                _contexto.SaveChanges();
                insert = true;
                return insert;
            }
            return insert;
        }

        public bool ActualizarDGenerales(DATOS_GENERALES DGeneralesActualizados)
        {
            bool actualizado = false;
            var DGeneralesExistentes = _contexto.DATOS_GENERALES.Find(DGeneralesActualizados.EMP_ID);
            if (DGeneralesExistentes != null)
            {
                DGeneralesExistentes.EMP_NCUENTA = DGeneralesActualizados.EMP_NCUENTA;
                DGeneralesExistentes.IVA = DGeneralesActualizados.IVA;
                DGeneralesExistentes.NUM_FAC = DGeneralesActualizados.NUM_FAC;
                _contexto.SaveChanges();
                actualizado = true;
            }
            return actualizado;
        }

        public bool EliminarDGenerales(int empID)
        {
            bool eliminado = false;
            var DGeneralAEliminar = _contexto.DATOS_GENERALES.Find(empID);
            if (DGeneralAEliminar != null)
            {
                _contexto.DATOS_GENERALES.Remove(DGeneralAEliminar);
                _contexto.SaveChanges();
                eliminado = true;
            }
            return eliminado;
        }
    }
}
