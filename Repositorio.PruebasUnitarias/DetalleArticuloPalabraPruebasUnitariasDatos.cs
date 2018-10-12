using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class DetalleArticuloPalabraPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearDetalleArticuloPalabraSatisfactoriamente()
        {
            var loDetalleArticuloPalabra = DetalleArticuloPalabra.Registrar("2018_001", "2018_100", "2018_099", "Recursos Humanos", "Algoritmos genéticos");
            var loRepositorio = new Repositorio();
            loRepositorio.Adicionar<DetalleArticuloPalabra>(loDetalleArticuloPalabra);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loDetalleArticuloPalabra);
            Assert.IsTrue(loDetalleArticuloPalabra.IdDetalleArticuloPalabra == "2018_001");
        }
        [TestMethod]
        public void CambiarIdPalabraDetalleArticuloPalabraSatisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loDetalleArticuloPalabra = loRepositorio.ObtenerPorId<DetalleArticuloPalabra>(1);
            loDetalleArticuloPalabra.CambiarIdPalabra("2018_200");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loDetalleArticuloPalabra.IdPalabra == "2018_200");
        }

        [TestMethod]
        public void CambiarIdPalabraDetalleArticuloPalabra02Satisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loDetalleArticuloPalabra = loRepositorio.Listar<DetalleArticuloPalabra>().FirstOrDefault(p => p.IdPalabra == "2018_100");
            loDetalleArticuloPalabra.IdPalabra("2018_999");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loDetalleArticuloPalabra);
        }
    }
}
