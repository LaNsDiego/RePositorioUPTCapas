using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class PalabraPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearPalabraSatisfactoriamente()
        {
            var loPalabra = Palabra.Palabra("2018_001", "Utilización del agua", 1);
            var loRepositorio = new Repositorio();
            loRepositorio.Adicionar<Autor>(loPalabra);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loPalabra);
            Assert.IsTrue(loAutor.IdAutor == "2018_001");
        }
        [TestMethod]
        public void CambiarNombrePalabraSatisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loPalabra = loRepositorio.ObtenerPorId<Palabra>(1);
            loPalabra.CambiarNombre("Abastecimiento de agua");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loPalabra.Nombre == "Abastecimiento de agua");
        }

        [TestMethod]
        public void CambiarNombrePalabra02Satisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loPalabra = loRepositorio.Listar<Palabra>().FirstOrDefault(p => p.Nombre == "Utilización del agua");
            loPalabra.CambiarNombre("Agua potable");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loPalabra);
        }
    }
}
