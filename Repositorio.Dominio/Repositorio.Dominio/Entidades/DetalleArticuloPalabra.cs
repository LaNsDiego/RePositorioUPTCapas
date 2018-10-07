using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Entidades
{
    public class DetalleArticuloPalabra
    {
        public int IdDetalleArticuloPalabra { get; private set; }
        public int IdPalabra { get; private set; }
        public int IdArticulo { get; private set; }
        public Palabra Palabra { get; private set; }
        public Articulo Articulo { get; private set; }

    }
}
