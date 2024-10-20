using Sistema.Datos;
using Sistema.Entidades;
using System.Data;
using System.Runtime.CompilerServices;

namespace Sistema.Negocio
{
    public class NGArticulo
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
            //Se crea instancia a la clase de ARTICULO - DB
            BDArticulo Datos = new BDArticulo();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            BDArticulo Datos = new BDArticulo();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(int IdCategoria, string Codigo, string Nombre, decimal PrecioVenta, int Stock, string Descripcion, string Imagen)
        {
            BDArticulo Datos = new BDArticulo();
            //Antes de crear el objeto para insertar el registro, se verifica si el registro existe o no en BD tabla "ARTICULO"
            string Existe = Datos.Existe(Nombre);

            if (!string.IsNullOrEmpty(Existe) && Existe.Equals("1"))
                return "El Articulo ya existe";
            else
            {
                Articulo Obj = new Articulo
                {
                    IdCategoria = IdCategoria,
                    Codigo = Codigo,
                    Nombre = Nombre,
                    PrecioVenta = PrecioVenta,
                    Stock = Stock,
                    Descripcion = Descripcion,
                    Imagen = Imagen
                };
                return Datos.Insertar(Obj);
            }
        }
        public static string Actualizar(int IdArticulo, string NombreAnt, string Nombre, int IdCategoria, string Codigo, decimal PrecioVenta, int Stock, string Descripcion, string Imagen)
        {
            BDArticulo Datos = new BDArticulo();
            Articulo Obj = new Articulo();

            if (NombreAnt.Equals(Nombre))
            {
                Obj.IdArticulo = IdArticulo;
                Obj.IdCategoria = IdCategoria;
                Obj.Codigo = Codigo;
                Obj.Nombre = Nombre;
                Obj.PrecioVenta = PrecioVenta;
                Obj.Stock = Stock;
                Obj.Descripcion = Descripcion;
                Obj.Imagen = Imagen;
                return Datos.Actualizar(Obj);
            }
            else
            {
                //Antes de actualizar el objeto, se verifica si el registro existe o no en BD tabla "ARTICULO"
                string Existe = Datos.Existe(Nombre);

                if (!string.IsNullOrEmpty(Existe) && Existe.Equals("1"))
                    return "El Articulo ya existe";
                else
                {
                    Obj.IdArticulo = IdArticulo;
                    Obj.IdCategoria = IdCategoria;
                    Obj.Codigo = Codigo;
                    Obj.Nombre = Nombre;
                    Obj.PrecioVenta = PrecioVenta;
                    Obj.Stock = Stock;
                    Obj.Descripcion = Descripcion;
                    Obj.Imagen = Imagen;
                    return Datos.Actualizar(Obj);
                }
            }
        }
        public static string Eliminar(int IdRegistro)
        {
            BDArticulo Datos = new BDArticulo();
            return Datos.Eliminar(IdRegistro);
        }
        public static string Activar(int IdRegistro)
        {
            BDArticulo Datos = new BDArticulo();
            return Datos.Activar(IdRegistro);
        }
        public static string Desactivar(int IdRegistro)
        {
            BDArticulo Datos = new BDArticulo();
            return Datos.Desactivar(IdRegistro);
        }
    }
}
