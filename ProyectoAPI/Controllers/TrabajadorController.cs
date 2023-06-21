using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAPI.Data;
using ProyectoAPI.Models.Dto;
using ProyectoAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using ProyectoAPI.Repository.IRepository;
using AutoMapper;

namespace ProyectoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadorController : ControllerBase
    {
        //Metodos Http y uso del mapeado para cada uno de los controladores junto con su respectivo repository
        private readonly ITrabajadorRepository _trabajadorRepo;
        private readonly ILogger<TrabajadorController> _logger;
        private readonly IMapper _mapper;

        public TrabajadorController(ILogger<TrabajadorController> logger, ITrabajadorRepository trabajadorRepo, IMapper mapper)
        {
            _logger = logger;
            _trabajadorRepo = trabajadorRepo;
            _mapper = mapper;

        }
        //METODOS DE LOS HTTP DE LOS TRABAJADORES
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetEmployees() 
        {
            _logger.LogInformation("Obtener los Empleados");
            var employeeList = await _trabajadorRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<EmployeeDto>>(employeeList));
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
            var employee = await _trabajadorRepo.Get(n=> n.NumeroInss== id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<EmployeeDto>(employee));
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

            if (await _trabajadorRepo.Get(t=> t.Nombre.ToLower()==employeeCreateDto.Nombre.ToLower()) !=null)
            {
                ModelState.AddModelError("Nombre Existe", "¡El Empleado con ese nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (employeeCreateDto == null) 
            {
                return BadRequest(ModelState);
            }

            Employee modelo=_mapper.Map<Employee>(employeeCreateDto);

            await _trabajadorRepo.Create(modelo);

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
            var employee = await _trabajadorRepo.Get(n => n.NumeroInss == id);

            if (employee == null) 
            {
                return NotFound();
            }
            await _trabajadorRepo.Remove(employee);

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

            Employee modelo = _mapper.Map<Employee>(employeeUpdateDto);

            await _trabajadorRepo.Update(modelo);

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
            var employee = await _trabajadorRepo.Get(n => n.NumeroInss == id, tracked: false);
            EmployeeUpdateDto employeeDto = _mapper.Map<EmployeeUpdateDto>(employee);

            if (employeeDto == null) return BadRequest();

            patchDto.ApplyTo(employeeDto, ModelState);

            if(!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            Employee modelo=_mapper.Map<Employee>(employeeDto);

            await _trabajadorRepo.Update(modelo);

            return NoContent();
        }
    }
}
