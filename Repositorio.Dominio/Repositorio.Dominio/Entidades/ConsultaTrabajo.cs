using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Entidades
{
    class ConsultaTrabajo
    {
        public int IdConsultaTrabajo { get; set; }
        public int IdUsuario { get; set; }
        public int IdArticulo { get; set; }
        public int Hora { get; set; }
        public DateTime Fecha { get; set; }

        public Usuario Usuario { get; set; }
        public Articulo Articulo { get; set; }

    }
}
