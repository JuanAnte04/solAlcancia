using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestAlcancia
    {
        private clsAlcancia objAlcancia;
        [TestMethod]
        public void uTestdarCapacidad()
        {
            objAlcancia = new clsAlcancia();
            Assert.AreEqual(-1, objAlcancia.darCapacidadMonedas());
            Assert.AreEqual(-1, objAlcancia.darCapacidadBilletes());
        }
    }
}