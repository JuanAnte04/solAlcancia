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
        public void uTestDarPersonas()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            Assert.AreNotEqual(null, ObjAlcancia.darPersonas());
        }
        [TestMethod]
        public void uTestDarMonedas()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            Assert.AreNotEqual(null, ObjAlcancia.darMonedas());
        }
        [TestMethod]
        public void uTestDarBilletes()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            Assert.AreNotEqual(null, ObjAlcancia.darBilletes());
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
            ObjBillete = new clsBillete(50000, 6, 7, 2003, "5670");
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
        [TestMethod]
        public void uTestDisociarPersona()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjPersona = null;
            int varCantidadPersonas = ObjAlcancia.darPersonas().Count;
            Assert.AreEqual(true, ObjAlcancia.disociar(1062, ref ObjPersona));
            Assert.AreEqual(1062, ObjPersona.darOID());
            Assert.AreEqual(varCantidadPersonas - 1, ObjAlcancia.darPersonas().Count);
        }
        [TestMethod]
        public void uTestDisociarMoneda()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjMoneda = null;
            int varCantidadMonedas = ObjAlcancia.darMonedas().Count;
            Assert.AreEqual(true, ObjAlcancia.disociar(100, ref ObjMoneda));
            Assert.AreEqual(100, ObjMoneda.darDenominacion());
            Assert.AreEqual(varCantidadMonedas - 1, ObjAlcancia.darMonedas().Count);
        }
        [TestMethod]
        public void uTestDisociarBilleteDenominacion()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjBillete = null;
            int varCantidadBilletes = ObjAlcancia.darBilletes().Count;
            Assert.AreEqual(true, ObjAlcancia.disociar(5000, ref ObjBillete));
            Assert.AreEqual(5000, ObjBillete.darDenominacion());
            Assert.AreEqual(varCantidadBilletes - 1, ObjAlcancia.darBilletes().Count);
        }
    }
}