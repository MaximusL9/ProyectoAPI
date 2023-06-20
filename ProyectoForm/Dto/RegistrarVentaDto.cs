using System.ComponentModel.DataAnnotations;

namespace ProyectoForm.Dto
{
    public class RegistrarVentaDto
    {
        

        [Required]
        public double TotalVenta { get; set; }

        [Required]

        public double Iva { get; set; }

        public double Cambio { get; set; }

        public int? IdCliente { get; set; }

        public DateTime Fecha { get; set; }
    }
}
