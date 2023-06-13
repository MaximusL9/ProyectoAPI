using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAPI.Data;
using ProyectoAPI.Models.Dto;
using ProyectoAPI.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace ProyectoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectControllers : ControllerBase
    {
        private readonly ProyectContext _db;
        private readonly ILogger<ProyectControllers> _logger;

        public ProyectControllers(ILogger<ProyectControllers> logger, ProyectContext db)
        {
            _logger = logger;
            _db = db;
        }
        //METODOS DE LOS EMPLEADOS
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetEmployees() 
        {
            _logger.LogInformation("Obtener los Empleados");
            return Ok(await _db.Employees.ToListAsync());
        }

        [HttpGet("{id:int}", Name = "GetEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<EmployeeDto>> GetEmployee(int id) 
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Empleado con Inss {id}");
                return BadRequest();
            }
            var employee = await _db.Employees.FirstOrDefaultAsync(s => s.NumeroInss == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<EmployeeDto>> AddEmployee([FromBody] EmployeeCreateDto employeeCreateDto) 
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            if (await _db.Employees.FirstOrDefaultAsync(n => n.Nombre.ToLower() == employeeCreateDto.Nombre.ToLower()) != null) 
            {
                ModelState.AddModelError("NombreExiste", "¡El Empleado con ese nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (employeeCreateDto == null) 
            {
                return BadRequest(ModelState);
            }

            Employee modelo = new()
            {
                NumeroInss = employeeCreateDto.NumeroInss,
                Nombre = employeeCreateDto.Nombre,
                Cargo = employeeCreateDto.Cargo,
                DateofBirth = employeeCreateDto.DateofBirth,
                Pais = employeeCreateDto.Pais,
                Ciudad = employeeCreateDto.Ciudad,
                Salario = employeeCreateDto.Salario,
            };

            await _db.Employees.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetEmployee", new { id=modelo.NumeroInss}, modelo);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteEmployee(int id) 
        {
            if (id == 0) 
            {
                return BadRequest();
            }
            var employee = await _db.Employees.FirstOrDefaultAsync(n => n.NumeroInss == id);

            if (employee == null) 
            {
                return NotFound();
            }
            _db.Employees.Remove(employee);
            await _db.SaveChangesAsync(true);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeUpdateDto employeeUpdateDto) 
        {
            if (employeeUpdateDto == null || id != employeeUpdateDto.NumeroInss) 
            {
                return BadRequest();
            }

            Employee modelo = new()
            {
                NumeroInss = employeeUpdateDto.NumeroInss,
                Nombre = employeeUpdateDto.Nombre,
                Cargo = employeeUpdateDto.Cargo,
                DateofBirth = employeeUpdateDto.DateofBirth,
                Pais = employeeUpdateDto.Pais,
                Ciudad = employeeUpdateDto.Ciudad,
                Salario = employeeUpdateDto.Salario,
            };

            _db.Employees.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialEmployee(int id, JsonPatchDocument<EmployeeUpdateDto> patchDto) 
        {
            if (patchDto == null || id == 0) 
            {
                return BadRequest();
            }
            var employee = await _db.Employees.AsNoTracking().FirstOrDefaultAsync(n => n.NumeroInss == id);
            EmployeeUpdateDto employeeDto = new()
            {
                NumeroInss=employee.NumeroInss,
                Nombre=employee.Nombre,
                Cargo = employee.Cargo,
                DateofBirth=employee.DateofBirth,
                Pais = employee.Pais,
                Ciudad=employee.Ciudad,
                Salario=employee.Salario
            };
            if (employeeDto == null) return BadRequest();

            patchDto.ApplyTo(employeeDto, ModelState);

            if(!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            Employee modelo = new() 
            {
                NumeroInss=employeeDto.NumeroInss,
                Nombre = employeeDto.Nombre,
                Cargo = employeeDto.Cargo,
                DateofBirth = employeeDto.DateofBirth,
                Pais = employeeDto.Pais,
                Ciudad = employeeDto.Ciudad,
                Salario = employeeDto.Salario
            };
            _db.Employees.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }
        //METODOS AGREGAR a
    }
}
