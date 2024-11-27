namespace TeamSim.Sports.Soccer.Models
{
    public class Precipitation
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Dry { get; set; }
        public int Wet { get; set; }
        public int Drizzle { get; set; }
        public int Shower { get; set; }
        public int DownPour { get; set; }
    }
}
