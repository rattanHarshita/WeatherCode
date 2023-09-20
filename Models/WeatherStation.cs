using System;
using System.Collections.Generic;

namespace API_Project.Models
{
    public partial class WeatherStation
    {
        public string? Id { get; set; }
        public string? WsName { get; set; }
        public string? Site { get; set; }
        public string? Portfolio { get; set; }
        public string? State { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }

        public List<Variable> Variables { get; set; }
    }
}
