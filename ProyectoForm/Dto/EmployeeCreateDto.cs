using System.ComponentModel.DataAnnotations;

namespace ProyectoForm.Dto
{
    public class EmployeeCreateDto
    {
        [Required]
        public int NumeroInss { get; set; }
        public string? Nombre { get; set; }
        public string? Cargo { get; set; }
        public string? DateofBirth { get; set; }
        public string? Pais { get; set; }
        public string? Ciudad { get; set; }
        public double Salario { get; set; }
    }
}
