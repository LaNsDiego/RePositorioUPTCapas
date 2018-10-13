using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos.Repositorios;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class UsuarioPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearUsuarioSatisfactoriamente()
        {
            //var liUsuario1 = 
            var loUsuario = Usuario.Registrar("2018_001", "10.101.99.17", "Perú");
            var loRepositorio = new RepositoriosDatos();
            loRepositorio.Adicionar<Usuario>(loUsuario);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loUsuario);
            Assert.IsTrue(loUsuario.IdUsuario == "2018_001");
        }
        [TestMethod]
        public void CambiarDireccionIpUsuarioSatisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loUsuario = loRepositorio.ObtenerPorCodigo<Usuario>(1);
            loUsuario.CambiarDireccionIp("209.165.201.30");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loUsuario.DireccionIp == "209.165.201.30");
        }

        [TestMethod]
        public void CambiarNombreAutor02Satisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loUsuario = loRepositorio.Listar<Usuario>().FirstOrDefault(p => p.DireccionIp == "10.101.99.17");
            loUsuario.CambiarNombre("192.30.99.103");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loUsuario);
        }
    }
}
