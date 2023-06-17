using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoAPI.Models
{
    public class Producto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] 

        public int IdProducto { get; set; }

        [Required]
        public string? Nombre_Producto { get; set; }

        [Required]
        public double Precio_Producto { get; set; }

        [Required]

        public int Existencias { get; set; }
    }
}
