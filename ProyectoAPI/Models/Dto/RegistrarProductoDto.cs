using System.ComponentModel.DataAnnotations;

namespace ProyectoAPI.Models.Dto
{
    public class RegistrarProductoDto
    {
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public string? Nombre_Producto { get; set; }
        [Required]
        public double Precio_Producto { get; set; }
        [Required]
        public int Existencias { get; set; }
    }
}
