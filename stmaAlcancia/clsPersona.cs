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
        private List<clsMoneda> atrMonedas = null;
        /// <summary>
        /// Coleccion de billetes
        /// </summary>
        private List<clsBillete> atrBilletes = null;
        /// <summary>
        /// Asocia una alcancia
        /// </summary>
        private clsAlcancia atrAlcancia = null;
        #endregion
        #endregion
        #region Metodos
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
            //To-do: Implementar
        }
        public void Generar()
        {
            atrAlcancia = new clsAlcancia();
            atrNombre = "Jorge Jair";
            atrOID = 1898;
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
        #endregion
        #region Mutadores
        /// <summary>
        /// Modifica el nombre de persona
        /// </summary>
        /// <param name="prmNombre"> Nuevo nombre </param>
        public void Poner(string prmNombre)
        {
            atrNombre = prmNombre;
        }
        /// <summary>
        /// Modifica la alcancia
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo alcancia </param>
        public void Poner(clsAlcancia prmObjeto)
        {
            atrAlcancia = prmObjeto;
        }
        #endregion
        #region Asociadores
        /// <summary>
        /// Asocia una instancia de moneda
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool asociar(clsMoneda prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Asocia una instancia de billete
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool asociar(clsBillete prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region Disociadores
        /// <summary>
        /// Disocia una instancia de tipo moneda
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
        /// Disocia una instancia de tipo billete
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de billete </param>
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
        /// Encuentra una instancia de monedas
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de moneda </param>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool Recuperar(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Encuentra una instancia de billetes
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool Recuperar(int prmDenominacion, ref clsBillete prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #endregion
    }
}
