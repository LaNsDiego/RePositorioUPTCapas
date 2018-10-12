using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class DetalleArticuloAutorPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearDetalleArticuloAutorSatisfactoriamente()
        {
            var loDetalleArticuloAutor = DetalleArticuloAutor.Registrar("2018_001", "2018_004", "2018_010", "Diques - estabilidad del talud","Jimena Carol");
            var loRepositorio = new Repositorio();
            loRepositorio.Adicionar<DetalleArticuloAutor>(loDetalleArticuloAutor);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loDetalleArticuloAutor);
            Assert.IsTrue(loDetalleArticuloAutor.IdDetalleArticuloAutor == "2018_001");
        }
        [TestMethod]
        public void CambiarIdArticuloAutorSatisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loDetalleArticuloAutor = loRepositorio.ObtenerPorId<DetalleArticuloAutor>(1);
            loDetalleArticuloAutor.CambiarIdArticulo("2018_005");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loDetalleArticuloAutor.IdArticulo == "2018_005");
        }

        [TestMethod]
        public void CambiarIdArticuloAutor02Satisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loDetalleArticuloAutor = loRepositorio.Listar<DetalleArticuloAutor>().FirstOrDefault(p => p.IdArticulo == "2018_004");
            loDetalleArticuloAutor.CambiarIdarticulo("2018_020");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loDetalleArticuloAutor);
        }
    }
}
