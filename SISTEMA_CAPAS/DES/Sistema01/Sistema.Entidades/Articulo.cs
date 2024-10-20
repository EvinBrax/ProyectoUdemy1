namespace Sistema.Entidades
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public int IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public bool Estado { get; set; }

    }
}
