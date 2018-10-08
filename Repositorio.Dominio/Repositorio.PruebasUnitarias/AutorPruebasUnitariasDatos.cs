using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class AutorPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearAutorSatisfactoriamente()
        {
            var loAutor = Autor.Registrar("2018_001", "Juan Rodrigo", "1");
            var loRepositorio = new Repositorio();
            loRepositorio.Adicionar<Autor>(loAutor);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loAutor);
            Assert.IsTrue(loAutor.IdAutor == "2018_001");
        }
        [TestMethod]
        public void CambiarNombreAutorSatisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loAutor = loRepositorio.ObtenerPorId<Conunidad>(1);
            loAutor.CambiarNombre("Jimena Carol");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loAutor.Nombre == "Jimena Carol");
        }

        [TestMethod]
        public void CambiarNombreAutor02Satisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loAutor = loRepositorio.Listar<Comunidad>().FirstOrDefault(p => p.Nombre == "Juan Rodrigo");
            loAutor.CambiarNombre("Manuel Diego");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loAutor);
        }
    }
}
