using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProyectoAPI.Data;
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
        [HttpGet("{Id:int}",Name ="GetProductosId")]
        public async Task<ActionResult<ProductoDto>> GetProductoId(int Id)
        {
            var producto = await PC.Productos.FirstOrDefaultAsync(p => p.IdProducto == Id); 
            
            if(producto == null) { return NotFound(); }

            return  map.Map<ProductoDto>(producto);


        }
    }
}
         
      

