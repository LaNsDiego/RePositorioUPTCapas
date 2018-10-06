using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Entidades
{
    public class Articulo
    {

        public int IdArticulo { get; private set; }
        public string Titulo { get; private set; }
        public string Resumen { get; private set; }
        public string Contenido { get; private set; }
        public DateTime FechaPublicacion { get; private set; }
        public int IdDetalleArticuloAutor { get; private set; }
        public int IdDetalleArticuloPalabra { get; private set; }
        public int IdColeccion { get; private set; }
        public int IdEditorial { get; private set; }
        public int IdFichero { get; private set; }
        public bool Estado { get; private set; }

        public DetalleArticuloAutor DetalleArticuloAutor { get; private set; }
        public DetalleArticuloPalabra DetalleArticuloPalabra { get; private set; }
        public Coleccion Coleccion { get; private set; }
        public Editorial Editorial { get; private set; }
        public Fichero Fichero { get; private set; }
    }
}
