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
        [TestMethod]
        public void uTestdarCapacidad()
        {
            ObjAlcancia = new clsAlcancia();
            Assert.AreEqual(-1, ObjAlcancia.darCapacidadMonedas());
            Assert.AreEqual(-1, ObjAlcancia.darCapacidadBilletes());
        }
        [TestMethod]
        public void uTestrecuperarMoneda()
        {
            ObjAlcancia = new clsAlcancia();
            ObjAlcancia.Generar();
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(true, ObjAlcancia.recuperar(500, ref ObjMoneda));
            Assert.AreNotEqual(null, ObjMoneda);
            Assert.AreEqual(500, ObjMoneda.darDenominacion());
        }
    }
}