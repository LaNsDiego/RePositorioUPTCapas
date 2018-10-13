using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos.Repositorios;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class ComunidadPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearComunidadSatisfactoriamente()
        {
            var loComunidad = Comunidad.Registrar("2018_001","PREGRADO", "PREGRADO", "1");
            var loRepositorio = new RepositoriosDatos();
            loRepositorio.Adicionar<Comunidad>(loComunidad);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loComunidad);
            Assert.IsTrue(loComunidad.IdComunidad == "2018_001");
        }
        [TestMethod]
        public void CambiarNombreComunidadSatisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loComunidad = loRepositorio.ObtenerPorCodigo<Comunidad>(1);
            loComunidad.CambiarNombre("POSTGRADO");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loComunidad.Nombre == "POSTGRADO");
        }

        [TestMethod]
        public void CambiarNombreComunidad02Satisfactoriamente()
        {
        }
    }
}
