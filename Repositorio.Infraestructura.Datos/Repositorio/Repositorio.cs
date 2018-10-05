using Repositorio.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Infraestructura.Datos.Repositorio
{
    public class Repositorio : IRepositorios
    {
        readonly RepositorioContexto ioContexto;

        public void Adicionar<T>(T aoEntidad) where T : class
        {
            throw new NotImplementedException();
        }

        public void GuardarCambios()
        {
            throw new NotImplementedException();
        }

        public IQueryable Listar<T>(string asPropiedades = "") where T : class
        {
            throw new NotImplementedException();
        }

        public T ObtenerPorCodigo<T>(params object[] aoLlave) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
