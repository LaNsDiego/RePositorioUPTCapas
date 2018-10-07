using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get;; private set; }
        public string DireccionIp { get;; private set; }
        public string Pais { get;; private set; }
    }
}
