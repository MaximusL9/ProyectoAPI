using System.ComponentModel.DataAnnotations;

namespace ProyectoForm.Dto
{
    public class RegistrarProductoDto
    {
        
        [Required]
        public string? NombreProducto { get; set; }
        [Required]
        public double PrecioProducto { get; set; }
        [Required]
        public int Existencias { get; set; }
    }
}
