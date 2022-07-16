using Business;
using Business.API;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Backend_Aliare.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("cidade")]
        public string ObtenhaPlaylistCidade(string cidade) => new ProcessoDeConsultaPorCidade().Obtenha(cidade);

        [HttpGet]
        [Route("coordenada")]
        public string ObtenhaPlaylistCoordenada(int latitute, int longitute)
        {

        }
    }
}
