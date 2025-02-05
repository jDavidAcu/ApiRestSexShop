using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using AccesoDatos;
using Logica;

namespace REST_Phones.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReportesController : ApiController
    {
        Logica_Reportes op = new Logica_Reportes();

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
