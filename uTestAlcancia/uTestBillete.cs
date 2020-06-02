using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestBillete
    {
        private clsBillete ObjBillete;
        #region Accesores
        [TestMethod]
        public void uTestdarMes()
        {
            ObjBillete = new clsBillete();
            Assert.AreEqual(-1, ObjBillete.darMes());
        }
        [TestMethod]
        public void uTestdarDia()
        {
            ObjBillete = new clsBillete();
            Assert.AreEqual(-1, ObjBillete.darDia());
        }
        [TestMethod]
        public void uTestdarSerial()
        {
            ObjBillete = new clsBillete();
            Assert.AreEqual(-1, ObjBillete.darSerial());
        }
        #endregion
        [TestMethod]
        public void uTestConstructorPrm()
        {
            ObjBillete = new clsBillete(2000, 26, 1, 1998, 1898);
            Assert.AreNotEqual(null, ObjBillete);
            Assert.AreEqual(2000, ObjBillete.darDenominacion());
            Assert.AreEqual(26, ObjBillete.darDia());
            Assert.AreEqual(1, ObjBillete.darMes());
            Assert.AreEqual(1998, ObjBillete.darAño());
            Assert.AreEqual(1898, ObjBillete.darSerial());
        }
    }
}
