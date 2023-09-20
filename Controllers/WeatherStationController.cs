using API_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq.Expressions;

namespace API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherStationController : ControllerBase
    {
        private readonly Proa_CodingContext _context;

        public WeatherStationController(Proa_CodingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetData()
        {
            List<WeatherStation> WeatherStation = new List<WeatherStation>();

            WeatherStation = await _context.WeatherStations.ToListAsync();
            
            List<Variable> Variables = new List<Variable>();


            foreach (var item in WeatherStation)
            {
                var filteredVar = await _context.Variables.Where(v => v.Id == item.Id).ToListAsync();
                //Variables.AddRange(filteredVar);

                item.Variables = new List<Variable>();

                item.Variables.AddRange(filteredVar);

                var customTableName = "Data" + item.Id;

                // var mytable = await _context..
                                
            }



            return Ok(WeatherStation);
        }

    }
}