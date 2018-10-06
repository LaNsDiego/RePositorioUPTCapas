using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Entidades
{
    public class Autor
    {
        public int IdAutor { get; private set; }
        public string NombreAutor { get; private set; }
        public string EstadoAutor { get; private set; }
    }
}
