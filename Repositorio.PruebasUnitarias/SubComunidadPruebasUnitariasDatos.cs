using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos;
using Repositorio.Infraestructura.Datos.Repositorios;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class SubComunidadPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearSubComunidadSatisfactoriamente()
        {
            var loSubComunidad = SubComunidad.Registrar("2018001", "2018_001", "PREGRADO", "Facultad de Ingenieria", "Facultad de la UPT", "1");
            var loRepositorio = new RepositoriosDatos();
            loRepositorio.Adicionar<SubComunidad>(loSubComunidad);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loSubComunidad);
            Assert.IsTrue(loSubComunidad.IdSubComunidad == "2018001");
        }
        [TestMethod]
        public void CambiarNombreSubComunidadSatisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loSubComunidad = loRepositorio.ObtenerPorCodigo<SubComunidad>(1);
            loSubComunidad.CambiarNombre("Facultad de Arquitectura y Urbanismo");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loSubComunidad.Nombre == "Facultad de Arquitectura y Urbanismo");
        }

        [TestMethod]
        public void CambiarNombreSubComunidad02Satisfactoriamente()
        {
            var loRepositorio = new RepositoriosDatos();
            var loSubComunidad = loRepositorio.Listar<SubComunidad>().FirstOrDefault(p => p.Nombre == "Facultad de Ingenieria");
            loSubComunidad.CambiarNombre("Facultad de Ciencias de la Salud");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loSubComunidad);
        }
    }
}
