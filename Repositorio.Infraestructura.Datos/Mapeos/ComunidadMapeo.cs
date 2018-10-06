using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio.Entidades;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class ComunidadMapeo : EntityTypeConfiguration<Comunidad>
    {
        public ComunidadMapeo()
        {
            ToTable("tbl_Comunidades");
            HasKey(p => p.IdComunidad);
            Property(p => p.IdComunidad).HasColumnName("Id_Comunidad");
            Property(p => p.Nombre).HasColumnName("Nombre").HasMaxLength(200);
            Property(p => p.Descripcion).HasColumnName("Descripcion");
            Property(p => p.Estado).HasColumnName("Estado");
        }
    }
}
