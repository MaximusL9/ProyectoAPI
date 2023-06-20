using System.ComponentModel.DataAnnotations;

namespace ProyectoForm.Dto
{
    public class ProductoDgv
    {
        public int IdProducto { get; set; }

        [Required]
        public string? NombreProducto { get; set; }
        [Required]
        public int PrecioProducto { get; set; }

        [Required]
        public int cantidad { get; set; }
    }
}
