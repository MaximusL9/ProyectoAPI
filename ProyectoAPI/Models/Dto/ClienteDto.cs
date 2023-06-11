using System.ComponentModel.DataAnnotations;

namespace ProyectoAPI.Models.Dto
{
    public class ClienteDto
    {
        public int IdCliente { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Direccion { get; set; }
        [Required]
        public string? Telefono { get; set; }

        
    }
}
