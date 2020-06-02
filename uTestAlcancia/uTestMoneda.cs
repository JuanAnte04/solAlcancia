using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestMoneda
    {
        private clsMoneda ObjMoneda;
        #region Accesores
        [TestMethod]
        public void uTestdarDenominacion()
        {
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(-1, ObjMoneda.darDenominacion());
        }
        [TestMethod]
        public void uTestdarAño()
        {
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(-1, ObjMoneda.darAño());
        }
        [TestMethod]
        public void uTestdarPropietario()
        {
            ObjMoneda = new clsMoneda();
            ObjMoneda.Generar();
            Assert.AreNotEqual(null, ObjMoneda.darPropietario());
        }
        [TestMethod]
        public void uTestdarAlcancia()
        {
            ObjMoneda = new clsMoneda();
            ObjMoneda.Generar();
            Assert.AreNotEqual(null, ObjMoneda.darAlcancia());
        }
        #endregion
        #region Mutadores
        [TestMethod]
        public void uTestponerPropietario()
        {
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(true, ObjMoneda.Poner(new clsPersona()));
            Assert.AreNotEqual(null, ObjMoneda.darPropietario());
        }
        [TestMethod]
        public void uTestponerAlcancia()
        {
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(true, ObjMoneda.Poner(new clsAlcancia()));
            Assert.AreNotEqual(null, ObjMoneda.darAlcancia());
        }
        #endregion
        [TestMethod]
        public void uTestConstructorPrm()
        {
            ObjMoneda = new clsMoneda(500, 1999);
            Assert.AreNotEqual(null, ObjMoneda);
            Assert.AreEqual(500, ObjMoneda.darDenominacion());
            Assert.AreEqual(1999, ObjMoneda.darAño());
        }
    }
}