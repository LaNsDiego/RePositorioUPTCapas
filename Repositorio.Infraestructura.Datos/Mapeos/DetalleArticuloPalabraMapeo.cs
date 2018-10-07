using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Dominio.Entidades;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    class DetalleArticuloPalabraMapeo : EntityTypeConfiguration<DetalleArticuloPalabra>
    {
        public DetalleArticuloPalabraMapeo()
        {
            ToTable("tbl_DetalleArticuloPalabra");
            HasKey(p => p.IdDetalleArticuloPalabra);
            Property(p => p.IdDetalleArticuloPalabra).HasColumnName("Id_DetalleArticuloPalabra");
            Property(p => p.IdPalabra).HasColumnName("Id_Palabra");
            Property(p => p.IdArticulo).HasColumnName("Id_Articulo");
            HasRequired(m => m.Palabra).WithMany().HasForeignKey(f => f.IdPalabra);
            HasRequired(m => m.Articulo).WithMany().HasForeignKey(f => f.IdArticulo);
        }
    }
}
