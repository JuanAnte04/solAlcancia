namespace appAlcancia.Dominio
{
    public class clsMoneda
    {
        #region Atributos
        #region Propios
        /// <summary>
        /// Valor monetario
        /// </summary>
        protected int atrDenominacion = -1;
        /// <summary>
        /// Año de emision
        /// </summary>
        protected int atrAño = -1;
        #endregion
        #region Asociativos
        /// <summary>
        /// Propietario de la moneda o billete
        /// </summary>
        protected clsPersona atrPropetario = null;
        /// <summary>
        /// Relaciona la moneda o billete con la alcancia
        /// </summary>
        protected clsAlcancia atrAlcancia = null;
        #endregion
        #region Auxiliares
        clsPersona auxObjPropietario = null;
        clsAlcancia auxObjAlcancia = null;
        #endregion
        #endregion
        #region Metodos
        #region Utilitario
        public void Generar()
        {
            atrPropetario = new clsPersona();
            atrAlcancia = new clsAlcancia();
        }
        #endregion
        #region Constructores
        /// <summary>
        /// Constructor no parametrizado
        /// </summary>
        public clsMoneda() { }
        /// <summary>
        /// Constructor parametrizado, crea una instancia de monedas
        /// </summary>
        /// <param name="prmDenominacion"> Valor monetario </param>
        /// <param name="prmAño"> Año de emision </param>
        public clsMoneda(int prmDenominacion, int prmAño)
        {
            atrDenominacion = prmDenominacion;
            atrAño = prmAño;
        }
        #endregion
        #region Accesores
        /// <summary>
        /// Devuelve el valor monetario
        /// </summary>
        /// <returns> Entero </returns>
        public int darDenominacion()
        {
            return atrDenominacion;
        }
        /// <summary>
        /// Devuelve el año de emision
        /// </summary>
        /// <returns> Entero </returns>
        public int darAño()
        {
            return atrAño;
        }
        /// <summary>
        /// Devuelve el propietario
        /// </summary>
        /// <returns> Objeto de tipo persona </returns>
        public clsPersona darPropietario()
        {
            return atrPropetario;
        }
        /// <summary>
        /// Devuelve un objeto de tipo alcancia
        /// </summary>
        /// <returns> Objeto de tipo alcancia </returns>
        public clsAlcancia darAlcancia()
        {
            return atrAlcancia;
        }
        #endregion
        #region Mutadores
        #endregion
        #region Asociadores
        /// <summary>
        /// Asocia el propietario
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public bool asociarPropietarioCon(clsPersona prmObjeto)
        {
            if (atrPropetario != null)
                return false;
            atrPropetario = prmObjeto;
            return true;
        }
        /// <summary>
        /// Asocia la alcancia
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo alcancia </param>
        /// <returns> Boolean </returns>
        public bool asociarAlcanciaCon(clsAlcancia prmObjeto)
        {
            if (atrAlcancia != null)
                return false;
            atrAlcancia = prmObjeto;
            return true;
        }
        #endregion
        #region Disociadores
        public clsPersona disociarPropietario()
        {
            auxObjPropietario = atrPropetario;
            atrPropetario = null;
            return auxObjPropietario;
        }
        public clsAlcancia disociarAlcancia()
        {
            auxObjAlcancia = atrAlcancia;
            atrAlcancia = null;
            return auxObjAlcancia;
        }
        #endregion
        #region Recuperadores
        #endregion
        #endregion
    }
}