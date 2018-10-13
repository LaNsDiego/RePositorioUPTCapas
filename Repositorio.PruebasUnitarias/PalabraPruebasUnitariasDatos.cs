using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos.Repositorios;
namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class PalabraPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearPalabraSatisfactoriamente()
        {
            var loPalabra = Palabra.Palabra("2018_001", "Utilización del agua", 1);
            var loRepositorio = new RepositoriosDatos();
            loRepositorio.Adicionar<Autor>(loPalabra);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loPalabra);
            Assert.IsTrue(loPalabra.IdAutor == "2018_001");
        }
        [TestMethod]
        public void CambiarNombrePalabraSatisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loPalabra = loRepositorio.ObtenerPorCodigo<Palabra>(1);
            loPalabra.CambiarNombre("Abastecimiento de agua");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loPalabra.Nombre == "Abastecimiento de agua");
        }

        [TestMethod]
        public void CambiarNombrePalabra02Satisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loPalabra = loRepositorio.Listar<Palabra>().FirstOrDefault(p => p.Nombre == "Utilización del agua");
            loPalabra.CambiarNombre("Agua potable");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loPalabra);
        }
    }
}
