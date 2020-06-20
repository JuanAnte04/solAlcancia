using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsAlcancia
    {
        #region Atributos
        #region Propios
        /// <summary>
        /// Cantidad maxima de monedas que puede albergar la alcancia
        /// </summary>
        private int atrCapacidadMonedas = -1;
        /// <summary>
        /// Cantidad maxima de billetes que puede albergar la alcancia
        /// </summary>
        private int atrCapacidadBilletes = -1;
        #endregion
        #region Asociativos
        /// <summary>
        /// Coleccion de personas
        /// </summary>
        private List<clsPersona> atrAhorradores = new List<clsPersona>();
        /// <summary>
        /// Coleccion de monedas
        /// </summary>
        private List<clsMoneda> atrMonedas = new List<clsMoneda>();
        /// <summary>
        /// Colecion de billetes
        /// </summary>
        private List<clsBillete> atrBilletes = new List<clsBillete>();
        #endregion
        #region Auxiliares
        clsPersona auxObjAhorrador = null;
        clsMoneda auxObjMoneda = null;
        clsBillete auxObjBillete = null;
        #endregion
        #endregion
        #region Metodos
        #region Utilitario
        public void Generar()
        {
            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda());
            atrMonedas.Add(new clsMoneda(100, 1998));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete());
            atrBilletes.Add(new clsBillete(5000, 27, 2, 1999, "1889"));

            atrAhorradores = new List<clsPersona>();
            atrAhorradores.Add(new clsPersona());
            atrAhorradores.Add(new clsPersona(1062, "Jaime"));
        }
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor no parametrizado
        /// </summary>
        public clsAlcancia() { }
        /// <summary>
        /// Constructor parametrizado, crea una alcancia
        /// </summary>
        /// <param name="prmCapacidadMonedas"> Cantidad maxima de monedas </param>
        /// <param name="prmCapacidadBilletes"> Cantidad maxima de billetes </param>
        public clsAlcancia(int prmCapacidadMonedas, int prmCapacidadBilletes)
        {
            atrCapacidadMonedas = prmCapacidadMonedas;
            atrCapacidadBilletes = prmCapacidadBilletes;
        }
        #endregion
        #region Accesores
        /// <summary>
        /// Devuelve la cantidad maxima de monedas en la alcancia
        /// </summary>
        /// <returns> Entero </returns>
        public int darCapacidadMonedas()
        {
            return atrCapacidadMonedas;
        }
        /// <summary>
        /// Devuelve la cantidad maxima de billetes en la alcancia
        /// </summary>
        /// <returns> Entero </returns>
        public int darCapacidadBilletes()
        {
            return atrCapacidadBilletes;
        }
        /// <summary>
        /// Devuelve copia de la coleccion personas almacenadas
        /// </summary>
        /// <returns> Lista tipo clsPersona </returns>
        public List<clsPersona> darPersonas()
        {
            return atrAhorradores;
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
        #endregion
        #region Asociadores
        /// <summary>
        /// Asocia una persona
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public bool asociarAhorradorCon(clsPersona prmObjeto)
        {
            atrAhorradores.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia una moneda
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool asociarMonedaCon(clsMoneda prmObjeto)
        {
            atrMonedas.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia un billete
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
        /// <summary>
        /// Disocia una instancia de personas
        /// </summary>
        /// <param name="prmOID"> Identificador de persona </param>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public clsPersona disociarAhorradorCon(int prmOID)
        {
            auxObjAhorrador = recuperarPersonaCon(prmOID);
            atrAhorradores.Remove(auxObjAhorrador);
            return auxObjAhorrador;
        }
        public bool disociarAhorradorCon(clsPersona prmObjeto)
        {
            disociarMonedasDe(prmObjeto);
            disociarBilletesDe(prmObjeto);
            return atrAhorradores.Remove(prmObjeto);
        }
        /// <summary>
        /// Disocia una instancia de monedas
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
        /// Disocia una instancia de billetes
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de tipo billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public clsBillete disociarBilleteCon(int prmDenominacion)
        {
            auxObjBillete = recuperarBilleteCon(prmDenominacion);
            atrBilletes.Remove(auxObjBillete);
            return auxObjBillete;
        }
        public List<clsMoneda> disociarMonedasDe(clsPersona prmAhorrador)
        {
            List<clsMoneda> varMonedasDevueltas = new List<clsMoneda>();
            for (int varIndice = 0; varIndice < atrMonedas.Count; varIndice++)
            {
                if (atrMonedas[varIndice].darPropietario() == prmAhorrador)
                {
                    varMonedasDevueltas.Add(atrMonedas[varIndice]);
                    atrMonedas[varIndice].disociarAlcancia();
                    atrMonedas.Remove(atrMonedas[varIndice]);
                }
            }
            return varMonedasDevueltas;
        }
        public List<clsBillete> disociarBilletesDe(clsPersona prmAhorrador)
        {
            List<clsBillete> varBilletesDevueltos = new List<clsBillete>();
            for (int varIndice = 0; varIndice < atrBilletes.Count; varIndice++)
            {
                if (atrBilletes[varIndice].darPropietario() == prmAhorrador)
                {
                    varBilletesDevueltos.Add(atrBilletes[varIndice]);
                    atrBilletes[varIndice].disociarAlcancia();
                    atrBilletes.Remove(atrBilletes[varIndice]);
                }
            }
            return varBilletesDevueltos;
        }
        #endregion
        #region Recuperadores
        /// <summary>
        /// Encuentra una instancia de personas
        /// </summary>
        /// <param name="prmOID"> Identificador de persona </param>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public clsPersona recuperarPersonaCon(int prmOID)
        {
            foreach (clsPersona varObjeto in atrAhorradores)
                if (varObjeto.darOID() == prmOID)
                    return varObjeto;
            return null;
        }
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