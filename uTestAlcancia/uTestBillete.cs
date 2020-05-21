using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestBillete
    {
        [TestMethod]
        public void uTestConstructor()
        {

        }
        [TestMethod]
        public void uTestAccesores()
        {
            clsBillete varObjeto = new clsBillete(1000, 4, 11, 2000, 9);
            Assert.AreEqual(4, varObjeto.darDia());
        }
    }
}
