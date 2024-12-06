using TeamSim.Sports.Soccer.Enumerations;

namespace TeamSim.Sports.Soccer.Models.StaffFeature
{
    public class ClubContract
    {
        public Club Club { get; set; }
        public string Name { get; set; }
        public JobAs JobAs { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime ContractExpires { get; set; }
        public PlayingSquad PlayingSquad { get; set; }
        public int EstimatedWage { get; set; }
        public int EstimatedValue { get; set; }


    }
}
