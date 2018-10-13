using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos.Repositorios;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class EditorialPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearEditorialSatisfactoriamente()
        {
            var loEditorial = Editorial.Registrar("2018_001", "Universidad Privada de Tacna", "Av. Jorge Basadre Grohmann s/n Pocollay", "1");
            var loRepositorio = new RepositoriosDatos();
            loRepositorio.Adicionar<Editorial>(loEditorial);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loEditorial);
            Assert.IsTrue(loEditorial.IdEditorial == "2018_001");
        }
        [TestMethod]
        public void CambiarEstadoEditorialSatisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loEditorial = loRepositorio.ObtenerPorId<Editorial>(1);
            loEditorial.CambiarEstado("0");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loEditorial.Estado == "0");
        }

        [TestMethod]
        public void CambiarEstadoEditorialr02Satisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loEditorial = loRepositorio.Listar<Editorial>().FirstOrDefault(p => p.Estado == "1");
            loEditorial.CambiarNombre("0");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loEditorial);
        }
    }
}
