namespace appAlcancia.Dominio
{
    public class clsBillete : clsMoneda
    {
        #region Atributos
        #region Propios
        /// <summary>
        /// Serial del billete, atributo identificador (OID) de billete
        /// </summary>
        private string atrSerial = "-1";
        /// <summary>
        /// Dia de emision
        /// </summary>
        private int atrDia = -1;
        /// <summary>
        /// Mes de emision
        /// </summary>
        private int atrMes = -1;
        #endregion
        #region Asociativos
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        /// <summary>
        /// Constructor no parametrizado
        /// </summary>
        public clsBillete() { }
        /// <summary>
        /// Constructor parametrizado, crea y devuelve una instancia de billetes
        /// </summary>
        /// <param name="prmDenominacion"> Valor monetario </param>
        /// <param name="prmDia"> Dia de emision </param>
        /// <param name="prmMes"> Mes de emision </param>
        /// <param name="prmAño"> Año de emision </param>
        /// <param name="prmSerial"> Numero serial del billete </param>
        public clsBillete(int prmDenominacion, int prmDia, int prmMes, int prmAño, string prmSerial):base(prmDenominacion, prmAño)
        {
            atrDia = prmDia;
            atrMes = prmMes;
            atrSerial = prmSerial;
        }
        #endregion
        #region Accesores
        /// <summary>
        /// Devuelve el mes de emision
        /// </summary>
        /// <returns> Entero </returns>
        public int darMes()
        {
            return atrMes;
        }
        /// <summary>
        /// Devuelve el dia de emision
        /// </summary>
        /// <returns> Entero </returns>
        public int darDia()
        {
            return atrDia;
        }
        /// <summary>
        /// Devuelve el serial del billete
        /// </summary>
        /// <returns> Entero </returns>
        public string darSerial()
        {
            return atrSerial;
        }
        #endregion
        #region Mutadores
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