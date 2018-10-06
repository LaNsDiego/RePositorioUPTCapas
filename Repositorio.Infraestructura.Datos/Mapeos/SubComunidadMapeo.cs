using Repositorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class SubComunidadMapeo : EntityTypeConfiguration<SubComunidad>
    {
        public SubComunidadMapeo()
        {
            ToTable("tbl_Subcomunidades");
            HasKey(p => p.IdSubComunidad);
            Property(p => p.IdSubComunidad).HasColumnName("Id_Subcomunidad");
            Property(p => p.IdComunidad).HasColumnName("Id_Comunidad");
            Property(p => p.Nombre).HasColumnName("Nombre").HasMaxLength(200);
            Property(p => p.Descripcion).HasColumnName("Descripcion").HasMaxLength(200);
            Property(p => p.Estado).HasColumnName("Estado");
            HasRequired(m => m.Comunidad).WithMany().HasForeignKey(f => f.IdComunidad);
        }
    }
}
