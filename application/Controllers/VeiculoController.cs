﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        [HttpPost("CadastrarVeiculo")]
        public IActionResult PostAsync([FromBody] VeiculoCommand command)
        {
            return Ok();
        }

        public IActionResult SimularAluguel()
        {
            return Ok();
        }

        public IActionResult Alguar()
        {
            return Ok();
        }
    }
}
