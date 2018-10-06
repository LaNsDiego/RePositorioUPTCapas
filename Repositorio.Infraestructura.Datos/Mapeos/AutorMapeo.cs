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
            ToTable("TBL_AUTOR");
        }
    }
}
