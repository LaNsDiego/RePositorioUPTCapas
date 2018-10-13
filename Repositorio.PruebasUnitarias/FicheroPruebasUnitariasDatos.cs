using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos.Repositorios;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class FicheroPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearAutorSatisfactoriamente()
        {
            var loFichero = Fichero.Registrar("2018_001", "limache-sandoval-elmer.pdf","ninguno", "http://repositorio.upt.edu.pe/bitstream/UPT/224/1/Apaza-Mamani-Karla.pdf", "3,42mb", "PDF",1);
            var loRepositorio = new RepositoriosDatos();
            loRepositorio.Adicionar<Fichero>(loFichero);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loFichero);
            Assert.IsTrue(loFichero.IdFichero == "2018_001");
        }
        [TestMethod]
        public void CambiarNombreFicheroSatisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loFichero = loRepositorio.ObtenerPorId<Fichero>(1);
            loFichero.CambiarNombre("Ccama-Perez-Oracio.pdf");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loFichero.Nombre == "Ccama-Perez-Oracio.pdf");
        }

        [TestMethod]
        public void CambiarNombreFichero02Satisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loFichero = loRepositorio.Listar<Fichero>().FirstOrDefault(p => p.Nombre == "limache-sandoval-elmer.pdf");
            loFichero.CambiarNombre("Zapana-Zapana-Ruth.pdf");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loFichero);
        }
    }
}
