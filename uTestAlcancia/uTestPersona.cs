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
        #region Asociadores
        [TestMethod]
        public void uTestAsociarMoneda()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            ObjMoneda = new clsMoneda(50, 2005);
            Assert.AreEqual(true, ObjPersona.asociar(ObjMoneda));
            Assert.AreEqual(true, ObjPersona.Recuperar(50, ref ObjMonedaEsperada));
            Assert.AreEqual(ObjMonedaEsperada, ObjMoneda);
        }
        [TestMethod]
        public void uTestAsociarBillete()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            ObjBillete = new clsBillete(20000, 5, 6, 2016, "2180");
            Assert.AreEqual(true, ObjPersona.asociar(ObjBillete));
            Assert.AreEqual(true, ObjPersona.Recuperar(20000, ref ObjBilleteEsperado));
            Assert.AreEqual(ObjBilleteEsperado, ObjBillete);
        }
        #endregion
        #region Disociadores
        [TestMethod]
        public void uTestDisociarMoneda()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            ObjMoneda = null;
            int varCantidadMonedas = ObjPersona.darMonedas().Count;
            Assert.AreEqual(true, ObjPersona.disociar(500, ref ObjMoneda));
            Assert.AreEqual(500, ObjMoneda.darDenominacion());
            Assert.AreEqual(varCantidadMonedas - 1, ObjPersona.darMonedas().Count);
        }
        [TestMethod]
        public void uTestDisociarBilleteDenominacion()
        {
            ObjPersona = new clsPersona();
            ObjPersona.Generar();
            ObjBillete = null;
            int varCantidadBilletes = ObjPersona.darBilletes().Count;
            Assert.AreEqual(true, ObjPersona.disociar(2000, ref ObjBillete));
            Assert.AreEqual(2000, ObjBillete.darDenominacion());
            Assert.AreEqual(varCantidadBilletes - 1, ObjPersona.darBilletes().Count);
        }
        #endregion
    }
}