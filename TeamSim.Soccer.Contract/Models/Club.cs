using TeamSim.Sports.Soccer.Models.ClubFeature;

namespace TeamSim.Sports.Soccer.Models
{
    public class Club
    {
        public Details Details { get; set; }
        public StadiumClub StadiumClub { get; set; }
        public PrefsClub PrefsClub { get; set; }
        public Colours Colours { get; set; }
        public Board Board { get; set; }
        public StaffClub StaffClub { get; set; }
        public Squad Squad { get; set; }
    }
}