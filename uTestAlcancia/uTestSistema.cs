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
        clsMoneda ObjMoneda;
        clsBillete ObjBillete;
        clsPersona ObjPersona;
        int auxCantidadFinal = -1;
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
        public void uTestAsociarAlcancia()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.asociarAlcanciaCon(new clsAlcancia()));
            Assert.AreNotEqual(null, ObjSistema.darAlcancia());
        }
        #endregion
        #region Recuperadores
        [TestMethod]
        public void uTestRecuperarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(100, ObjSistema.recuperarMonedaCon(100).darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBilleteDenominacion()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(5000, ObjSistema.recuperarBilleteCon(5000).darDenominacion());
        }
        [TestMethod]
        public void uTestRecuperarBilleteSerial()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual("1889", ObjSistema.recuperarBilleteCon("1889").darSerial());
        }
        [TestMethod]
        public void uTestRecuperarPesona()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual("Jaime", ObjSistema.recuperarPersonaCon(1062).darNombre());
        }
        #endregion
        #region Asociadores
        [TestMethod]
        public void uTestAsociarPersonaNuevo()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.asociarAhorradorCon(new clsPersona(1063, "Pepito")));
            Assert.AreEqual(1063, ObjSistema.recuperarPersonaCon(1063).darOID());
            Assert.AreEqual("Pepito", ObjSistema.recuperarPersonaCon(1063).darNombre());
        }
        [TestMethod]
        public void uTestAsociarPersonaExistente()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(false, ObjSistema.asociarAhorradorCon(new clsPersona(-1, "Pepito")));
            Assert.AreEqual("n.n", ObjSistema.recuperarPersonaCon(-1).darNombre());
        }
        [TestMethod]
        public void uTestAsociarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjMoneda = new clsMoneda(200, 1997);
            Assert.AreEqual(true, ObjSistema.asociarMonedaCon(ObjMoneda));
            Assert.AreEqual(ObjMoneda, ObjSistema.recuperarMonedaCon(200));
        }
        [TestMethod]
        public void uTestAsociarBilleteNuevo()
        {
            ObjSistema = new clsSistema();
            ObjBillete = new clsBillete(10000, 30, 2, 2006, "1888");
            Assert.AreEqual(true, ObjSistema.asociarBilleteCon(ObjBillete));
            Assert.AreEqual(ObjBillete, ObjSistema.recuperarBilleteCon("1888"));
        }
        [TestMethod]
        public void uTestAsociarBilleteExistente()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjBillete = new clsBillete(1000, 4, 4, 2002, "1889");
            Assert.AreEqual(false, ObjSistema.asociarBilleteCon(ObjBillete));
            Assert.AreNotEqual(ObjBillete, ObjSistema.recuperarBilleteCon("1889"));
        }
        #endregion
        #region Disociadores
        [TestMethod]
        public void uTestDisociarPersona()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            auxCantidadFinal = ObjSistema.darPersonas().Count - 1;
            Assert.AreEqual(1062, ObjSistema.disociarAhorradorCon(1062).darOID());
            Assert.AreEqual(null, ObjSistema.recuperarPersonaCon(1062));
            Assert.AreEqual(auxCantidadFinal, ObjSistema.darPersonas().Count);
        }
        [TestMethod]
        public void uTestDisociarMoneda()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            auxCantidadFinal = ObjSistema.darMonedas().Count - 1;
            Assert.AreEqual(100, ObjSistema.disociarMonedaCon(100).darDenominacion());
            Assert.AreEqual(auxCantidadFinal, ObjSistema.darMonedas().Count);
        }
        [TestMethod]
        public void uTestDisociarBilleteDenominacion()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            auxCantidadFinal = ObjSistema.darBilletes().Count - 1;
            Assert.AreEqual(5000, ObjSistema.disociarBilleteCon(5000).darDenominacion());
            Assert.AreEqual(auxCantidadFinal, ObjSistema.darBilletes().Count);
        }
        [TestMethod]
        public void uTestDisociarBilleteSerial()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            auxCantidadFinal = ObjSistema.darBilletes().Count - 1;
            Assert.AreEqual("1889", ObjSistema.disociarBilleteCon("1889").darSerial());
            Assert.AreEqual(null, ObjSistema.recuperarBilleteCon("1889"));
            Assert.AreEqual(auxCantidadFinal, ObjSistema.darBilletes().Count);
        }
        #endregion
        #region CRUDS
        #region Registradores
        [TestMethod]
        public void uTestRegistrarAlcancia()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarAlcanciaCon(400, 100));
            Assert.AreEqual(400, ObjSistema.darAlcancia().darCapacidadMonedas());
            Assert.AreEqual(100, ObjSistema.darAlcancia().darCapacidadBilletes());
        }
        [TestMethod]
        public void uTestRegistrarPersona()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarPersonaCon(4, "Perez"));
            Assert.AreEqual("Perez", ObjSistema.recuperarPersonaCon(4).darNombre());
        }
        [TestMethod]
        public void uTestRegistrarMoneda()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarMonedaCon(50, 2008));
            Assert.AreEqual(2008, ObjSistema.recuperarMonedaCon(50).darAño());
        }
        [TestMethod]
        public void uTestRegistrarBillete()
        {
            ObjSistema = new clsSistema();
            Assert.AreEqual(true, ObjSistema.registrarBilleteCon("2345", 2000, 2007, 5, 20));
            Assert.AreEqual("2345", ObjSistema.recuperarBilleteCon("2345").darSerial());
            Assert.AreEqual(2000, ObjSistema.recuperarBilleteCon("2345").darDenominacion());
        }
        #endregion
        #region Actualizadores
        [TestMethod]
        public void uTestActualizarPersona()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            Assert.AreEqual(true, ObjSistema.actualizarPersona(-1, "Climaco"));
            Assert.AreEqual("Climaco", ObjSistema.recuperarPersonaCon(-1).darNombre());
        }
        #endregion
        #region Eliminadores
        [TestMethod]
        public void uTestEliminarAhorradorCon()
        {
            ObjSistema = new clsSistema();
            ObjSistema.Generar();
            ObjPersona = ObjSistema.eliminarAhorradorCon(1062);
            Assert.AreNotEqual(null, ObjPersona);
            Assert.AreEqual(null, ObjPersona.darAlcancia());
            Assert.AreEqual(0, ObjPersona.darMonedas().Count);
            Assert.AreEqual(0, ObjPersona.darBilletes().Count);

        }
        [TestMethod]
        public void uTestEliminarMoneda()
        {

        }
        [TestMethod]
        public void uTestEliminarBillete()
        {

        }
        #endregion
        #endregion
        #endregion
    }
}