using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsPersona
    {
        #region Atributos
        #region Propios
        private int atrOID = -1;
        private string atrNombre = "n.n";
        #endregion
        #region Asociativos
        private List<clsMoneda> atrMonedas = null;
        private List<clsBillete> atrBilletes = null;
        private clsAlcancia atrAlcancia = null;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        private clsPersona() { }
        public clsPersona(int prmOID, string prmNombre)
        {
            /* To-do: Implementar
            atrOID = prmOID;
            atrNombre = prmNombre;
            */
        }
        #endregion
        #region Accesores
        public int darOID()
        {
            //To-do: Implementar
            return 0;
        }
        public string darNombre()
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
        public void ponerNombre(string prmValor)
        {

        }
        #endregion
        #region Asociadores
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
