using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsAlcancia
    {
        #region Atributos
        #region Propios
        private int atrCapacidad;
        #endregion
        #region Asociativos
        private List<clsPersona> atrAhorradores = null;
        private List<clsMoneda> atrMonedas = null;
        private List<clsBillete> atrBilletes = null;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        private clsAlcancia() { }
        public clsAlcancia(int prmCapacidad)
        {
            //To-do: Implementar
        }
        #endregion
        #region Accesores
        public int darCapacidad()
        {
            //To-do: Implementar
            return 0;
        }
        #endregion
        #region Mutadores

        #endregion
        #region Asociadores
        private bool asociar(clsPersona prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        private bool asociar(clsMoneda prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        private bool asociar(clsBillete prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region Disociadores
        private bool disociador(int prmOID, ref clsPersona prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        private bool disociador(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        private bool disociador(int prmDenominacion, ref clsBillete prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region Recuperadores
        private bool recuperar(int prmOID, ref clsPersona prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        private bool recuperar(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        private bool recuperar(int prmDenominacion, ref clsBillete prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #endregion
    }
}
