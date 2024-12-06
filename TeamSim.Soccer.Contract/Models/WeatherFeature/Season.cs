namespace TeamSim.Soccer.Contract.Models.WeatherFeature
{
    public class Season
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SeasonStartDay { get; set; }
        public Wind Wind { get; set; }
        public Precipitation Precipitation { get; set; }
        public Temperature Temperature { get; set; }
    }
}
