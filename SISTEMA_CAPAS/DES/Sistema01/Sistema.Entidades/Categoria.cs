namespace Sistema.Entidades
{
    public class Categoria
    {
        //Entidad para los campos de la tabla "Categoria" de SQL

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
