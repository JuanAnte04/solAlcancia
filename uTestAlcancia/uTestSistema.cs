using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestSistema
    {
        clsSistema ObjSistema;
        [TestMethod]
        public void uTestdarAlcancia()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreNotEqual(null, ObjSistema.darAlcancia());
        }
        [TestMethod]
        public void uTestponerAlcancia()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.poner(new clsAlcancia()));
            Assert.AreNotEqual(null, ObjSistema.darAlcancia());
        }
    }
}