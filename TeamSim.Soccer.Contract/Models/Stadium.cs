namespace TeamSim.Sports.Soccer.Models
{
    public class Stadium
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public int Capacity { get; set; }
        public int SeatingCapacity { get; set; }
        public int ExpansionCapacity { get; set; }
        public bool Covered {  get; set; }
        public bool UnderSoilHeating { get; set; }
    }
}
