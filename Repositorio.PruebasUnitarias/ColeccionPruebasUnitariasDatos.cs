using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos.Repositorios;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class ColeccionPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearColeccionSatisfactoriamente()
        {
            var loColeccion = Coleccion.Registrar("20180001", "2018001", "Facultad de Ingenieria", "Escuela Profesional de Ingenieria de Sistemas", "Ingeniera de Sistemas", "1");
            var loRepositorio = new  RepositoriosDatos();
            loRepositorio.Adicionar<Coleccion>(loColeccion);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loColeccion);
            Assert.IsTrue(loColeccion.IdColeccion == "20180001");
        }
        [TestMethod]
        public void CambiarNombreColeccionSatisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loColeccion = loRepositorio.ObtenerPorCodigo<Coleccion>(1);
            loColeccion.CambiarNombre("Escuela Profesional de Ingenieria Civil");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loColeccion.Nombre == "Escuela Profesional de Ingenieria Civil");
        }

        [TestMethod]
        public void CambiarNombreColeccion02Satisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loColeccion = loRepositorio.Listar<Coleccion>().FirstOrDefault(p => p.Nombre == "Escuela Profesional de Ingenieria de Sistemas");
            loColeccion.CambiarNombre("Escuela Profesional de Ingenieria de Ambiental");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loColeccion);
        }
    }
}
