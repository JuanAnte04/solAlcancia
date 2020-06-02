using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestAlcancia
    {
        private clsAlcancia ObjAlcancia;
        private clsMoneda ObjMoneda;
        private clsBillete ObjBillete;
        private clsPersona ObjPersona;
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
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(true, ObjAlcancia.recuperar(100, ref ObjMoneda));
            Assert.AreEqual(100, ObjMoneda.darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBillete()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjBillete = new clsBillete();
            Assert.AreEqual(true, ObjAlcancia.recuperar(5000, ref ObjBillete));
            Assert.AreEqual(5000, ObjBillete.darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarPesona()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjPersona = new clsPersona();
            Assert.AreEqual(true, ObjAlcancia.recuperar(1062, ref ObjPersona));
            Assert.AreEqual(1062, ObjPersona.darOID());
        }
    }
}