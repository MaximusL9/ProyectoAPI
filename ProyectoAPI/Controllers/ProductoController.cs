using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProyectoAPI.Data;
using ProyectoAPI.Models;
using ProyectoAPI.Models.Dto;
using System.Collections.Generic;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace ProyectoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly IMapper map;
        private readonly ProyectContext PC;
        private readonly ILogger<ProductoController>? logger;

        public ProductoController(ProyectContext pC, ILogger<ProductoController>? logger)
        {
            PC = pC;
            this.logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<ProductoDto>>> GetProductos()
        {

            logger?.LogInformation("Obtener Productos");

            return Ok(await PC.Productos.ToListAsync());

        }
        [HttpGet("{Id:int}", Name = "GetProductosId")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ProductoDto>> GetProductoId(int Id)
        {
            var producto = await PC.Productos.FirstOrDefaultAsync(p => p.IdProducto == Id);

            if (producto == null) { return NotFound(); }

            return Ok(map.Map<ProductoDto>(producto));

        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ProductoDto>> RegistrarProducto([FromBody] RegistrarProductoDto Pdto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await PC.Productos.FirstOrDefaultAsync(p => p.Nombre_Produto.ToLower() == Pdto.Nombre_Producto.ToLower()) != null) {

                ModelState.AddModelError("Producto existente", "Error el producto Ya existe");
                return BadRequest(ModelState);
            }

            Producto PModel = map.Map<Producto>(Pdto);
            await PC.Productos.AddAsync(PModel);
            await PC.SaveChangesAsync();

            return CreatedAtRoute("GetEmployee", new { id = PModel.IdProducto }, PModel);
        }
    }
}
         
      

