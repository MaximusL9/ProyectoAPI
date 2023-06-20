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

        public double Iva { get; set; }
        public double Cambio { get; set; }
        
       
        public int? IdCliente{ get; set; }

       
        [ForeignKey("IdCliente")]

        public Cliente? cliente { get; set; }

        public DateTime Fecha { get; set; }



    }
}
