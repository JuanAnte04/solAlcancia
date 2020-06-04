using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestAlcancia
    {
        private clsAlcancia ObjAlcancia;
        private clsMoneda ObjMoneda, ObjMonedaEsperada;
        private clsBillete ObjBillete, ObjBilleteEsperado;
        private clsPersona ObjPersona, ObjPersonaEsperada;
        [TestMethod]
        public void uTestdarCapacidad()
        {
            ObjAlcancia = new clsAlcancia();
            Assert.AreEqual(-1, ObjAlcancia.darCapacidadMonedas());
            Assert.AreEqual(-1, ObjAlcancia.darCapacidadBilletes());
        }
        [TestMethod]
        public void uTestConstructorPrm()
        {
            ObjAlcancia = new clsAlcancia(10, 20);
            Assert.AreNotEqual(null, ObjAlcancia);
            Assert.AreEqual(10, ObjAlcancia.darCapacidadMonedas());
            Assert.AreEqual(20, ObjAlcancia.darCapacidadBilletes());
        }
        [TestMethod]
        public void uTestrecuperarMoneda()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            Assert.AreEqual(true, ObjAlcancia.recuperar(100, ref ObjMoneda));
            Assert.AreEqual(100, ObjMoneda.darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBillete()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            Assert.AreEqual(true, ObjAlcancia.recuperar(5000, ref ObjBillete));
            Assert.AreEqual(5000, ObjBillete.darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarPesona()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            Assert.AreEqual(true, ObjAlcancia.recuperar(1062, ref ObjPersona));
            Assert.AreEqual(1062, ObjPersona.darOID());
        }
        [TestMethod]
        public void uTestAsociarMoneda()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjMoneda = new clsMoneda(200, 2006);
            Assert.AreEqual(true, ObjAlcancia.asociar(ObjMoneda));
            Assert.AreEqual(true, ObjAlcancia.recuperar(200, ref ObjMonedaEsperada));
            Assert.AreEqual(ObjMonedaEsperada, ObjMoneda);
        }
        [TestMethod]
        public void uTestAsociarBillete()
        {
            ObjAlcancia = new clsAlcancia();
            ObjBillete = new clsBillete(50000, 6, 7, 2003, 5670);
            ObjAlcancia.Generar();
            Assert.AreEqual(true, ObjAlcancia.asociar(ObjBillete));
            Assert.AreEqual(true, ObjAlcancia.recuperar(50000, ref ObjBilleteEsperado));
            Assert.AreEqual(ObjBilleteEsperado, ObjBillete);
        }
        [TestMethod]
        public void uTestAsociarPersona()
        {
            ObjAlcancia = new clsAlcancia();
            ObjPersona = new clsPersona(1791, "Manuel");
            ObjAlcancia.Generar();
            Assert.AreEqual(true, ObjAlcancia.asociar(ObjPersona));
            Assert.AreEqual(true, ObjAlcancia.recuperar(1791, ref ObjPersonaEsperada));
            Assert.AreEqual(ObjPersonaEsperada, ObjPersona);
        }
    }
}