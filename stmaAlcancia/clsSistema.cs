using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsSistema
    {
        #region Atributos
        #region Propios
        #endregion
        #region Asociativos
        /// <summary>
        /// Asocia un objeto alcancia
        /// </summary>
        private clsAlcancia atrAlcancia = null;
        /// <summary>
        /// Coleccion de personas
        /// </summary>
        private List<clsPersona> atrAhorradores = null;
        /// <summary>
        /// Coleccion de monedas
        /// </summary>
        private List<clsMoneda> atrMonedas = null;
        /// <summary>
        /// Coleccion de billetes
        /// </summary>
        private List<clsBillete> atrBilletes = null;
        #endregion
        #region Auxiliares
        clsAlcancia auxObjAlcancia = null;
        clsPersona auxObjAhorrador = null;
        clsMoneda auxObjMoneda = null;
        clsBillete auxObjBillete = null;
        #endregion
        #endregion
        #region Metodos
        #region Utilitario
        /// <summary>
        /// Solo para pruebas
        /// </summary>
        public void Generar()
        {
            atrAlcancia = new clsAlcancia();

            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda());
            atrMonedas.Add(new clsMoneda(100, 1998));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete());
            atrBilletes.Add(new clsBillete(5000, 27, 2, 1999, "1889"));

            atrAhorradores = new List<clsPersona>();
            atrAhorradores.Add(new clsPersona());
            atrAhorradores.Add(new clsPersona(1062, "Jaime"));

            atrAhorradores[1].asociarAlcanciaCon(atrAlcancia);
            atrAlcancia.asociarAhorradorCon(atrAhorradores[1]);

        }
        #endregion
        #region Constructores
        public clsSistema()
        {
            atrAhorradores = new List<clsPersona>();
            atrMonedas = new List<clsMoneda>();
            atrBilletes = new List<clsBillete>();
        }
        #endregion
        #region Accesores
        /// <summary>
        /// Devuelve el objeto alcancia
        /// </summary>
        /// <returns> Tipo Alcancia </returns>
        public clsAlcancia darAlcancia()
        {
            return atrAlcancia;
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
        /// Asocia una alcancia
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo alcancia </param>
        /// <returns> Boolean </returns>
        public bool asociarAlcanciaCon(clsAlcancia prmObjeto)
        {
            atrAlcancia = prmObjeto;
            return true;
        }
        /// <summary>
        /// Asocia una persona
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public bool asociarAhorradorCon(clsPersona prmObjeto)
        {
            if (recuperarPersonaCon(prmObjeto.darOID()) == null)
            {
                atrAhorradores.Add(prmObjeto);
                return true;
            }
            return false;
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
            if (recuperarBilleteCon(prmObjeto.darSerial()) == null)
            {
                atrBilletes.Add(prmObjeto);
                return true;
            }
            return false;
        }
        #endregion
        #region Disociadores
        /// <summary>
        /// Disocia una persona
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
        /// <summary>
        /// Disocia una moneda
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
        /// Disocia un billete por denominacion
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
        /// <summary>
        /// Disocia un billete por serial
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public clsBillete disociarBilleteCon(string prmSerial)
        {
            auxObjBillete = recuperarBilleteCon(prmSerial);
            atrBilletes.Remove(auxObjBillete);
            return auxObjBillete;
        }
        #endregion
        #region Recuperadores
        /// <summary>
        /// Encuentra una instancia de tipo persona
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
        /// Encuentra una instancia de tipo moneda
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
        /// Encuentra una instancia de tipo billete por denominacion
        /// </summary>
        /// <param name="prmDenominacion"> Valor monetario </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public clsBillete recuperarBilleteCon(int prmDenominacion)
        {
            foreach (clsBillete varObjeto in atrBilletes)
                if (varObjeto.darDenominacion() == prmDenominacion)
                    return varObjeto;
            return null;
        }
        /// <summary>
        /// Encuentra una instancia de tipo billete por serial
        /// </summary>
        /// <param name="prmSerial"> Identificador de billete </param>
        /// <param name="prmObjeto"></param>
        /// <returns></returns>
        public clsBillete recuperarBilleteCon(string prmSerial)
        {
            foreach (clsBillete varObjeto in atrBilletes)
                if (varObjeto.darSerial() == prmSerial)
                    return varObjeto;
            return null;
        }
        #endregion
        #region CRUD
        #region Registradores
        /// <summary>
        /// Registra una instancia de alcancia
        /// </summary>
        /// <param name="prmCapacidadMonedas"> Cantidad maxima de monedas </param>
        /// <param name="prmCapacidadBilletes"> Cantidad maxima de billetes </param>
        /// <returns> Boolean </returns>
        public bool registrarAlcanciaCon(int prmCapacidadMonedas, int prmCapacidadBilletes)
        {
            return asociarAlcanciaCon(new clsAlcancia(prmCapacidadMonedas, prmCapacidadBilletes));
        }
        /// <summary>
        /// Registra una instancia de personas
        /// </summary>
        /// <param name="prmOID"> Identificador de persona </param>
        /// <param name="prmNombre"> Nombre de la persona </param>
        /// <returns> Boolean </returns>
        public bool registrarPersonaCon(int prmOID, string prmNombre)
        {
            return asociarAhorradorCon(new clsPersona(prmOID, prmNombre));
        }
        /// <summary>
        /// Registra una instancia de moneda
        /// </summary>
        /// <param name="prmDenominacion"> Valor monetario </param>
        /// <param name="prmAño"> Año de emision </param>
        /// <returns> Boolean </returns>
        public bool registrarMonedaCon(int prmDenominacion, int prmAño)
        {
            return asociarMonedaCon(new clsMoneda(prmDenominacion, prmAño));
        }
        /// <summary>
        /// Registra una instancia de billete
        /// </summary>
        /// <param name="prmSerial"> Identificador de billete </param>
        /// <param name="prmDenominacion"> Valor monetario </param>
        /// <param name="prmAño"> Año de emision </param>
        /// <param name="prmMes"> Mes de emision </param>
        /// <param name="prmDia"> Dia de emision </param>
        /// <returns> Boolean </returns>
        public bool registrarBilleteCon(string prmSerial, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            return asociarBilleteCon(new clsBillete(prmDenominacion, prmDia, prmMes, prmAño, prmSerial));
        }
        #endregion
        #region Actualizadores
        /// <summary>
        /// Modifica una instancia de personas
        /// </summary>
        /// <param name="prmOID"> Identificador de persona </param>
        /// <param name="prmNombre"> Nombre de la persona </param>
        /// <returns> Boolean </returns>
        public bool actualizarPersona(int prmOID, string prmNombre)
        {
            return recuperarPersonaCon(prmOID).Poner(prmNombre);
        }
        #endregion
        #region Eliminadores
        /// <summary>
        /// Elimina una instancia de alcancia
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo alcancia </param>
        /// <returns> Boolean </returns>
        public bool eliminarAlcanciaCon(ref clsAlcancia prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Elimina una instancia de personas
        /// </summary>
        /// <param name="prmOID"> Identificador de personas </param>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public clsPersona eliminarAhorradorCon(int prmOID)
        {
            auxObjAhorrador = disociarAhorradorCon(prmOID);
            if (auxObjAhorrador != null)
                return auxObjAhorrador.destruir();
            return null;
        }
        /// <summary>
        /// Elimina una instancia de monedas
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de moneda </param>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool eliminarMonedaCon(int prmDenominacion)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Elimina una instancia de billetes
        /// </summary>
        /// <param name="prmSerial"> Identificador de billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool eliminarBilleteCon(string prmSerial)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #endregion
        #endregion
    }
}