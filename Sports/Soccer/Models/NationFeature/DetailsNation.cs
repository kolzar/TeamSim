namespace TeamSim.Sports.Soccer.Models.NationFeature
{
    public class DetailsNation
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ThreeLetterName { get; set; }
        public string NationalityName { get; set; }
        public Continent Continent { get; set; }
        public Region Region { get; set; }
        public Region ActualRegion { get; set; }
        public City CapitalCity { get; set; }
        public Stadium NationalStadium { get; set; }
        public Staff Manager { get; set; }
    }
}
