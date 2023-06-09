﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoAPI.Data;
using ProyectoAPI.Models;
using ProyectoAPI.Models.Dto;
using ProyectoAPI.Repository;
using ProyectoAPI.Repository.IRepository;

namespace ProyectoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        //Metodos Http y uso del mapeado para cada uno de los controladores junto con su respectivo repository
        private readonly IClientesRepositery IC;
        private readonly ILogger<ClienteController> logger;
        private readonly IMapper mapper;

        public ClienteController(IClientesRepositery iC, ILogger<ClienteController> logger, IMapper mapper)
        {
            IC = iC;
            this.logger = logger;
            this.mapper = mapper;
        }
        //METODOS HTTP DE LOS CLIENTES
        [HttpGet("GetAllClients")]

        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<Cliente>>> GetAllVenta() {

            var Vmodel = await IC.GetAll();

            return Ok(Vmodel);
        }
        [HttpGet("{id:int}", Name = "GetIdCliente")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClienteDto>> GetIdCliente(int id) {


            if (id == 0) {

                logger.LogError("Id invalido");
                return BadRequest();
            }

            var Cmodel = await IC.Get(x => x.IdCliente == id);

            if (Cmodel == null) { return NotFound(); }

            return Ok(mapper.Map<ClienteDto>(Cmodel));
        }


        [HttpPost("AddCliente")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ClienteDto>> RegistrarCliente([FromBody] RegistrarClienteDto Adto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await IC.Get(p => p.Nombre.ToLower() == Adto.Nombre.ToLower()) != null)
            {

                ModelState.AddModelError("Cliente existente", "Error el cliente Ya existe");
                return BadRequest(ModelState);
            }

            var CModel = mapper.Map<Cliente>(Adto);
            await IC.Create(CModel);


            return CreatedAtRoute(new { id = CModel.IdCliente }, CModel);
        }

        [HttpPut(Name = "UpdateCliente")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> ActualizarCliente([FromBody] ModificarClienteDto Mdto, int Id)
        {
            if (Mdto == null || Id != Mdto.IdCliente) { return BadRequest(); }
            Cliente modelo=mapper.Map<Cliente>(Mdto);
            await IC.updateCliente(modelo);
            return NoContent();
        }

        [HttpDelete("DeleteCliente")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
            
        public async Task<IActionResult> EliminarCliente( int Id) {

            var Cmodel = await IC.Get(x => x.IdCliente == Id);

            if ( Cmodel == null) { return BadRequest();}

            await IC.Remove(Cmodel);

            return NoContent();
        }
    }
}
