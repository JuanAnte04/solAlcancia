using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsPersona
    {
        #region Atributos
        #region Propios
        /// <summary>
        /// Identificador de persona
        /// </summary>
        private int atrOID = -1;
        /// <summary>
        /// Nombre de la persona
        /// </summary>
        private string atrNombre = "n.n";
        #endregion
        #region Asociativos
        /// <summary>
        /// Coleccion de monedas
        /// </summary>
        private List<clsMoneda> atrMonedas = new List<clsMoneda>();
        /// <summary>
        /// Coleccion de billetes
        /// </summary>
        private List<clsBillete> atrBilletes = new List<clsBillete>();
        /// <summary>
        /// Asocia una alcancia
        /// </summary>
        private clsAlcancia atrAlcancia = null;
        #endregion
        #region Auxiliares
        clsAlcancia auxObjAlcancia = null;
        clsMoneda auxObjMoneda = null;
        clsBillete auxObjBillete = null;
        #endregion
        #endregion
        #region Metodos
        #region Utilitario
        public void Generar()
        {
            atrAlcancia = new clsAlcancia();

            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda());
            atrMonedas.Add(new clsMoneda(500, 1998));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete());
            atrBilletes.Add(new clsBillete(2000, 26, 1, 1998, "1888"));
        }
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor no parametrizado
        /// </summary>
        public clsPersona() { }
        /// <summary>
        /// Constructor parametrizado, crea y devuelve una instancia de personas
        /// </summary>
        /// <param name="prmOID"> Identificador de persona </param>
        /// <param name="prmNombre"> Nombre de la persona </param>
        public clsPersona(int prmOID, string prmNombre)
        {
            atrOID = prmOID;
            atrNombre = prmNombre;
        }
        #endregion
        #region Destructor
        /// <summary>
        /// Metodo que elimina las conexiones de persona
        /// </summary>
        /// <returns> La persona eliminada </returns>
        public clsPersona destruir()
        {
            disociarAlcancia();
            disociarMonedas();
            disociarBilletes();
            return this;
        }
        #endregion
        #region Accesores
        /// <summary>
        /// Devuelve el OID de persona
        /// </summary>
        /// <returns> Entero </returns>
        public int darOID()
        {
            return atrOID;
        }
        /// <summary>
        /// Devuelve el nombre de persona
        /// </summary>
        /// <returns> Cadena de caracteres </returns>
        public string darNombre()
        {
            return atrNombre;
        }
        /// <summary>
        /// Devuelve una alcancia
        /// </summary>
        /// <returns> Objeto de tipo alcancia </returns>
        public clsAlcancia darAlcancia()
        {
            return atrAlcancia;
        }
        /// <summary>
        /// Devuelve copia de la coleccion monedas almacenadas
        /// </summary>
        /// <returns> Lista tipo clsMoneda </returns>
        public List<clsMoneda> darMonedas()
        {
            return atrMonedas;
        }
        /// <summary>
        /// Devuelve copia de la coleccion billetes almacenadas
        /// </summary>
        /// <returns> Lista tipo clsBillete </returns>
        public List<clsBillete> darBilletes()
        {
            return atrBilletes;
        }
        #endregion
        #region Mutadores
        /// <summary>
        /// Modifica el nombre de persona
        /// </summary>
        /// <param name="prmNombre"> Nuevo nombre </param>
        public bool Poner(string prmNombre)
        {
            atrNombre = prmNombre;
            return true;
        }
        #endregion
        #region Asociadores
        /// <summary>
        /// Asocia la alcancia
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo alcancia </param>
        public bool asociarAlcanciaCon(clsAlcancia prmObjeto)
        {
            atrAlcancia = prmObjeto;
            return true;
        }
        /// <summary>
        /// Asocia una instancia de moneda
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool asociarMonedaCon(clsMoneda prmObjeto)
        {
            atrMonedas.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia una instancia de billete
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool asociarBilleteCon(clsBillete prmObjeto)
        {
            atrBilletes.Add(prmObjeto);
            return true;
        }
        #endregion
        #region Disociadores
        public clsAlcancia disociarAlcancia()
        {
            auxObjAlcancia = atrAlcancia;
            if (atrAlcancia != null)
            {
                atrAlcancia.disociarAhorradorCon(this);
                atrAlcancia = null;
            }
            return auxObjAlcancia;
        }
        /// <summary>
        /// Disocia una instancia de tipo moneda
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de moneda </param>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public clsMoneda disociarMonedaCon(int prmDenominacion)
        {
            auxObjMoneda = recuperarMonedaCon(prmDenominacion);
            atrMonedas.Remove(auxObjMoneda);
            return auxObjMoneda;
        }
        /// <summary>
        /// Disocia una instancia de tipo billete
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public clsBillete disociarBilleteCon(int prmDenominacion)
        {
            auxObjBillete = recuperarBilleteCon(prmDenominacion);
            atrBilletes.Remove(auxObjBillete);
            return auxObjBillete;
        }
        public List<clsMoneda> disociarMonedas()
        {
            List<clsMoneda> varMonedasDevueltas = new List<clsMoneda>();
            for (int varIndice = 0; varIndice < atrMonedas.Count; varIndice++)
            {
                varMonedasDevueltas.Add(atrMonedas[varIndice]);
                atrMonedas[varIndice].disociarPropietario();
                atrMonedas.Remove(atrMonedas[varIndice]);
                varIndice--;
            }
            return varMonedasDevueltas;
        }
        public List<clsBillete> disociarBilletes()
        {
            List<clsBillete> varBilletesDevueltos = new List<clsBillete>();
            for (int varIndice = 0; varIndice < atrBilletes.Count; varIndice++)
            {
                varBilletesDevueltos.Add(atrBilletes[varIndice]);
                atrBilletes[varIndice].disociarPropietario();
                atrBilletes.Remove(atrBilletes[varIndice]);
            }
            return varBilletesDevueltos;
        }
        #endregion
        #region Recuperadores
        /// <summary>
        /// Encuentra una instancia de monedas
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de moneda </param>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public clsMoneda recuperarMonedaCon(int prmDenominacion)
        {
            foreach (clsMoneda varObjeto in atrMonedas)
                if (varObjeto.darDenominacion() == prmDenominacion)
                    return varObjeto;
            return null;
        }
        /// <summary>
        /// Encuentra una instancia de billetes
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public clsBillete recuperarBilleteCon(int prmDenominacion)
        {
            foreach (clsBillete varObjeto in atrBilletes)
                if (varObjeto.darDenominacion() == prmDenominacion)
                    return varObjeto;
            return null;
        }
        #endregion
        #endregion
    }
}