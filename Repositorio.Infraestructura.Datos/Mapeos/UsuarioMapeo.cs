using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio.Entidades;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class UsuarioMapeo : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapeo()
        {
            ToTable("tbl_Usuario");
            HasKey(p => p.IdUsuario);
            Property(p => p.IdUsuario).HasColumnName("Id_Usuario");
            Property(p => p.DireccionIp).HasColumnName("Id_DireccionIp");
            Property(p => p.Pais).HasColumnName("Id_Pais");
        }
    }
}
