using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NGCategoria
    {
        //Funciones para poder comunicarse con los metodos de la capa datos
        //Esta capa tiene la logica de negocio de todo el proyecto
        //Como se observa la logica de las funciones es corta ya que la verdadera logica de cada funcion esta en la capa datos
        /*Se asigna "static" a las clases, 
         * ya que no se generaran objetos instanciando la clase 
         * SOLO se hace referencia a la clase "NGCategoria" directamente y al metodo especifico
         * sin la necesidad de crear un objeto en la capa presentacion.
        */

        public static DataTable Listar()
        {
            //Se crea instancia a la clase de Categoria - DB
            BDCategoria Datos = new BDCategoria();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            BDCategoria Datos = new BDCategoria();
            return Datos.Buscar(Valor);
        }
        public static DataTable Seleccionar()
        {
            //Se crea instancia a la clase de Categoria - DB
            BDCategoria Datos = new BDCategoria();
            return Datos.Seleccionar();
        }
        public static string Insertar(string Nombre, string Descripcion)
        {
            BDCategoria Datos = new BDCategoria();
            //Antes de crear el objeto para insertar el registro, se verifica si el registro existe o no en BD tabla "categoria"
            string Existe = Datos.Existe(Nombre);

            if (!string.IsNullOrEmpty(Existe) && Existe.Equals("1"))
                return "La categoria ya existe";
            else
            {
                Categoria Obj = new Categoria
                {
                    Nombre = Nombre,
                    Descripcion = Descripcion
                };
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int IdRegistro, string NombreAnt, string Nombre, string Descripcion)
        {
            BDCategoria Datos = new BDCategoria();
            Categoria Obj = new Categoria();

            if (NombreAnt.Equals(Nombre))
            {
                Obj.IdCategoria = IdRegistro;
                Obj.Nombre = Nombre;
                Obj.Descripcion = Descripcion;
                return Datos.Actualizar(Obj);
            }
            else
            {
                //Antes de actualizar el objeto, se verifica si el registro existe o no en BD tabla "categoria"
                string Existe = Datos.Existe(Nombre);

                if (!string.IsNullOrEmpty(Existe) && Existe.Equals("1"))
                    return "La categoria ya existe";
                else
                {
                    Obj.IdCategoria = IdRegistro;
                    Obj.Nombre = Nombre;
                    Obj.Descripcion = Descripcion;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Eliminar(int IdRegistro)
        {
            BDCategoria Datos = new BDCategoria();
            return Datos.Eliminar(IdRegistro);
        }
        public static string Activar(int IdRegistro)
        {
            BDCategoria Datos = new BDCategoria();
            return Datos.Activar(IdRegistro);
        }
        public static string Desactivar(int IdRegistro)
        {
            BDCategoria Datos = new BDCategoria();
            return Datos.Desactivar(IdRegistro);
        }
    }
}
