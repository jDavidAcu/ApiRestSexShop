﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EntitiesPEPE_SEX_SHOP : DbContext
    {
        public EntitiesPEPE_SEX_SHOP()
            : base("name=EntitiesPEPE_SEX_SHOP")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DATOS_GENERALES> DATOS_GENERALES { get; set; }
        public virtual DbSet<FACTURA> FACTURA { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
    
        public virtual ObjectResult<SP_GastoTotalPorUsuario_Result> SP_GastoTotalPorUsuario()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GastoTotalPorUsuario_Result>("SP_GastoTotalPorUsuario");
        }
    
        public virtual ObjectResult<SP_ProductoConMasIngresos_Result> SP_ProductoConMasIngresos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ProductoConMasIngresos_Result>("SP_ProductoConMasIngresos");
        }
    
        public virtual ObjectResult<SP_ProductosMasVendidos_Result> SP_ProductosMasVendidos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ProductosMasVendidos_Result>("SP_ProductosMasVendidos");
        }
    
        public virtual ObjectResult<SP_PromedioGastoPorUsuario_Result> SP_PromedioGastoPorUsuario()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_PromedioGastoPorUsuario_Result>("SP_PromedioGastoPorUsuario");
        }
    
        public virtual ObjectResult<SP_UsuariosConGastoMayor_Result> SP_UsuariosConGastoMayor(Nullable<decimal> montoMinimo)
        {
            var montoMinimoParameter = montoMinimo.HasValue ?
                new ObjectParameter("MontoMinimo", montoMinimo) :
                new ObjectParameter("MontoMinimo", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_UsuariosConGastoMayor_Result>("SP_UsuariosConGastoMayor", montoMinimoParameter);
        }
    
        public virtual ObjectResult<SP_VentasPorMes_Result> SP_VentasPorMes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VentasPorMes_Result>("SP_VentasPorMes");
        }
    }
}
