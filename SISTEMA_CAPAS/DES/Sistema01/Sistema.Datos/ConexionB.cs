using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Sistema.Datos
{
    public class ConexionB
    {
        /// <summary>
        /// Almacena el nombre y la Base de Datos que se conecta
        /// </summary>
        private string Base;
        /// <summary>
        /// Indica el servidor donde esta alojada la base de datos
        /// Ip o Nombre de servidor(Aplicacion en Red)
        /// </summary>
        private string Servidor;
        /// <summary>
        /// Usuario que accede a la Base de Datos
        /// </summary>
        private string Usuario;
        /// <summary>
        /// Clave que permite al usuario acceso a la base de datos
        /// </summary>
        private string Clave;
        /// <summary>
        /// Que tipo de autenticación sera utilizada
        /// Autenticación de Windows | Autenticación de SQL Server
        /// </summary>
        private bool Seguridad;

        /// <summary>
        /// Objeto que Instancia a la clase "Conexion"
        /// Metodo que permite generar la cadena de conexión
        /// </summary>
        private static ConexionB Con = null;

        /// <summary>
        /// CONSTRUCTOR
        /// La clase no puede ser instanciada desde otra clase
        /// Se permite la instanciación solo en la misma clase
        /// </summary>
        private ConexionB()
        {
            Servidor = "DESKTOP-LU4DGAM\\BRAX";
            Base = "PROYECTO_BDSISTEMA";
            Usuario = "KPRUEBAS";
            Clave = "KevinSA";
            Seguridad = true; // true -- Autenticacion de Windows | false -- Autenticacion de SQL Server
        }

        /// <summary>
        /// Metodo que genera la conexion
        /// </summary>
        /// <returns></returns>
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            try
            {
                //Conexion a Base de datos
                Cadena.ConnectionString = "Server" + Servidor + "; Database=" + Base + ";";

                if (Seguridad)
                {
                    //Seguridad integrada de windows
                    Cadena.ConnectionString += "Trusted_Connection = True";

                    //Seguridad integrada de windows para Trabajos con bases de datos de SQL Server.
                    Cadena.ConnectionString += "Integrated Security = SSPI";
                }
                else
                    Cadena.ConnectionString += "User Id=" + Usuario + ";Password =" + Clave;

                string cadenaconexion = ConfigurationManager.ConnectionStrings["ConexionBDKEV"].ConnectionString;

                //Conexion a Base de datos - Segunda Forma de instanciar el "ConnectionString - Directo"
                //Cadena.ConnectionString = "Data Source=DESKTOP-LU4DGAM\\BRAX;Initial Catalog=PROYECTO_BDSISTEMA;User ID=sa;Password=KevinSA";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }

            return Cadena;
        }

        /// <summary>
        /// Metodo que Verifica si ya se tiene una instancia de la clase
        /// </summary>
        /// <returns>la instancia de la cadena de conexión</returns>
        public static ConexionB GetInstancia()
        {
            if (Con == null)
                Con = new ConexionB();

            return Con;
        }
    }
}
