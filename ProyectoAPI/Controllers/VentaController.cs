using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ProyectoAPI.Models;
using ProyectoAPI.Models.Dto;
using ProyectoAPI.Repository;
using ProyectoAPI.Repository.IRepository;

namespace ProyectoAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class VentaController:ControllerBase
    {
        //Metodos Http y uso del mapeado para cada uno de los controladores junto con su respectivo repository
        private readonly IVentasRepositery VR;
        private readonly IMapper mapper;
        private readonly ILogger<VentaController> logger;

        public VentaController(IVentasRepositery vR, IMapper mapper, ILogger<VentaController> logger)
        {
            VR = vR;
            this.mapper = mapper;
            this.logger = logger;
        }
        //METODOS HTTP DE LAS VENTAS
        [HttpGet("GetAllVentas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<VentaDto>> GetVentas()
        {
            logger.LogInformation("Obteniendo Ventas");
            var listaVentas = await VR.GetAll();    
            return Ok(mapper.Map<IEnumerable<VentaDto>>(listaVentas));
        }

        [HttpGet("{id:int}",Name ="GetIdVenta")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public  async Task<ActionResult<VentaDto>> ObtenerVentasId(int id) {
        
          if(id == 0) { logger.LogError("Id invalido"); return BadRequest(); }
          var Vmodel = await VR.Get(x=> x.Equals(id));
            if (Vmodel.Equals(null)) { return NotFound(); }

            return Ok(mapper.Map<VentaDto>(Vmodel));        
        }

        [HttpPost("AddVenta")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<VentaDto>> RegistrarVenta([FromBody] RegistrarVentaDto Rvto)
        {

            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            var VModel = mapper.Map<Venta>(Rvto);
            await VR.Create(VModel);

            return CreatedAtRoute( new { id = VModel.IdVenta }, VModel);
        }
       
    }
}
