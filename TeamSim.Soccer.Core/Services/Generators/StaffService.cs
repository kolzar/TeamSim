using System.Reflection;
using System.Runtime.ConstrainedExecution;
using TeamSim.Soccer.Contract.Utility;
using TeamSim.Sports.Soccer.Models;
using TeamSim.Sports.Soccer.Models.StaffFeature;

namespace TeamSim.Soccer.Core.Services.Generators
{
    public class StaffService
    {
        private readonly Random _random = new Random();

        public List<Staff> GenerateStaff(int count)
        {
            var staffList = new List<Staff>();

            for (int i = 0; i < count; i++)
            {
                var personal = new Personal
                {
                    Classification = RandomStringGenerator.GenerateRandomString(10),
                    FirstName = $"FirstName_{_random.Next(1, 1000)}",
                    LastName = $"LastName_{_random.Next(1, 1000)}",
                    DateOfBirth = DateTime.Now.AddYears(-_random.Next(18, 60)),
                    //Nationality = $"Country_{_random.Next(1, 200)}",
                    //CityOfBirth = $"City_{_random.Next(1, 100)}",
                    Weight = _random.Next(60, 100),
                    Height = _random.Next(160, 200)
                };

                // OK
                var mentalTraits = new MentalTraits
                {
                    Adaptability = _random.Next(1, 20),
                    Ambition = _random.Next(1, 20),
                    Determination = _random.Next(1, 20),
                    Loyalty = _random.Next(1, 20),
                    Pressure = _random.Next(1, 20),
                    Professionalism = _random.Next(1, 20),
                    Sportsmanship = _random.Next(1, 20),
                    Temperament = _random.Next(1, 20)
                };

                // OK
                var positions = new Positions
                {
                    Attacker  = _random.Next(1, 20),
                    AttMidfielder  = _random.Next(1, 20),
                    Central   = _random.Next(1, 20),
                    CurrentAbility  = _random.Next(1, 20),
                    CurrentReputation  = _random.Next(1, 20),
                    Defender = _random.Next(1, 20),
                    DefMidfielder  = _random.Next(1, 20),
                    FreeRole  = _random.Next(1, 20),
                    Goalkeeper = _random.Next(1, 20),
                    HomeReputation  = _random.Next(1, 20),
                    LeftSide  = _random.Next(1, 20),
                    MidFielder  = _random.Next(1, 20),
                    PotentialAbility  = _random.Next(1, 20),
                    RightSide  = _random.Next(1, 20),
                    SquadNumber  = _random.Next(1, 20),
                    Sweeper = _random.Next(1, 20),
                    WingBack  = _random.Next(1, 20),
                    WorldReputation = _random.Next(1, 20)
                };

                var contractStaff = new ContractStaff
                {
                    
                };

                var staffConfiguration = new StaffConfiguration
                {

                };


                // OK
                var player = new Player
                {
                    Acceleration = _random.Next(1, 20),
                    Aggression = _random.Next(1, 20),
                    Agility = _random.Next(1, 20),
                    Anticipation = _random.Next(1, 20),
                    Balance = _random.Next(1, 20),
                    Bravery = _random.Next(1, 20),
                    Consistency = _random.Next(1, 20),
                    Corners = _random.Next(1, 20),
                    Crossing = _random.Next(1, 20),
                    Decisions = _random.Next(1, 20),
                    Dirtiness = _random.Next(1, 20),
                    Dribbling = _random.Next(1, 20),
                    Finishing = _random.Next(1, 20),
                    Flair = _random.Next(1, 20),
                    FreeKicks = _random.Next(1, 20),
                    Handling = _random.Next(1, 20),
                    Heading = _random.Next(1, 20),
                    ImportantMatches = _random.Next(1, 20),
                    InjuryProneness = _random.Next(1, 20),
                    Jumping = _random.Next(1, 20),
                    Leadership = _random.Next(1, 20),
                    LeftFoot = _random.Next(1, 20),
                    LongShots = _random.Next(1, 20),
                    Marking = _random.Next(1, 20),
                    Movement = _random.Next(1, 20),
                    NaturalFitness = _random.Next(1, 20),
                    OneOnOnes = _random.Next(1, 20),
                    Pace = _random.Next(1, 20),
                    Passing = _random.Next(1, 20),
                    Penalties = _random.Next(1, 20),
                    Positioning = _random.Next(1, 20),
                    Reflexes = _random.Next(1, 20),
                    RightFoot = _random.Next(1, 20),
                    Stamina = _random.Next(1, 20),
                    Strength = _random.Next(1, 20),
                    Tackling = _random.Next(1, 20),
                    Teamwork = _random.Next(1, 20),
                    Technique = _random.Next(1, 20),
                    ThrowIns = _random.Next(1, 20),
                    Versatility = _random.Next(1, 20),
                    Vision = _random.Next(1, 20),
                    WorkRate = _random.Next(1, 20)
                };

                var history = new List<History>();
                for (int j = 0; j < _random.Next(1, 5); j++)
                {
                    history.Add(new History
                    {
                        Apps = _random.Next(1, 500),
                        Goals = _random.Next(0, 100),
                        Assists = _random.Next(0, 50),
                        Wins = _random.Next(1, 300),
                        AverageRating = (float)(_random.NextDouble() * (10 - 6) + 6) // Random float between 6 and 10
                    });
                }

                var prefs = new Prefs
                {
                    
                };

                var staff = new Staff
                {
                    Id = Guid.NewGuid().ToString(),
                    Personal = personal,
                    MentalTraits = mentalTraits,
                    Positions = positions,
                    ContractStaff = contractStaff,
                    Player = player,
                    History = history,
                    Prefs = prefs
                };

                staffList.Add(staff);
            }

            return staffList;
        }
    }

}


