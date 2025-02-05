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
    public class Logica_Reportes
    {
        Datos_Reportes op = new Datos_Reportes();

        public List<SP_GastoTotalPorUsuario_Result> GastoTotalPorUsuario()
        {
            return op.GastoTotalPorUsuario();
        }

        public List<SP_ProductoConMasIngresos_Result> ProductoConMasIngresos()
        {
            return op.ProductoConMasIngresos();
        }

        public List<SP_ProductosMasVendidos_Result> ProductosMasVendidos()
        {
            return op.ProductosMasVendidos();
        }

        public List<SP_PromedioGastoPorUsuario_Result> PromedioGastoPorUsuario()
        {
            return op.PromedioGastoPorUsuario();
        }

        public List<SP_UsuariosConGastoMayor_Result> UsuariosConGastoMayor(decimal valor)
        {
            return op.UsuariosConGastoMayor(valor);
        }

        public List<SP_VentasPorMes_Result> VentasPorMes()
        {
            return op.VentasPorMes();
        }
    }
}
