﻿using System.Collections.Generic;

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

            atrMonedas = new List<clsMoneda>();
            atrMonedas.Add(new clsMoneda());
            atrMonedas.Add(new clsMoneda(100, 1998));

            atrBilletes = new List<clsBillete>();
            atrBilletes.Add(new clsBillete());
            atrBilletes.Add(new clsBillete(5000, 27, 2, 1999, "1889"));

            atrAhorradores = new List<clsPersona>();
            atrAhorradores.Add(new clsPersona());
            atrAhorradores.Add(new clsPersona(1062, "Jaime"));
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
        /// <summary>
        /// Devuelve copia de la coleccion personas almacenadas
        /// </summary>
        /// <returns> Lista tipo clsPersona </returns>
        public List<clsPersona> darPersonas()
        {
            return atrAhorradores;
        }
        /// <summary>
        /// Devuelve copia de la coleccion monedas almacenadas
        /// </summary>
        /// <returns> Lista tipo clsMoneda </returns>
        public List<clsMoneda> darMonedas()
        {
            return atrMonedas;
        }
        /// <summary>
        /// Devuelve copia de la coleccion billetes almacenadas
        /// </summary>
        /// <returns> Lista tipo clsBillete </returns>
        public List<clsBillete> darBilletes()
        {
            return atrBilletes;
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
            atrAlcancia = prmObjeto;
            return true;
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
            clsPersona varObjPersona = new clsPersona();
            if (recuperar(prmObjeto.darOID(), ref varObjPersona) == false)
            {
                atrAhorradores.Add(prmObjeto);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Asocia una moneda
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool asociar(clsMoneda prmObjeto)
        {
            atrMonedas.Add(prmObjeto);
            return true;
        }
        /// <summary>
        /// Asocia un billete
        /// </summary>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool asociar(clsBillete prmObjeto)
        {
            clsBillete varObjBillete = new clsBillete();
            if (recuperar(prmObjeto.darSerial(), ref varObjBillete) == false)
            {
                atrBilletes.Add(prmObjeto);
                return true;
            }
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
        public bool disociar(int prmOID, ref clsPersona prmObjeto)
        {
            clsPersona varObjeto = null;
            if (recuperar(prmOID, ref varObjeto) == true)
            {
                prmObjeto = varObjeto;
                return atrAhorradores.Remove(prmObjeto);
            }
            prmObjeto = null;
            return false;
        }
        /// <summary>
        /// Disocia una moneda
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de moneda </param>
        /// <param name="prmObjeto"> Objeto de tipo moneda </param>
        /// <returns> Boolean </returns>
        public bool disociar(int prmDenominacion, ref clsMoneda prmObjeto)
        {
            clsMoneda varObjeto = null;
            if (recuperar(prmDenominacion, ref varObjeto) == true)
            {
                prmObjeto = varObjeto;
                return atrMonedas.Remove(prmObjeto);
            }
            prmObjeto = null;
            return false;
        }
        /// <summary>
        /// Disocia un billete por denominacion
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool disociar(int prmDenominacion, ref clsBillete prmObjeto)
        {
            clsBillete varObjeto = null;
            if (recuperar(prmDenominacion, ref varObjeto) == true)
            {
                prmObjeto = varObjeto;
                return atrBilletes.Remove(prmObjeto);
            }
            prmObjeto = null;
            return false;
        }
        /// <summary>
        /// Disocia un billete por serial
        /// </summary>
        /// <param name="prmDenominacion"> Identificador de billete </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool disociar(string prmSerial, ref clsBillete prmObjeto)
        {
            clsBillete varObjeto = null;
            if (recuperar(prmSerial, ref varObjeto) == true)
            {
                prmObjeto = varObjeto;
                return atrBilletes.Remove(prmObjeto);
            }
            prmObjeto = null;
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
            foreach (clsPersona varObjeto in atrAhorradores)
            {
                if (varObjeto.darOID() == prmOID)
                {
                    prmObjeto = varObjeto;
                    return true;
                }
            }
            prmObjeto = null;
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
            foreach (clsMoneda varObjeto in atrMonedas)
            {
                if (varObjeto.darDenominacion() == prmDenominacion)
                {
                    prmObjeto = varObjeto;
                    return true;
                }
            }
            prmObjeto = null;
            return false;
        }
        /// <summary>
        /// Encuentra una instancia de tipo billete por denominacion
        /// </summary>
        /// <param name="prmDenominacion"> Valor monetario </param>
        /// <param name="prmObjeto"> Objeto de tipo billete </param>
        /// <returns> Boolean </returns>
        public bool recuperar(int prmDenominacion, ref clsBillete prmObjeto)
        {
            foreach (clsBillete varObjeto in atrBilletes)
            {
                if (varObjeto.darDenominacion() == prmDenominacion)
                {
                    prmObjeto = varObjeto;
                    return true;
                }
            }
            prmObjeto = null;
            return false;
        }
        /// <summary>
        /// Encuentra una instancia de tipo billete por serial
        /// </summary>
        /// <param name="prmSerial"> Identificador de billete </param>
        /// <param name="prmObjeto"></param>
        /// <returns></returns>
        public bool recuperar(string prmSerial, ref clsBillete prmObjeto)
        {
            foreach (clsBillete varObjeto in atrBilletes)
            {
                if (varObjeto.darSerial() == prmSerial)
                {
                    prmObjeto = varObjeto;
                    return true;
                }
            }
            prmObjeto = null;
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
        public bool registrarBillete(string prmSerial, int prmDenominacion, int prmAño, int prmMes, int prmDia)
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
        public bool actualizarBillete(string prmSerial,int prmDenominacion, int prmAño, int prmMes, int prmDia)
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
        public bool eliminarBillete(string prmSerial, ref clsBillete prmObjeto)
        {
            //To-do: Implementar
            return false;
        }
        #endregion
        #endregion
        #endregion
    }
}