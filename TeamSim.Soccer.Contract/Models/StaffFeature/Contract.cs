﻿namespace TeamSim.Sports.Soccer.Models.StaffFeature
{
    public class Contract
    {
        public int Id { get; set; }
        public ClubContract ClubContract { get; set; } 
        public NationContract NationContract { get; set; }
    }
}