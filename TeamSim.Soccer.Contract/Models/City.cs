namespace TeamSim.Sports.Soccer.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nation Nation { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public int Attraction { get; set; }
        public Weather Weather { get; set; }
    }
}
