using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    //Generar y constructor no prm
    [TestClass]
    public class uTestAlcancia
    {
        private clsAlcancia ObjAlcancia;
        private clsMoneda ObjMoneda, ObjMonedaEsperada;
        private clsBillete ObjBillete, ObjBilleteEsperado;
        private clsPersona ObjPersona, ObjPersonaEsperada;
        int varValorMaximo;
        [TestMethod]
        public void uTestdarCapacidadMonedas()
        {
            ObjAlcancia = new clsAlcancia();
            Assert.AreEqual(-1, ObjAlcancia.darCapacidadMonedas());
        }
        [TestMethod]
        public void uTestdarCapacidadBilletes()
        {
            ObjAlcancia = new clsAlcancia();
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
            ObjAlcancia.Generar();
            Assert.AreEqual(100, new clsAlcancia().recuperarMonedaCon(100).darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBillete()
        {
            ObjAlcancia.Generar();
            Assert.AreEqual(5000, new clsAlcancia().recuperarBilleteCon(5000).darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarPesona()
        {
            ObjAlcancia.Generar();
            Assert.AreEqual(1062, new clsAlcancia().recuperarPersonaCon(1062).darOID());
        }
        [TestMethod]
        public void uTestAsociarMoneda()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjMoneda = new clsMoneda(200, 2006);
            Assert.AreEqual(true, ObjAlcancia.asociarMonedaCon(ObjMoneda));
            Assert.AreEqual(ObjMoneda, ObjAlcancia.recuperarMonedaCon(200));
        }
        [TestMethod]
        public void uTestAsociarBillete()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjBillete = new clsBillete(50000, 6, 7, 2003, "5670");
            Assert.AreEqual(true, ObjAlcancia.asociarBilleteCon(ObjBillete));
            Assert.AreEqual(ObjBillete, ObjAlcancia.recuperarBilleteCon(50000));
        }
        [TestMethod]
        public void uTestAsociarPersona()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjPersona = new clsPersona(1791, "Manuel");
            Assert.AreEqual(true, ObjAlcancia.asociarAhorradorCon(ObjPersona));
            Assert.AreEqual(ObjPersona, ObjAlcancia.recuperarPersonaCon(1791));
        }
        [TestMethod]
        public void uTestDisociarPersona()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            varValorMaximo = ObjAlcancia.darPersonas().Count;
            Assert.AreEqual(1062, ObjAlcancia.disociarAhorradorCon(1062).darOID());
            Assert.AreEqual(varValorMaximo - 1, ObjAlcancia.darPersonas().Count);
        }
        [TestMethod]
        public void uTestDisociarMoneda()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            varValorMaximo = ObjAlcancia.darMonedas().Count;
            Assert.AreEqual(100, ObjAlcancia.disociarMonedaCon(100).darDenominacion());
            Assert.AreEqual(varValorMaximo - 1, ObjAlcancia.darMonedas().Count);
        }
        [TestMethod]
        public void uTestDisociarBilleteDenominacion()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            varValorMaximo = ObjAlcancia.darBilletes().Count;
            Assert.AreEqual(5000, ObjAlcancia.disociarBilleteCon(5000).darDenominacion());
            Assert.AreEqual(varValorMaximo - 1, ObjAlcancia.darBilletes().Count);
        }
    }
}