using Repositorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class AutorMapeo : EntityTypeConfiguration<Autor>
    {
        public AutorMapeo()
        {
            ToTable("tbl_Autor");
            HasKey(p => p.IdAutor);
            Property(p => p.IdAutor).HasColumnName("Id_Autor");
            Property(p => p.Nombre).HasColumnName("Nombre").HasMaxLength(200);
            Property(p => p.Estado).HasColumnName("Estado");
        }
    }
}
