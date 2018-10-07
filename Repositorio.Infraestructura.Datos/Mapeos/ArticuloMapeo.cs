using Repositorio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    class ArticuloMapeo : EntityTypeConfiguration<Articulo>
    {
        public ArticuloMapeo()
        {
            ToTable("tbl_Articulo");
            HasKey(p => p.IdArticulo);
            Property(p => p.IdArticulo).HasColumnName("Id_Articulo");
            Property(p => p.Titulo).HasColumnName("Titulo");
            Property(p => p.Resumen).HasColumnName("Resumen");
            Property(p => p.Contenido).HasColumnName("Contenido");
            Property(p => p.FechaPublicacion).HasColumnName("FechaPublicacion");
            Property(p => p.IdDetalleArticuloAutor).HasColumnName("Id_DetalleArticuloAutor");
            Property(p => p.IdDetalleArticuloPalabra).HasColumnName("Id_DetalleArticuloPalabra");
            Property(p => p.IdColeccion).HasColumnName("Id_Coleccion");
            Property(p => p.IdEditorial).HasColumnName("Id_Editorial");
            Property(p => p.IdFichero).HasColumnName("Id_Fichero");
            Property(p => p.Estado).HasColumnName("Estado");
        }
    }
}
