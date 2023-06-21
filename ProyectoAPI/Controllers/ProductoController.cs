using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProyectoAPI.Data;
using ProyectoAPI.Models;
using ProyectoAPI.Models.Dto;
using ProyectoAPI.Repository;
using ProyectoAPI.Repository.IRepository;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ProyectoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        //Metodos Http y uso del mapeado para cada uno de los controladores junto con su respectivo repository
        private readonly IProductoRepositery _productoRepo;
        private readonly ILogger<ProductoController> _logger;
        private readonly IMapper _mapper;

        public ProductoController(ILogger<ProductoController> logger, IProductoRepositery productoRepo, IMapper mapper)
        {
            _logger = logger;
            _productoRepo = productoRepo;
            _mapper = mapper;
        }
        //METODOS HTTP DE LOS PRODUCTOS
        [HttpGet("GetProductos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
       
        public async Task<ActionResult<IEnumerable<ProductoDto>>> GetProductos()
        {
            _logger.LogInformation("Obtener Productos");
            var ListaProductos = await _productoRepo.GetAll();
            return Ok( _mapper.Map<IEnumerable<ProductoDto>>(ListaProductos));
        }

        [HttpGet("{Id:int}", Name = "GetProductosId")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ProductoDto>> GetProductoId(int Id)
        {
            if(Id == 0) 
            {
                _logger.LogError($"Error al traer el Producto con el ID {Id}");
                return BadRequest(Id); 
            }
            var producto = await _productoRepo.Get(p => p.IdProducto == Id);

            if (producto == null) 
            { 
                return NotFound(); 
            }

            return Ok(_mapper.Map<ProductoDto>(producto));
        }

        [HttpPost("AddProducto")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ProductoDto>> RegistrarProducto([FromBody] RegistrarProductoDto productoCreateDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _productoRepo.Get(p => p.NombreProducto.ToLower() == productoCreateDto.NombreProducto.ToLower()) != null) 
            {

                ModelState.AddModelError("Producto existente", "Error, el producto ya existe");
                return BadRequest(ModelState);
            }

            Producto PModel = _mapper.Map<Producto>(productoCreateDto);
            await _productoRepo.Create(PModel);
            
            return CreatedAtRoute( new { id = PModel.IdProducto }, PModel);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> actualizarProducto(int Id, [FromBody] ActualizarProductoDto productoUpdateDto)
        {
            if (productoUpdateDto == null || Id != productoUpdateDto.IdProducto)
            {
                return BadRequest();
            }

            Producto Pmodel = _mapper.Map<Producto>(productoUpdateDto);

           await _productoRepo.updateProducto(Pmodel);
           
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> EliminarProducto(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var PModel = await _productoRepo.Get(n => n.IdProducto == id);
            
            if(PModel == null)
            {
                return BadRequest();
            }

            await  _productoRepo.Remove(PModel);
          
            return NoContent();
        }
    }
}
         
      

