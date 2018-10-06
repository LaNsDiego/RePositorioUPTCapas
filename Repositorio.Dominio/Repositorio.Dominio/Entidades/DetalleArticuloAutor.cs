using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Entidades
{
    public class DetalleArticuloAutor
    {
        public int IdDetalleArticuloAutor { get; private set; }
        public int IdArticulo { get; private set; }
        public int IdAutor { get; private set; }
        public Articulo Articulo { get; private set; }
        public Autor Autor { get; private set; }
        
    }
}
