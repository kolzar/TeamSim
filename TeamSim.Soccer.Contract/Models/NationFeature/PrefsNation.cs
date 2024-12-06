using TeamSim.Sports.Soccer.Enumerations;

namespace TeamSim.Sports.Soccer.Models.NationFeature
{
    public class PrefsNation
    {
        public List<Club> RivalClubs { get; set; }
        public List<Staff> FavoriteStaff { get; set; }
        public List<Staff> DislikedStaff { get; set; }
        public List<MixColours> ForegroundColours { get; set; }
        public List<MixColours> BackgroundColours { get; set; }
    }
}
