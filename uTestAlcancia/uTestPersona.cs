using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestPersona
    {
        private clsPersona ObjPersona;
        private clsMoneda ObjMoneda;
        private clsBillete ObjBillete;
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
        #region Constructor
        [TestMethod]
        public void uTestConstructorPrm()
        {
            ObjPersona = new clsPersona(1061, "Juan");
            Assert.AreNotEqual(null, ObjPersona);
            Assert.AreEqual(1061, ObjPersona.darOID());
            Assert.AreEqual("Juan", ObjPersona.darNombre());
        }
        #endregion
        #region Recuperadores
        [TestMethod]
        public void uTestRecuperarMoneda()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            ObjMoneda = new clsMoneda();
            Assert.AreEqual(true, ObjPersona.Recuperar(500, ref ObjMoneda));
            Assert.AreEqual(500, ObjMoneda.darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBillete()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            ObjBillete = new clsBillete();
            Assert.AreEqual(true, ObjPersona.Recuperar(2000, ref ObjBillete));
            Assert.AreEqual(2000, ObjBillete.darDenominacion());
        }
        #endregion
    }
}