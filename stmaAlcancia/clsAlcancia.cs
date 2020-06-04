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
        private List<clsPersona> atrAhorradores = null;
        /// <summary>
        /// Coleccion de monedas
        /// </summary>
        private List<clsMoneda> atrMonedas = null;
        /// <summary>
        /// Colecion de billetes
        /// </summary>
        private List<clsBillete> atrBilletes = null;
        #endregion
        #endregion
        #region Metodos
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
        public void Generar()
        {
            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda());
            atrMonedas.Add(new clsMoneda(100, 1998));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete());
            atrBilletes.Add(new clsBillete(5000, 27, 2, 1999, 1889));

            atrAhorradores = new List<clsPersona>();
            atrAhorradores.Add(new clsPersona());
            atrAhorradores.Add(new clsPersona(1062, "Jaime"));
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
        #endregion
        #region Mutadores
        #endregion
        #region Asociadores
        /// <summary>
        /// Asocia una persona
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public bool asociar(clsPersona prmObjeto)
        {
            atrAhorradores.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia una moneda
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool asociar(clsMoneda prmObjeto)
        {
            atrMonedas.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia un billete
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool asociar(clsBillete prmObjeto)
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
        public bool disociador(int prmOID, ref clsPersona prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Disocia una instancia de monedas
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de moneda </param>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool disociador(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Disocia una instancia de billetes
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de tipo billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool disociador(int prmDenominacion, ref clsBillete prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region Recuperadores
        /// <summary>
        /// Encuentra una instancia de personas
        /// </summary>
        /// <param name="prmOID"> Identificador de persona </param>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public bool recuperar(int prmOID, ref clsPersona prmObjeto)
        {
            foreach(clsPersona varObjeto in atrAhorradores)
            {
                if (varObjeto.darOID() == prmOID)
                {
                    prmObjeto = varObjeto;
                    return true;
                }
            }
            prmObjeto = null;
            return false;
        }
        /// <summary>
        /// Encuentra una instancia de monedas
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de moneda </param>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool recuperar(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            foreach (clsMoneda varObjeto in atrMonedas)
            {
                if (varObjeto.darDenominacion() == prmDenominacion)
                {
                    prmObjeto = varObjeto;
                    return true;
                }
            }
            prmObjeto = null;
            return false;
        }
        /// <summary>
        /// Encuentra una instancia de billetes
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool recuperar(int prmDenominacion, ref clsBillete prmObjeto)
        {
            foreach (clsBillete varObjeto in atrBilletes)
            {
                if (varObjeto.darDenominacion() == prmDenominacion)
                {
                    prmObjeto = varObjeto;
                    return true;
                }
            }
            prmObjeto = null;
            return false;
        }
        #endregion
        #endregion
    }
}
