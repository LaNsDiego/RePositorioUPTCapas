using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Dominio.Entidades;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class ColeccionMapeo : EntityTypeConfiguration<Coleccion>
    {
        public ColeccionMapeo()
        {
            ToTable("tbl_Colecciones");
            HasKey(p => p.IdColeccion);
            Property(p => p.IdColeccion).HasColumnName("Id_Coleccion");
            Property(p => p.IdSubComunidad).HasColumnName("Id_Subcomunidad");
            Property(p => p.Nombre).HasColumnName("Nombre").HasMaxLength(200);
            Property(p => p.Descripcion).HasColumnName("Descripcion").HasMaxLength(200);
            Property(p => p.Estado).HasColumnName("Estado");
            HasRequired(m => m.SubComunidad).WithMany().HasForeignKey(f => f.IdSubComunidad);
        }
    }
}
