using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Sistema.Datos
{
    /// <summary>
    /// SE RECOMIENDA TRABAJAR CON ESTA CLASE DE CONEXION A BD 
    /// Ya que se puede modificar los datos de conexión (Servidor, bd, usuario, autenticacion, ect..)
    /// De igual manera realizando la conexión mediante Archivo de configuración del aplicativo es una forma segura si el config esta encriptado
    /// </summary>
    public class Conexion
    {
        /// <summary>
        /// Objeto que Instancia a la clase "Conexion"
        /// Sobre el Metodo que permite generar la cadena de conexión
        /// </summary>
        private static Conexion Con = null;

        /// <summary>
        /// CONSTRUCTOR
        /// La clase no puede ser instanciada desde otra clase
        /// Se permite la instanciación solo en la misma clase
        /// </summary>
        private Conexion(){ }

        /// <summary>
        /// Metodo que genera la conexion
        /// </summary>
        /// <returns></returns>
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            try
            {
                //Obtiene la cadena de conexion desde el archivo de configuración del aplicativo
                string cadenaconexion = ConfigurationManager.ConnectionStrings["ConexionBDKEV"].ConnectionString;
                Cadena.ConnectionString = cadenaconexion;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }

            return Cadena;
        }

        /// <summary>
        /// Funcion que Verifica si ya se tiene una instancia de la clase
        /// </summary>
        /// <returns>Si no existe instancia de conexión, se crea</returns>
        public static Conexion GetInstancia()
        {
            if (Con == null)
                Con = new Conexion();

            return Con;
        }
    }
}
