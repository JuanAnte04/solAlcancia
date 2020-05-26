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
        #endregion
        #region Metodos
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
            //To-do: Implementar
        }
        public void Generar()
        {
            atrDenominacion = 500;
            atrAño = 1984;
            atrAlcancia = new clsAlcancia();
            atrPropetario = new clsPersona();
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
        /// <summary>
        /// Modifica el propietario
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public bool Poner(clsPersona prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Modifica la alcancia
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo alcancia </param>
        /// <returns> Boolean </returns>
        public bool Poner(clsAlcancia prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region Asociadores
        #endregion
        #region Disociadores
        #endregion
        #region Recuperadores
        #endregion
        #endregion
    }
}
