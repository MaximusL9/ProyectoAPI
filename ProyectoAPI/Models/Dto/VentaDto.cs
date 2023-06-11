using System.ComponentModel.DataAnnotations;

namespace ProyectoAPI.Models.Dto
{
    public class VentaDto
    {
        public int IdVenta { get; set; }

        public double TotalVenta { get; set; }

        public double Cambio { get; set; }
        [Required]
        public int IdProducto { get; set; }
    }
}
