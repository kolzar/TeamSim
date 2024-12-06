namespace TeamSim.Sports.Soccer.Models.RefereeFeature
{
    public class DetailsReferee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int YearOfBirth { get; set; }
        public Nation Nation { get; set; }
        public City City { get; set; }
    }
}