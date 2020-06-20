using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    //Generar y constructor no prm
    [TestClass]
    public class uTestPersona
    {
        private clsPersona ObjPersona;
        private clsMoneda ObjMoneda, ObjMonedaEsperada;
        private clsBillete ObjBillete, ObjBilleteEsperado;
        int varValorMaximo;
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
        [TestMethod]
        public void uTestDarMonedas()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            Assert.AreNotEqual(null, ObjPersona.darMonedas());
        }
        [TestMethod]
        public void uTestDarBilletes()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            Assert.AreNotEqual(null, ObjPersona.darBilletes());
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
            Assert.AreEqual(true, ObjPersona.asociarAlcanciaCon(new clsAlcancia()));
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
            ObjPersona.Generar();
            Assert.AreEqual(500, new clsPersona().recuperarMonedaCon(500).darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBillete()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            Assert.AreEqual(2000, ObjPersona.recuperarBilleteCon(2000).darDenominacion());
        }
        #endregion
        #region Asociadores
        [TestMethod]
        public void uTestAsociarMoneda()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            ObjMoneda = new clsMoneda(50, 2005);
            Assert.AreEqual(true, ObjPersona.asociarMonedaCon(ObjMoneda));
            Assert.AreEqual(ObjMoneda, ObjPersona.recuperarMonedaCon(50));
        }
        [TestMethod]
        public void uTestAsociarBillete()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            ObjBillete = new clsBillete(20000, 5, 6, 2016, "2180");
            Assert.AreEqual(true, ObjPersona.asociarBilleteCon(ObjBillete));
            Assert.AreEqual(ObjBillete, ObjPersona.recuperarBilleteCon(20000));
        }
        #endregion
        #region Disociadores
        [TestMethod]
        public void uTestDisociarMoneda()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            varValorMaximo = ObjPersona.darMonedas().Count - 1;
            Assert.AreEqual(500, ObjPersona.disociarMonedaCon(500).darDenominacion());
            Assert.AreEqual(varValorMaximo, ObjPersona.darMonedas().Count);
        }
        [TestMethod]
        public void uTestDisociarBilleteDenominacion()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            varValorMaximo = ObjPersona.darBilletes().Count - 1;
            Assert.AreEqual(2000, ObjPersona.disociarBilleteCon(2000).darDenominacion());
            Assert.AreEqual(varValorMaximo, ObjPersona.darBilletes().Count);
        }
        #endregion
    }
}