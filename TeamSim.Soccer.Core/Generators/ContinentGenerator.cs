using Bogus;
using TeamSim.Sports.Soccer.Models;

namespace TeamSim.Soccer.Core.Generators
{
    public class ContinentGenerator
    {
        public List<Continent> GenerateContinent()
        {
            string[] Continents = {
                "Europe", "South America", "North America", "Asia", "Africa"
            };


            var clubFaker = new Faker<Continent>()
                    .RuleFor(c => c.Name, f => f.Company.CompanyName() + " FC");

            return clubFaker.Generate(5);
        }
    }
}
