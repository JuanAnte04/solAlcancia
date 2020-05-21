using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    class clsSistema
    {
        #region Atributos
        #region Propios
        #endregion
        #region Asociativos
        private clsAlcancia atrAlcancia = null;
        private List<clsPersona> atrAhorradores = null;
        private List<clsMoneda> atrMonedas = null;
        private List<clsBillete> atrBilletes = null;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        #endregion
        #region Accesores
        public clsAlcancia darAlcancia()
        {
            //To-do: Implementar
            return null;
        }
        #endregion
        #region Mutadores
        public bool poner(clsAlcancia prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
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
        #region CRUD
        #region Registrar
        public bool Registrar(int prmCapacidad)
        {
            //To-do: Implementar
            return false;
        }
        public bool Registrar(int prmOID, string prmNombre)
        {
            //To-do: Implementar
            return false;
        }
        public bool Registrar(int prmDenominacion, int prmAño)
        {
            //To-do: Implementar
            return false;
        }
        public bool Registrar(int prmSerial, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region Actualizar
        public bool Actualizar(int prmCapacidad)
        {
            //To-do: Implementar
            return false;
        }
        public bool Actualizar(int prmOID, string prmNombre)
        {
            //To-do: Implementar
            return false;
        }
        public bool Actualizar(int prmDenominacion, int prmAño)
        {
            //To-do: Implementar
            return false;
        }
        public bool Actualizar(int prmSerial,int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region Eliminar
        public bool Eliminar(int prmOID, ref clsPersona prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        public bool Eliminar(ref clsAlcancia prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        public bool Eliminar(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        public bool Eliminar(int prmDenominacion, ref clsBillete prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #endregion
        #endregion
    }
}
