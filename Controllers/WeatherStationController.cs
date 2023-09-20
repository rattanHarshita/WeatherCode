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

                #region Calculation of latest time

                if (customTableName == nameof(Data1).ToString())
                {
                    var latestTime = await _context.Data1s.MaxAsync(d => d.Timestamp);
                    item.timestamp = latestTime.ToString();
                }
                else if(customTableName == nameof(Data2).ToString())
                {
                    var latestTime = await _context.Data2s.MaxAsync(d => d.Timestamp);
                    item.timestamp = latestTime.ToString();
                }
                else if(customTableName == nameof(Data3).ToString())
                {
                    var latestTime = await _context.Data3s.MaxAsync(d => d.Timestamp);
                    item.timestamp = latestTime.ToString();
                }
                else if (customTableName == nameof(Data4).ToString())
                {
                    var latestTime = await _context.Data4s.MaxAsync(d => d.Timestamp);
                    item.timestamp = latestTime.ToString();
                }
                else if (customTableName == nameof(Data5).ToString())
                {
                    var latestTime = await _context.Data5s.MaxAsync(d => d.Timestamp);
                    item.timestamp = latestTime.ToString();
                }
                else if (customTableName == nameof(Data6).ToString())
                {
                    var latestTime = await _context.Data6s.MaxAsync(d => d.Timestamp);
                    item.timestamp = latestTime.ToString();
                }
                else if (customTableName == nameof(Data7).ToString())
                {
                    var latestTime = await _context.Data7s.MaxAsync(d => d.Timestamp);
                    item.timestamp = latestTime.ToString();
                }
                else if (customTableName == nameof(Data8).ToString())
                {
                    var latestTime = await _context.Data8s.MaxAsync(d => d.Timestamp);
                    item.timestamp = latestTime.ToString();
                }
                else if (customTableName == nameof(Data9).ToString())
                {
                    var latestTime = await _context.Data9s.MaxAsync(d => d.Timestamp);
                    item.timestamp = latestTime.ToString();
                }
                else if (customTableName == nameof(Data10).ToString())
                {
                    var latestTime = await _context.Data10s.MaxAsync(d => d.Timestamp);
                    item.timestamp = latestTime.ToString();
                }

                #endregion

                //var mytable = await _context.""

            }
            return Ok(WeatherStation);
        }



    }
}