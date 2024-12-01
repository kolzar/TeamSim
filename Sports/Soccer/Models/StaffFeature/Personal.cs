namespace TeamSim.Sports.Soccer.Models.StaffFeature
{
    public class Personal
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CommonName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int YearOfBirth { get; set; }
        public string Classification { get; set; }
        public Nation Nation { get; set; }
        public Nation SecondNation { get; set; }
        public int IntApps { get; set; }
        public int IntGoals { get; set; }
    }
}
