namespace TeamSim.Sports.Soccer.Models.ClubFeature
{
    public class StaffClub
    {
        public Staff AssistantManager { get; set; }
        public List<Staff> Coaches { get; set; }
        public Staff Manager { get; set; }
        public List<Staff> Physios { get; set; }
        public List<Staff> Scouts { get; set; }
    }
}
