using System.Collections.Generic;

namespace appAlcancia.Dominio
{
    public class clsSistema
    {
        #region Atributos
        #region Propios
        #endregion
        #region Asociativos
        /// <summary>
        /// Asocia un objeto alcancia
        /// </summary>
        private clsAlcancia atrAlcancia = null;
        /// <summary>
        /// Coleccion de personas
        /// </summary>
        private List<clsPersona> atrAhorradores = null;
        /// <summary>
        /// Coleccion de monedas
        /// </summary>
        private List<clsMoneda> atrMonedas = null;
        /// <summary>
        /// Coleccion de billetes
        /// </summary>
        private List<clsBillete> atrBilletes = null;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        /// <summary>
        /// Solo para pruebas
        /// </summary>
        public void Generar()
        {
            atrAlcancia = new clsAlcancia();
        }
        #endregion
        #region Accesores
        /// <summary>
        /// Devuelve el objeto alcancia
        /// </summary>
        /// <returns> Tipo Alcancia </returns>
        public clsAlcancia darAlcancia()
        {
            return atrAlcancia;
        }
        #endregion
        #region Mutadores
        /// <summary>
        /// Modifica el objeto alcancia
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo alcancia </param>
        /// <returns> Boolean </returns>
        public bool poner(clsAlcancia prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region Asociadores
        /// <summary>
        /// Asocia una persona
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public bool asociar(clsPersona prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Asocia una moneda
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool asociar(clsMoneda prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Asocia un billete
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
        /// Disocia una persona
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
        /// Disocia una moneda
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
        /// Disocia un billete
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
        /// Encuentra una instancia de tipo persona
        /// </summary>
        /// <param name="prmOID"> Identificador de persona </param>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public bool recuperar(int prmOID, ref clsPersona prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Encuentra una instancia de tipo moneda
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de moneda </param>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool recuperar(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Encuentra una instancia de tipo billete
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool recuperar(int prmDenominacion, ref clsBillete prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region CRUD
        #region Registrar
        /// <summary>
        /// Registra una instancia de alcancia
        /// </summary>
        /// <param name="prmCapacidadMonedas"> Cantidad maxima de monedas </param>
        /// <param name="prmCapacidadBilletes"> Cantidad maxima de billetes </param>
        /// <returns> Boolean </returns>
        public bool registrarAlcancia(int prmCapacidadMonedas, int prmCapacidadBilletes)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Registra una instancia de personas
        /// </summary>
        /// <param name="prmOID"> Identificador de persona </param>
        /// <param name="prmNombre"> Nombre de la persona </param>
        /// <returns> Boolean </returns>
        public bool registrarPersona(int prmOID, string prmNombre)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Registra una instancia de moneda
        /// </summary>
        /// <param name="prmDenominacion"> Valor monetario </param>
        /// <param name="prmAño"> Año de emision </param>
        /// <returns> Boolean </returns>
        public bool registrarMoneda(int prmDenominacion, int prmAño)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Registra una instancia de billete
        /// </summary>
        /// <param name="prmSerial"> Identificador de billete </param>
        /// <param name="prmDenominacion"> Valor monetario </param>
        /// <param name="prmAño"> Año de emision </param>
        /// <param name="prmMes"> Mes de emision </param>
        /// <param name="prmDia"> Dia de emision </param>
        /// <returns> Boolean </returns>
        public bool registrarBillete(int prmSerial, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region Actualizar
        /// <summary>
        /// Modifica una instancia de alcancia
        /// </summary>
        /// <param name="prmCapacidadMonedas"> Cantidad maxima de monedas </param>
        /// <param name="prmCapacidadBilletes"> Cantidad maxima de billetes </param>
        /// <returns> Boolean </returns>
        public bool actualizarAlcancia(int prmCapacidadMonedas, int prmCapacidadBilletes)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Modifica una instancia de personas
        /// </summary>
        /// <param name="prmOID"> Identificador de persona </param>
        /// <param name="prmNombre"> Nombre de la persona </param>
        /// <returns> Boolean </returns>
        public bool actualizarPersona(int prmOID, string prmNombre)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Modifica una instancia de monedas
        /// </summary>
        /// <param name="prmDenominacion"> Valor monetario </param>
        /// <param name="prmAño"> Año de emision </param>
        /// <returns> Boolean </returns>
        public bool actualizarMoneda(int prmDenominacion, int prmAño)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Modifica una instancia de billetes
        /// </summary>
        /// <param name="prmSerial"> Identificador de billete </param>
        /// <param name="prmDenominacion"> Valor monetario </param>
        /// <param name="prmAño"> Año de emision </param>
        /// <param name="prmMes"> Mes de emision </param>
        /// <param name="prmDia"> Dia de emision </param>
        /// <returns> Boolean </returns>
        public bool actualizarBillete(int prmSerial,int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #region Eliminar
        /// <summary>
        /// Elimina una instancia de alcancia
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo alcancia </param>
        /// <returns> Boolean </returns>
        public bool eliminarAlcancia(ref clsAlcancia prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Elimina una instancia de personas
        /// </summary>
        /// <param name="prmOID"> Identificador de personas </param>
        /// <param name="prmObjeto"> Objeto de tipo persona </param>
        /// <returns> Boolean </returns>
        public bool eliminarPersona(int prmOID, ref clsPersona prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Elimina una instancia de monedas
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de moneda </param>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool eliminarMoneda(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        /// <summary>
        /// Elimina una instancia de billetes
        /// </summary>
        /// <param name="prmSerial"> Identificador de billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool eliminarBillete(int prmSerial, ref clsBillete prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #endregion
        #endregion
    }
}
