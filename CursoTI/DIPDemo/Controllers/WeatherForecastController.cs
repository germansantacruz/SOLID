using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DIPDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        readonly DIPAbstractions.ILogger myLogger;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            DIPAbstractions.ILogger _myLogger)
        {
            _logger = logger;
            myLogger = _myLogger;
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

        [HttpGet("productservice")]
        public ActionResult ProductService()
        {
            ProductService service = new ProductService(this.myLogger);
            service.Create(new Product());

            return Ok("Completed!!!");
        }

        /*Esto para evitar hacer una referencia directa al proyecto
         * ILogger GetLogger()
         * {
         *      Logica para obtener el Logger
         *      Por ejemplo a traves del archivo de configuracion
         *      obtener el nombre del Assembly
         *      Assembly assembly = Assembly.Load();
         *      En el Assembly obtener una instancia mediante reflection del logger.
         * }
         */
    }
}
