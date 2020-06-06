using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestSistema
    {
        #region Objetos de prueba
        clsSistema ObjSistema;
        clsMoneda ObjMoneda, ObjMonedaEsperada;
        clsBillete ObjBillete, ObjBilleteEsperado;
        clsPersona ObjPersona, ObjPersonaEsperada;
        #endregion
        #region Metodos de prueba
        #region Accesores, Mutadores
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
        public void uTestDarPersonas()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreNotEqual(null, ObjSistema.darPersonas());
        }
        [TestMethod]
        public void uTestDarMonedas()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreNotEqual(null, ObjSistema.darMonedas());
        }
        [TestMethod]
        public void uTestDarBilletes()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreNotEqual(null, ObjSistema.darBilletes());
        }
        #endregion
        #region Recuperadores
        [TestMethod]
        public void uTestrecuperarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.recuperar(100, ref ObjMoneda));
            Assert.AreEqual(100, ObjMoneda.darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBilleteDenominacion()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.recuperar(5000, ref ObjBillete));
            Assert.AreEqual(5000, ObjBillete.darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBilleteSerial()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.recuperar("1889", ref ObjBillete));
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
        #endregion
        #region Asociadores
        [TestMethod]
        public void uTestAsociarPersonaNuevo()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjPersona = new clsPersona(1063, "Pepito");
            Assert.AreEqual(true, ObjSistema.asociar(ObjPersona));
            Assert.AreEqual(true, ObjSistema.recuperar(1063, ref ObjPersonaEsperada));
            Assert.AreEqual(ObjPersonaEsperada, ObjPersona);
        }
        [TestMethod]
        public void uTestAsociarPersonaExistente()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjPersona = new clsPersona(-1, "Pepito");
            Assert.AreEqual(false, ObjSistema.asociar(ObjPersona));
            Assert.AreEqual(true, ObjSistema.recuperar(-1, ref ObjPersonaEsperada));
            Assert.AreNotEqual("Pepito", ObjPersonaEsperada.darNombre());
        }
        [TestMethod]
        public void uTestAsociarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjMoneda = new clsMoneda(200, 1997);
            Assert.AreEqual(true, ObjSistema.asociar(ObjMoneda));
            Assert.AreEqual(true, ObjSistema.recuperar(200, ref ObjMonedaEsperada));
            Assert.AreEqual(ObjMonedaEsperada, ObjMoneda);
        }
        [TestMethod]
        public void uTestAsociarBilleteNuevo()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjBillete = new clsBillete(10000, 30, 2, 2006, "1888");
            Assert.AreEqual(true, ObjSistema.asociar(ObjBillete));
            Assert.AreEqual(true, ObjSistema.recuperar("1888", ref ObjBilleteEsperado));
            Assert.AreEqual(ObjBilleteEsperado, ObjBillete);
        }
        [TestMethod]
        public void uTestAsociarBilleteExistente()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjBillete = new clsBillete(1000, 4, 4, 2002, "1889");
            Assert.AreEqual(false, ObjSistema.asociar(ObjBillete));
            Assert.AreEqual(true, ObjSistema.recuperar("1889", ref ObjBilleteEsperado));
            Assert.AreNotEqual(1000, ObjBilleteEsperado.darDenominacion());
        }
        #endregion
        #region Disociadores
        [TestMethod]
        public void uTestDisociarPersona()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjPersona = null;
            int varCantidadPersonas = ObjSistema.darPersonas().Count;
            Assert.AreEqual(true, ObjSistema.disociar(1062, ref ObjPersona));
            Assert.AreEqual(1062, ObjPersona.darOID());
            Assert.AreEqual(varCantidadPersonas - 1, ObjSistema.darPersonas().Count);
        }
        [TestMethod]
        public void uTestDisociarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjMoneda = null;
            int varCantidadMonedas = ObjSistema.darMonedas().Count;
            Assert.AreEqual(true, ObjSistema.disociar(100, ref ObjMoneda));
            Assert.AreEqual(100, ObjMoneda.darDenominacion());
            Assert.AreEqual(varCantidadMonedas - 1, ObjSistema.darMonedas().Count);
        }
        [TestMethod]
        public void uTestDisociarBilleteDenominacion()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjBillete = null;
            int varCantidadBilletes = ObjSistema.darBilletes().Count;
            Assert.AreEqual(true, ObjSistema.disociar(5000, ref ObjBillete));
            Assert.AreEqual(5000, ObjBillete.darDenominacion());
            Assert.AreEqual(varCantidadBilletes - 1, ObjSistema.darBilletes().Count);
        }
        [TestMethod]
        public void uTestDisociarBilleteSerial()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjBillete = null;
            int varCantidadBilletes = ObjSistema.darBilletes().Count;
            Assert.AreEqual(true, ObjSistema.disociar("1889", ref ObjBillete));
            Assert.AreEqual("1889", ObjBillete.darSerial());
            Assert.AreEqual(varCantidadBilletes - 1, ObjSistema.darBilletes().Count);
        }
        #endregion
        #endregion
    }
}