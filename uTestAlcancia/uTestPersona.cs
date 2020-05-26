using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestPersona
    {
        private clsPersona ObjPersona;
        [TestMethod]
        public void uTestdarOID()
        {
            ObjPersona = new clsPersona();
            Assert.AreEqual(-1, ObjPersona.darOID());
        }
        [TestMethod]
        public void uTestdarNombre()
        {
            ObjPersona = new clsPersona();
            Assert.AreEqual("n.n", ObjPersona.darNombre());
        }
    }
}
