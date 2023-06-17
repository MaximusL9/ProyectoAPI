using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoAPI.Models
{
    public class Venta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] 

        public int IdVenta { get; set; }

        [Required]
        public  double TotalVenta { get; set; }

        [Required]
        public double Cambio { get; set; }
        [Required]
        public double PrecioProducto { get; set; }
        [Required]
        public int Cantidad { get; set; }
        public int IdProducto { get; set; }
        
        [ForeignKey("IdProducto")]

        public Producto? Productos { get; set; }

        
    }
}
