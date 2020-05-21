
namespace appAlcancia.Dominio
{
    public class clsMoneda
    {
        #region Atributos
        #region Propios
        private int atrDenominacion = -1;
        private int atrAño = -1;
        #endregion
        #region Asociativos
        protected clsPersona atrPropetario = null;
        protected clsAlcancia atrAlcancia = null;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        protected clsMoneda() { }
        public clsMoneda(int prmDenominacion, int prmAño)
        {
            //To-do: Implementar
        }
        #endregion
        #region Accesores
        public int darDenominacion()
        {
            //To-do: Implementar
            return 0;
        }
        public int darAño()
        {
            //To-do: Implementar
            return 0;
        }
        public clsPersona darPropietario()
        {
            //To-do: Implementar
            return null;
        }
        public clsAlcancia darAlcancia()
        {
            //To-do: Implementar
            return null;
        }
        #endregion
        #region Mutadores
        protected bool poner(clsPersona prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        protected bool poner(clsAlcancia prmObjeto)
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
