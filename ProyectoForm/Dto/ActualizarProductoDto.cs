using System.ComponentModel.DataAnnotations;

namespace ProyectoForm.Dto
{
    public class ActualizarProductoDto
    {
        

        public int IdProducto { get; set; }
        [Required]
        public string? NombreProducto { get; set; }
        [Required]
        public double PrecioProducto { get; set; }

        [Required]
        public int Existencias { get; set; }


    }
}
