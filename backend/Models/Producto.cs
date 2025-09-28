namespace PruebaRedLab.Models
{
    public class Producto
    {
        public Guid Id { get; set; }
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public required bool Estado { get; set; }
        public string UsuarioCreacion { get; set; } 
        public DateTime FechaCreacion { get; set; }
        
        public string UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
