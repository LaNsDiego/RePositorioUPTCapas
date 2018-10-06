using Repositorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class EditorialMapeo : EntityTypeConfiguration<Editorial>
    {
        public EditorialMapeo()
        {
            ToTable("tbl_Editorial");
            HasKey(p => p.IdEditorial);
            Property(p => p.IdEditorial).HasColumnName("Id_Editorial");
            Property(p => p.Nombre).HasColumnName("Nombre").HasMaxLength(200);
            Property(p => p.Direccion).HasColumnName("Direccion");
            Property(p => p.Estado).HasColumnName("Estado");
        }
    }
}
