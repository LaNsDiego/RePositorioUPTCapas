using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio.Repositorios
{
    public interface IRepositorios
    {
        T ObtenerPorCodigo<T>(params object[] aoLlave) where T : class;
        IQueryable Listar<T>(string asPropiedades = "") where T : class;
        void Adicionar<T>(T aoEntidad) where T : class;
        void GuardarCambios();
    }
}
