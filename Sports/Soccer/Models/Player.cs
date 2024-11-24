namespace TeamSim.Sports.Soccer.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CommonName { get; set; }
        public string Country { get; set; }
        public int CountryId { get; set; }
        public string Gender { get; set; }
        public int BirthDate { get; set; }
        public int BirthYear { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Position1 { get; set; }
        public int Position2 { get; set; }
        public int Position3 { get; set; }
        public int Position4 { get; set; }
        public int Foot { get; set; }
        public int WeakFoot { get; set; }
        public string Club { get; set; }
        public double Value { get; set; }
        public double Wage { get; set; }
        public int Potential { get; set; }
        public int OverallRating { get; set; }
        public int PreferredFoot { get; set; }
        public int KitNumber { get; set; }
        public int WorkRate { get; set; }

    }

}