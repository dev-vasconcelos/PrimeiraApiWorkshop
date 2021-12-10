using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PrimeiraApiWorkshop.Controllers
{
    [ApiController] //Declarando esta classe como uma "apiController", essa declaração ela serve para que o próprio .net dinâmicamente consiga instanciar os controllers e seus contextos
    [Route("[controller]")] // Caminho para se chamar as funções via requisição
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        
        [HttpGet("/QualMaior/{numeroA}/{numeroB}")] //GET -> É o MÉTODO  da requisição HTTP. O método GET não envia "body".
        //Geralmente serve para representar endpoints que são de consulta.
        // O sinal de chaves "{}" encapsulam as pathVariables, que são as váriaveis de URL.
        public String ExemploTeste(int numeroA, int numeroB) {    
            if(numeroA > numeroB) {
                return "Numero A é maior que número B";
            } else {
                return "Numero B é maior que número A";
            }
        }
    }
}
