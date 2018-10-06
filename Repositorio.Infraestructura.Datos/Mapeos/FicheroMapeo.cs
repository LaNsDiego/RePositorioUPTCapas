using Repositorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class FicheroMapeo : EntityTypeConfiguration<Fichero>
    {
        public FicheroMapeo()
        {
            ToTable("tbl_Fichero");
            HasKey(p => p.IdFichero);
            Property(p => p.IdFichero).HasColumnName("Id_Fichero");
            Property(p => p.Nombre).HasColumnName("Nombre").HasMaxLength(200);
            Property(p => p.Descripcion).HasColumnName("Descripcion");
            Property(p => p.Formato).HasColumnName("Formato");
            Property(p => p.Tamanio).HasColumnName("Tamanio");
            Property(p => p.Enlace).HasColumnName("Enlace");
            Property(p => p.Estado).HasColumnName("Estado");
        }
    }
}
