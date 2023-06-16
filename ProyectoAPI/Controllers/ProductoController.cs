using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProyectoAPI.Data;
using ProyectoAPI.Models;
using ProyectoAPI.Models.Dto;
using ProyectoAPI.Repository;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace ProyectoAPI.Controllers
{
    
    public class ProductoController : ControllerBase
    {

        private readonly IMapper map;
        private readonly ProyectContext PC;
        private readonly ProductoRepositery PR;

        private readonly ILogger<ProductoController>? logger;

        public ProductoController(ProyectContext pC, ILogger<ProductoController>? logger)
        {
            PC = pC;
            this.logger = logger;
        }

        [HttpGet("GetProductos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
       
        public async Task<ActionResult<IEnumerable<ProductoDto>>> GetProductos()
        {

            logger?.LogInformation("Obtener Productos");
            var ListaProductos = await PR.GetAll();
            return Ok( map.Map<IEnumerable<ProductoDto>>(ListaProductos));

        }
        [HttpGet("{Id:int}", Name = "GetProductosId")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ProductoDto>> GetProductoId(int Id)
        {
            if(Id == 0) { return BadRequest(Id); }
            var producto = await PR.Get(p => p.IdProducto == Id);

            if (producto == null) { return NotFound(); }

            return Ok(map.Map<ProductoDto>(producto));

        }
        [HttpPost("AddProducto")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ProductoDto>> RegistrarProducto([FromBody] RegistrarProductoDto Pdto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await PR.Get(p => p.Nombre_Produto.ToLower() == Pdto.Nombre_Producto.ToLower()) != null) {

                ModelState.AddModelError("Producto existente", "Error el producto Ya existe");
                return BadRequest(ModelState);
            }

            Producto PModel = map.Map<Producto>(Pdto);
            await PR.Create(PModel);
            

            return CreatedAtRoute("AddProducto", new { id = PModel.IdProducto }, PModel);
        }
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> actualizarProducto(int Id, [FromBody] ActualizarProductoDto Adto)
        {
            if (Adto == null || Id != Adto.IdProducto)
            {
                return BadRequest();
            }

            Producto Pmodel = map.Map<Producto>(Adto);

           await PR.updateProducto(Pmodel);
           

            return NoContent();
        }
        [HttpDelete("id:{int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> EliminarProducto(int id)
        {
            Producto? Pmodel = await PR.Get(n => n.IdProducto == id);
            
            if(Pmodel == null)
            {
                return BadRequest();
            }
           await  PR.Remove(Pmodel);
          
            return NoContent();

        }
    }
}
         
      

