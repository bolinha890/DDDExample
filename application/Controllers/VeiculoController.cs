using Domain;
using Domain.Command;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IveiculoService _veiculoService;

        public VeiculoController(IveiculoService veiculoService)
        {

        }
        [HttpPost]
        [Route ("CadastrarVeiculo")]
        public async  Task< IActionResult> PostAsync([FromBody] VeiculoCommand command)
        {
          
            return Ok(await _veiculoService.PostAsync(command));
        }
        [HttpGet] 
        [Route ("SimularAluguel")]
        public IActionResult GetAsync()
        {
            return Ok();
        }
        [HttpPost]
        [Route ("Alugar")]
        public IActionResult PostAsync()
        {
            return Ok();
        }
    }
}
