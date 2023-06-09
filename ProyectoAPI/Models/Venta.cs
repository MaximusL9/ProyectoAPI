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

        public int IdProducto { get; set; }
        
        public double Precio_Producto { get; set; }
        [ForeignKey("IdProducto")]

        public List<Producto>? Productos { get; set; }

        
    }
}
