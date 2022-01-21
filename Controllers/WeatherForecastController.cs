using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SQL_Lite.Data;
using SQL_Lite.Models;

namespace SQL_Lite.Controllers
{

    [ApiController]
    [Route("api")]
    public class WeatherForecastController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly CategoriaContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, CategoriaContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet("Teste")]
        public async Task<IEnumerable<Categoria>> Obter()
        {
            return await _context.Categorias.ToListAsync();
        }

    }
}
