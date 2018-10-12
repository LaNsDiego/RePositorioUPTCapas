using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class ConsultaPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearConsultaSatisfactoriamente()
        {
            var loConsulta = Consulta.Registrar("2018000001", "2018_001", "2018010001", "20:50", "08/10/2018");
            var loRepositorio = new Repositorio();
            loRepositorio.Adicionar<Consulta>(loConsulta);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loConsulta);
            Assert.IsTrue(loConsulta.IdConsultaTrabajo == "2018000001");
        }
        [TestMethod]
        public void CambiarHoraConsultaSatisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loConsulta = loRepositorio.ObtenerPorId<Consulta>(1);
            loConsulta.CambiarHoraConsulta("21:00");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loConsulta.Hora == "21:00");
        }

        [TestMethod]
        public void CambiarFechaConsultaSatisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loConsulta = loRepositorio.Listar<Consulta>().FirstOrDefault(p => p.Fecha == "08/10/2018");
            loConsulta.CambiarFechaConsulta("09/10/2018");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loConsulta);
        }
    }
}
