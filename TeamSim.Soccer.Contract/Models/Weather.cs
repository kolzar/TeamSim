using TeamSim.Soccer.Contract.Models.WeatherFeature;

namespace TeamSim.Sports.Soccer.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Season> Season { get; set; }
    }
}
