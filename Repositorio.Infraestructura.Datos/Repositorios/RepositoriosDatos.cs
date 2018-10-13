using Repositorio.Dominio.InterfaceRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Infraestructura.Datos.Repositorios
{
    public class RepositoriosDatos : IRepositorios
    {
        readonly RepositorioContexto ioContexto;

        public RepositoriosDatos()
        {
            this.ioContexto = new RepositorioContexto();
        }

        public void Adicionar<T>(T aoEntidad) where T : class
        {
            ioContexto.Set<T>().Add(aoEntidad);
        }

        public void GuardarCambios()
        {
            ioContexto.SaveChanges();
        }

        public IQueryable Listar<T>(string asPropiedades = "") where T : class
        {
            return ioContexto.Set<T>();
        }

        public T ObtenerPorCodigo<T>(params object[] aoLlaves) where T : class
        {
            return ioContexto.Set<T>().Find(aoLlaves);
        }
    }
}
