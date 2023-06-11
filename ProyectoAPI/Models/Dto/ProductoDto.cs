using System.ComponentModel.DataAnnotations;

namespace ProyectoAPI.Models.Dto
{
    public class ProductoDto
    {
        public int IdProducto { get; set; }

        [Required]
        public string? Nombre_Producto { get; set; }
        [Required]
        public int Precio_Producto { get; set; }

        [Required]
        public int Existencias { get; set; }
    }
}
