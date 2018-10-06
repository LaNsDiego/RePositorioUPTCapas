using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Entidades
{
    public class SubComunidad
    {
        public int IdSubComunidad { get; private set; }
        public int IdComunidad { get; private set; }
        public Comunidad Comunidad { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public bool Estado { get; private set; }
    }
}
