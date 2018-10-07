using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Dominio.Entidades;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class ConsultaTrabajoMapeo : EntityTypeConfiguration<ConsultaTrabajo>
    {
        public ConsultaTrabajoMapeo()
        {
            ToTable("tbl_ConsultaTrabajo");
            HasKey(p => p.IdConsultaTrabajo);
            Property(p => p.IdConsultaTrabajo).HasColumnName("Id_ConsultaTrabajo");
            Property(p => p.IdUsuario).HasColumnName("Id_Usuario");
            Property(p => p.IdArticulo).HasColumnName("Id_Articulo");
            Property(p => p.Hora).HasColumnName("Hora");
            Property(p => p.Fecha).HasColumnName("Fecha");
            HasRequired(m => m.Usuario).WithMany().HasForeignKey(f => f.IdUsuario);
            HasRequired(m => m.Articulo).WithMany().HasForeignKey(f => f.IdArticulo);
        }
    }
}
