﻿using TeamSim.Sports.Soccer.Models.StaffFeature;

namespace TeamSim.Sports.Soccer.Models
{
    public class Staff
    {
        public string Id { get; set; }  
        public Personal Personal { get; set; }
        public ContractStaff ContractStaff { get; set; }  
        public MentalTraits MentalTraits { get; set; }
        public Prefs Prefs { get; set; }
        public Positions Positions { get; set; }        
        public Player Player { get; set; }
        public List<History> History { get; set; }
    }
}
