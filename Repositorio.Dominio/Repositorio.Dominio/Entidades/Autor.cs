﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Entidades
{
    public class Autor
    {
        public int IdAutor { get; private set; }
        public string Nombre { get; private set; }
        public bool Estado { get; private set; }
    }
}
