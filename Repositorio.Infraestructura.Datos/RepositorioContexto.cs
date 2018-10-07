using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos.Mapeos;

namespace Repositorio.Infraestructura.Datos
{
    class RepositorioContexto : DbContext
    {
        public RepositorioContexto() : base("BDRepositorio")
        {

        }

        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Coleccion> Coleccion { get; set; }
        public DbSet<Comunidad> Comunidades { get; set; }
        public DbSet<ConsultaTrabajo> ConsultaTrabajo { get; set; }
        public DbSet<DetalleArticuloAutor> DetalleArticuloAutor { get; set; }
        public DbSet<DetalleArticuloPalabra> DetalleArticuloPalabra { get; set; }
        public DbSet<Editorial> Editorial { get; set; }
        public DbSet<Fichero> Fichero { get; set; }
        public DbSet<Palabra> Palabra { get; set; }
        public DbSet<SubComunidad> SubComunidad { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ArticuloMapeo());
            modelBuilder.Configurations.Add(new AutorMapeo());
            modelBuilder.Configurations.Add(new ColeccionMapeo());
            modelBuilder.Configurations.Add(new ComunidadMapeo());
            modelBuilder.Configurations.Add(new ConsultaTrabajoMapeo());
            modelBuilder.Configurations.Add(new DetalleArticuloAutorMapeo());
            modelBuilder.Configurations.Add(new DetalleArticuloPalabraMapeo());
            modelBuilder.Configurations.Add(new EditorialMapeo());
            modelBuilder.Configurations.Add(new FicheroMapeo());
            modelBuilder.Configurations.Add(new PalabraMapeo());
            modelBuilder.Configurations.Add(new SubComunidadMapeo());
            modelBuilder.Configurations.Add(new UsuarioMapeo());
        }
    }
}
