using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoAPI.Models
{
    public class Cliente
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Direccion { get; set; }

        [Required]
        public string? Telefono { get; set; }

      



    }
}
