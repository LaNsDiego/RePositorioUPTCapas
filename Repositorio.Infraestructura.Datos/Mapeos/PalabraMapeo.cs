using Repositorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class PalabraMapeo : EntityTypeConfiguration<Palabra>
    {
        public PalabraMapeo()
        {
            ToTable("tbl_Palabra");
            HasKey(p => p.IdPalabra);
            Property(p => p.IdPalabra).HasColumnName("Id_Palabra");
            Property(p => p.Nombre).HasColumnName("Nombre").HasMaxLength(200);
            Property(p => p.Estado).HasColumnName("Estado");
        }
    }
}
