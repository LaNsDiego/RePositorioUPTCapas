using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Entidades
{
    class Coleccion
    {
        public int IdColeccion { get; private set; }
        public int IdSubComunidad { get; private set; }
        public SubComunidad SubComunidad { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public bool Estado { get; private set; }
    }
}
