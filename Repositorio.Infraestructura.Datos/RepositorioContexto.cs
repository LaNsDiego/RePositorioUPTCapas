using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Repositorio.Dominio.Entidades;

namespace Repositorio.Infraestructura.Datos
{
    class RepositorioContexto : DbContext
    {
        public RepositorioContexto() : base("BDRepositorio")
        {

        }

        public DbSet<Comunidad> Comunidades { get; set; }
    }
}
