using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestSistema
    {
        clsSistema ObjSistema;
        clsMoneda ObjMoneda;
        clsBillete ObjBillete;
        clsPersona ObjPersona;
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
        [TestMethod]
        public void uTestrecuperarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.recuperar(100, ref ObjMoneda));
            Assert.AreEqual(100, ObjMoneda.darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBillete()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.recuperar(5000, ref ObjBillete));
            Assert.AreEqual(5000, ObjBillete.darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarPesona()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.recuperar(1062, ref ObjPersona));
            Assert.AreEqual(1062, ObjPersona.darOID());
        }
    }
}