using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestPersona
    {
        private clsPersona ObjPersona;
        #region Accesores
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
        [TestMethod]
        public void uTestdarAlcancia()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            Assert.AreNotEqual(null, ObjPersona.darAlcancia());
        }
        #endregion
        #region Mutadores
        [TestMethod]
        public void uTestponerNombre()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Poner("Prueba");
            Assert.AreEqual("Prueba", ObjPersona.darNombre());
        }
        [TestMethod]
        public void uTestponerAlcancia()
        {
            ObjPersona = new clsPersona();
            Assert.AreEqual(true, ObjPersona.Poner(new clsAlcancia()));
            Assert.AreNotEqual(null, ObjPersona.darAlcancia());
        }
        #endregion
    }
}
