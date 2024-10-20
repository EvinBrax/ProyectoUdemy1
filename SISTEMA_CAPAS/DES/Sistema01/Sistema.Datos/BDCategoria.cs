using System;
using System.Data;
using Sistema.Entidades;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class BDCategoria
    {
        //Funciones para poder manipular los datos de la BD referente a la tabla "CATEGORIA"
        //Se crean con el fin de que se ejecute la logica que consulta la BD desde el mismo proyecto
        //Esto evita problemas de seguridad sobre la capa de Presentacion

        public DataTable Listar()
        {
            //Proporciona una forma de leer una secuencia de filas de una base de datos en SQL SERVER
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            //Variable que establece la conexión a la BD SQL SERVER
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Obtener los registros de la Tabla Categoria y pasarlo al DataTable

                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Mediante el comando se hacer referencia a un objeto de BD con el nombre especificado
                //La clase SqlCommand representa una instrucción Transact-Sql o a un StoreProcedure
                //Se llama al Sp con el fin de consultar la tabla "categoria" de la BD
                SqlCommand Comando = new SqlCommand("categoria_listar", SqlCon);
                //Se utiliza para indicar el tipo de objeto o consulta a usar de la BD especificada
                Comando.CommandType = CommandType.StoredProcedure;

                //Se abre la conexión
                SqlCon.Open();
                //Se ejecuta el comando y se almacena el resultado 
                Resultado = Comando.ExecuteReader();

                //Se llena el DataTable
                Tabla.Load(Resultado);

                return Tabla;
            }
            catch (Exception ex)
            {
                //Se controla el error y se retorna
                throw ex;
            }
            finally
            {
                //Siempre se ejecuta esta sección de codigo - Con o sin error
                //Se cierra conexión a SQL si esta abierta
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }
        public DataTable Buscar(string Valor)
        {
            //Proporciona una forma de leer una secuencia de filas de una base de datos en SQL SERVER
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            //Variable que establece la conexión a la BD SQL SERVER
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Obtener los registros de la Tabla Categoria y pasarlo al DataTable

                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se llama al Sp con el fin de buscar la categoria enviada
                SqlCommand Comando = new SqlCommand("categoria_buscar", SqlCon);
                //Se utiliza para indicar el tipo de objeto o consulta a usar de la BD especificada
                Comando.CommandType = CommandType.StoredProcedure;
                //Se agrega un parametro adicional al comando, se indica el dato y el tipo que recibe el SP, se asigna el valor que recibe el metodo
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();

                Tabla.Load(Resultado);

                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }
        public DataTable Seleccionar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Mediante el comando se hacer referencia a un objeto de BD con el nombre especificado
                //La clase SqlCommand representa una instrucción Transact-Sql o a un StoreProcedure
                //Se llama al Sp con el fin de consultar la tabla "categoria" de la BD
                SqlCommand Comando = new SqlCommand("categoria_seleccionar", SqlCon);
                //Se utiliza para indicar el tipo de objeto o consulta a usar de la BD especificada
                Comando.CommandType = CommandType.StoredProcedure;

                //Se abre la conexión
                SqlCon.Open();
                //Se ejecuta el comando y se almacena el resultado 
                Resultado = Comando.ExecuteReader();

                //Se llena el DataTable
                Tabla.Load(Resultado);

                return Tabla;
            }
            catch (Exception ex)
            {
                //Se controla el error y se retorna
                throw ex;
            }
            finally
            {
                //Siempre se ejecuta esta sección de codigo - Con o sin error
                //Se cierra conexión a SQL si esta abierta
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }
        public string Existe(string Valor)
        {
            string Respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Logica para inserta un registro en la tabla "categoria" en la BD SQL SERVER
                //Se establece la conexión con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion();

                //Se consulta el objeto indicado en la BD
                SqlCommand Comando = new SqlCommand("categoria_existe", SqlCon);
                //Se indica que la instrucción que va a ejecutar el script es un SP - con parametro de entrada
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;

                //2da Forma de agregar parametros de entrada o de salida - Este parametro mapeado posteriormente es de salida
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);

                SqlCon.Open();
                Comando.ExecuteNonQuery();

                Respuesta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return Respuesta;
        }
        public string Insertar(Categoria Obj)
        {
            string Respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Logica para inserta un registro en la tabla "categoria" en la BD SQL SERVER
                //Se establece la conexión con la BD
                SqlCon = Conexion.GetInstancia().CrearConexion();

                //Se busca el objeto a buscar en la BD
                SqlCommand Comando = new SqlCommand("categoria_insertar", SqlCon);
                //Se indica que la instrucción que va a ejecutar el script es un SP
                Comando.CommandType = CommandType.StoredProcedure;
                //Se indica al comando que se envian dos parametros al SP
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                SqlCon.Open();
                //Se indica una instrucción condicional para validar la respuesta y almacenar dos posibles valores
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";

            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return Respuesta;
        }
        public string Actualizar(Categoria Obj)
        {
            string Respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Logica para actualizar un registro en la tabla "categoria" en la BD SQL SERVER
                SqlCon = Conexion.GetInstancia().CrearConexion();
                
                SqlCommand Comando = new SqlCommand("categoria_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                SqlCon.Open();

                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return Respuesta;
        }
        public string Eliminar(int Id)
        {
            string Respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Logica para eliminar un registro en la tabla "categoria" en la BD SQL SERVER
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoria_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return Respuesta;
        }
        public string Activar(int Id)
        {
            string Respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Logica para activar un registro en la tabla "categoria" en la BD SQL SERVER
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoria_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return Respuesta;
        }
        public string Desactivar(int Id)
        {
            string Respuesta = string.Empty;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Logica para desactivar un registro en la tabla "categoria" en la BD SQL SERVER
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("categoria_desactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return Respuesta;
        }
    }
}
