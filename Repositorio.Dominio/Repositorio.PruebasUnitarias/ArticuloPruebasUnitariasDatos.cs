using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Dominio.Entidades;
using Repositorio.Infraestructura.Datos;

namespace Repositorio.PruebasUnitarias
{
    [TestClass]
    public class ArticuloPruebasUnitariasDatos
    {
        [TestMethod]
        public void CrearArticuloSatisfactoriamente()
        {
            var loArticulo = Articulo.Registrar("2018010001", "Marco de Trabajo para la Gestión de Requisitos de Software Basado en el Modelo de Impacto Emocional en la Facultad de Ingeniería de la Universidad Privada de Tacna - Tacna",
                "La presente investigación se desarrolla en el campo de la ingeniería de requisitos...", 
                "La presente investigación se desarrolla en el campo de la ingeniería de requisitos, donde se aplicará la herramienta de psicología social, creada por J.A. Russell denominada “rejilla del afecto” u originalmente conocida como affect grid. Dicha herramienta permitirá mejorar la obtención de requisitos, conocer las emociones de quienes interactúan y brindar así un mejor servicio al usuario final. Es preciso mencionar que la “rejilla del afecto” permite optimizar factores como: tiempo, dinero, la resistencia, ambigüedad, indecisión y la falta de instrumentos que aquejan a los creadores de software y además efectivizar su labor de proporcionar un producto de software deseable. Esta tesis, fusiona la ingeniería y la psicología, demostrando una vez más que el ser humano es un centro de emociones infinito a estudiar y que la ingeniería de sistemas es una carrera amplia en la cual se puede insertar diferentes materias, consiguiendo satisfacer las necesidades de usuario final. Esta investigación se convierte en una herramienta útil para el ingeniero de requisitos, ya que su labor minimizará errores y el resultado obtenido será veraz.", 
                "2017", "2018_001", "2018_001", "20180001", "2018_001", "2018_001", "1");
            var loRepositorio = new Repositorio();
            loRepositorio.Adicionar<Articulo>(loArticulo);
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loArticulo);
            Assert.IsTrue(loArticulo.IdArticulo == "2018010001");
        }
        [TestMethod]
        public void CambiarTituloArticuloSatisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loArticulo = loRepositorio.ObtenerPorId<Articulo>(1);
            loArticulo.CambiarTitulo("Uso de la Domótica y su Impacto en la Gestión de Producción del Criadero Avícola Fundo los Olivos S.N.");
            loRepositorio.GuardarCambios();
            Assert.IsTrue(loArticulo.Titulo == "Uso de la Domótica y su Impacto en la Gestión de Producción del Criadero Avícola Fundo los Olivos S.N.");
        }

        [TestMethod]
        public void CambiarTituloArticulo02Satisfactoriamente()
        {
            var loRepositorio = new Repositorio();
            var loArticulo = loRepositorio.Listar<Articulo>().FirstOrDefault(p => p.Titulo == "Marco de Trabajo para la Gestión de Requisitos de Software Basado en el Modelo de Impacto Emocional en la Facultad de Ingeniería de la Universidad Privada de Tacna - Tacna");
            loArticulo.CambiarTitulo("Índices de Cumplimiento de Estándares de Calidad, Utilizando Métricas Web en los Portales de los Gobiernos Regionales del Perú");
            loRepositorio.GuardarCambios();
            Assert.IsNotNull(loArticulo);
        }
    }
}
