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
    }
}
