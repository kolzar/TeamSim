using Bogus;
using TeamSim.Sports.Soccer.Models;
namespace TeamSim.Soccer.Core.Services.Generators
{

    public class ContinentService
    {
        public List<Continent> GenerateContinents(int count)
        {

            var faker = new Faker();
            var continents = new List<Continent>();
            var names = new[] { "Europe", "Asia", "Africa", "North America", "South America", "Oceania" };
            var threeLetterNames = new[] { "EUR", "ASI", "AFR", "NAM", "SAM", "OCE" };
            var federations = new[] { "UEFA", "AFC", "CAF", "CONCACAF", "CONMEBOL", "OFC" };
            var regionalStrengths = new[] { 20, 10, 17, 10, 20, 10
             };

            for (int i = 0; i < count; i++)
            {
                continents.Add(new Continent
                {
                    Name = names[i % names.Length],
                    Description = $"{names[i % names.Length]} is a large landmass.",
                    ThreeLetterName = threeLetterNames[i % threeLetterNames.Length].Substring(0, 3).ToUpper(),
                    NameContinentality = $"Continentality_{i + 1}",
                    FederationName = federations[i % federations.Length],
                    FederationShortName = federations[i % federations.Length].Substring(0, 3).ToUpper(),
                    RegionalStrength = faker.Random.Int(10, 100)
                });
            }

            return continents;
        }
    }

}
