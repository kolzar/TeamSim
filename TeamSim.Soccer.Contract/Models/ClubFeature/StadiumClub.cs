using TeamSim.Sports.Soccer.Enumerations;

namespace TeamSim.Sports.Soccer.Models.ClubFeature
{
    public class StadiumClub
    {
        public Stadium Stadium { get; set; }
        public bool OwnStadium { get; set; }
        public Stadium ReserveStadium { get; set; }
        public Days Days { get; set; }
        public int Attendance {  get; set; }
        public int MinimumAttendance { get; set; }
        public int MaximumAttendance { get; set; }
    }
}
