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
    public class Logica_Datos_Generales
    {
        Datos_Datos_Generales op = new Datos_Datos_Generales();

        public List<DATOS_GENERALES> SeleccionarDGenerales()
        {
            return op.SeleccionarDGenerales();
        }

        public DATOS_GENERALES SeleccionarDGeneralesPorID(int ID)
        {
            return op.SeleccionarDGeneralesPorID(ID);
        }

        public bool InsertarDatosGenerales(DATOS_GENERALES nuevosDatosGenerales)
        {
            return op.InsertarDatosGenerales(nuevosDatosGenerales);
        }

        public bool ActualizarDGenerales(DATOS_GENERALES DGeneralesActualizados)
        {
            return op.ActualizarDGenerales(DGeneralesActualizados);
        }

        public bool EliminarDGenerales(int empID)
        {
            return op.EliminarDGenerales(empID);
        }
    }
}
