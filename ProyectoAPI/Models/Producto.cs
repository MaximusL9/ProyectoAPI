using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoAPI.Models
{
    public class Producto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] 

        public int IdProducto { get; set; }

        [Required]
        public string? NombreProducto { get; set; }

        [Required]
        public double PrecioProducto { get; set; }

        [Required]

        public int Existencias { get; set; }
    }
}
