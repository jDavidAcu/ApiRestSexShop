using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Datos_Reportes
    {
        EntitiesPEPE_SEX_SHOP _contexto;

        public Datos_Reportes()
        {
            _contexto = new EntitiesPEPE_SEX_SHOP();
            _contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List <SP_GastoTotalPorUsuario_Result> GastoTotalPorUsuario()
        {
            return _contexto.SP_GastoTotalPorUsuario().ToList();
        }

        public List <SP_ProductoConMasIngresos_Result> ProductoConMasIngresos()
        {
            return _contexto.SP_ProductoConMasIngresos().ToList();
        }

        public List <SP_ProductosMasVendidos_Result> ProductosMasVendidos()
        {
            return _contexto.SP_ProductosMasVendidos().ToList();
        }

        public List<SP_PromedioGastoPorUsuario_Result> PromedioGastoPorUsuario()
        {
            return _contexto.SP_PromedioGastoPorUsuario().ToList();
        }

        public List<SP_UsuariosConGastoMayor_Result> UsuariosConGastoMayor(decimal valor)
        {
            return _contexto.SP_UsuariosConGastoMayor(valor).ToList();
        }

        public List <SP_VentasPorMes_Result> VentasPorMes()
        {
            return _contexto.SP_VentasPorMes().ToList();
        }
    }
}
