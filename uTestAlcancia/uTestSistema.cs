using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestAlcancia
{
    //Generar y constructor no prm
    [TestClass]
    public class uTestSistema
    {
        #region Objetos de prueba
        clsSistema ObjSistema;
        clsMoneda ObjMoneda, ObjMonedaEsperada;
        clsBillete ObjBillete, ObjBilleteEsperado;
        clsPersona ObjPersona;
        #endregion
        #region Metodos de prueba
        #region Accesores
        [TestMethod]
        public void uTestDarAlcancia()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreNotEqual(null, ObjSistema.darAlcancia());
        }
        [TestMethod]
        public void uTestDarPersonas()
        {
            ObjSistema = new clsSistema();
            Assert.AreNotEqual(null, ObjSistema.darPersonas());
        }
        [TestMethod]
        public void uTestDarMonedas()
        {
            ObjSistema = new clsSistema();
            Assert.AreNotEqual(null, ObjSistema.darMonedas());
        }
        [TestMethod]
        public void uTestDarBilletes()
        {
            ObjSistema = new clsSistema();
            Assert.AreNotEqual(null, ObjSistema.darBilletes());
        }
        #endregion
        #region Mutadores
        [TestMethod]
        public void uTestponerAlcancia()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.poner(new clsAlcancia()));
            Assert.AreNotEqual(null, ObjSistema.darAlcancia());
        }
        #endregion
        #region Recuperadores
        [TestMethod]
        public void uTestRecuperarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(100, ObjSistema.recuperarMoneda(100).darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBilleteDenominacion()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(5000, ObjSistema.recuperarBillete(5000).darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBilleteSerial()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual("1889", ObjSistema.recuperarBillete("1889").darSerial());
        }
        [TestMethod]
        public void uTestRecuperarPesona()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual("Jaime", ObjSistema.recuperarPersona(1062).darNombre());
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
            Assert.AreNotEqual(null, ObjSistema.recuperarPersona(1063));
            Assert.AreEqual(ObjPersona, ObjSistema.recuperarPersona(1063));
        }
        [TestMethod]
        public void uTestAsociarPersonaExistente()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjPersona = new clsPersona(-1, "Pepito");
            Assert.AreEqual(false, ObjSistema.asociar(ObjPersona));
            Assert.AreNotEqual("Pepito", ObjSistema.recuperarPersona(-1).darNombre());
        }
        [TestMethod]
        public void uTestAsociarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjMoneda = new clsMoneda(200, 1997);
            Assert.AreEqual(true, ObjSistema.asociar(ObjMoneda));
            Assert.AreEqual(ObjMoneda, ObjSistema.recuperarMoneda(200));
        }
        [TestMethod]
        public void uTestAsociarBilleteNuevo()
        {
            ObjSistema = new clsSistema();
            ObjBillete = new clsBillete(10000, 30, 2, 2006, "1888");
            Assert.AreEqual(true, ObjSistema.asociar(ObjBillete));
            Assert.AreEqual(ObjBillete, ObjSistema.recuperarBillete("1888"));
        }
        [TestMethod]
        public void uTestAsociarBilleteExistente()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjBillete = new clsBillete(1000, 4, 4, 2002, "1889");
            Assert.AreEqual(false, ObjSistema.asociar(ObjBillete));
            Assert.AreNotEqual(ObjBillete, ObjSistema.recuperarBillete("1889"));
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
        #region CRUDS
        #region Registradores
        [TestMethod]
        public void uTestRegistrarAlcancia()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarAlcancia(400, 100));
            Assert.AreEqual(400, ObjSistema.darAlcancia().darCapacidadMonedas());
            Assert.AreEqual(100, ObjSistema.darAlcancia().darCapacidadBilletes());
        }
        [TestMethod]
        public void uTestRegistrarPersona()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarPersona(4, "Perez"));
            Assert.AreEqual("Perez", ObjSistema.recuperarPersona(4).darNombre());
        }
        [TestMethod]
        public void uTestRegistrarMoneda()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarMoneda(50, 2008));
            Assert.AreEqual(2008, ObjSistema.recuperarMoneda(50).darAño());
        }
        [TestMethod]
        public void uTestRegistrarBillete()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarBillete("2345", 2000, 2007, 5, 20));
            Assert.AreEqual(2000, ObjSistema.recuperarBillete("2345").darDenominacion());
        }
        #endregion
        #region Actualizadores
        [TestMethod]
        public void uTestActualizarPersona()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.actualizarPersona(-1, "Climaco"));
            Assert.AreEqual("Climaco", ObjSistema.recuperarPersona(-1).darNombre());
        }
        [TestMethod]
        public void uTestActualizarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.actualizarMoneda(100, ObjSistema.recuperarPersona(-1)));
            Assert.AreEqual("n.n", ObjSistema.recuperarMoneda(100).darPropietario().darNombre());
        }
        [TestMethod]
        public void uTestActualizarBillete()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.actualizarBillete(5000, ObjSistema.recuperarPersona(1062)));
            Assert.AreEqual("Jaime", ObjSistema.recuperarBillete(5000).darPropietario().darNombre());
        }
        #endregion
        #endregion
        #endregion
    }
}