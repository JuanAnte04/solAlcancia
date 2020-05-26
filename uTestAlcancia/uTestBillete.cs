using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestBillete
    {
        private clsBillete ObjBillete;
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
    }
}
