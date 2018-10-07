using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio.Entidades;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class DetalleArticuloAutorMapeo : EntityTypeConfiguration<DetalleArticuloAutor>
    {
        public DetalleArticuloAutorMapeo()
        {
            ToTable("tbl_DetalleArticuloAutor");
            HasKey(p => p.IdDetalleArticuloAutor);
            Property(p => p.IdArticulo).HasColumnName("Id_Articulo");
            Property(p => p.IdAutor).HasColumnName("Id_Autor");
            HasRequired(m => m.Articulo).WithMany().HasForeignKey(f => f.IdArticulo);
            HasRequired(m => m.Autor).WithMany().HasForeignKey(f => f.IdAutor);
        }
    }
}
