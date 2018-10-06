using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Entidades
{
    public class Fichero
    {
        public int IdFichero { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public string Enlace { get; private set; }
        public int Tamanio { get; private set; }
        public string Formato { get; private set; }
        public bool Estado { get; private set; }
    }
}
