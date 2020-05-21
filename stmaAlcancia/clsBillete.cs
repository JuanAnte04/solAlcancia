using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsBillete : clsMoneda
    {
        #region Atributos
        #region Propios
        private int atrMes = -1;
        private int atrDia = -1;
        private int atrSerial = -1;
        #endregion
        #region Asociativos
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        private clsBillete() { }
        public clsBillete(int prmDenominacion, int prmDia, int prmMes, int prmAño, int prmSerial)
        {
            //To-do: Implementar
        }
        #endregion
        #region Accesores
        public int darMes()
        {
            //To-do: Implementar
            return 0;
        }
        public int darDia()
        {
            //To-do: Implementar
            return atrDia;
        }
        public int darSerial()
        {
            //To-do: Implementar
            return 0;
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
