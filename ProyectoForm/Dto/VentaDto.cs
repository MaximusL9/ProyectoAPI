using System.ComponentModel.DataAnnotations;

namespace ProyectoForm.Dto
{
    public class VentaDto
    {
        public int IdVenta { get; set; }

        [Required]
        public double TotalVenta { get; set; }

        [Required]

        public double Iva { get; set; }

        public double Cambio { get; set; }
        [Required]

        public int IdCliente { get; set; }

        public DateTime Fecha { get; set; }
    }
}
