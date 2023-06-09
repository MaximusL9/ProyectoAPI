using System.ComponentModel.DataAnnotations;

namespace ProyectoAPI.Models.Dto
{
    public class EmployeeUpdateDto
    {
        public int NumeroInss { get; set; }
        [Required]
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
        public DateTime DateofBirth { get; set; }
        public string? Pais { get; set; }
        public string? Ciudad { get; set; }
        public double Salario { get; set; }
    }
}
