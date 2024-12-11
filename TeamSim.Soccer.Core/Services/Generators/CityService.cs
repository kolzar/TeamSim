using Bogus;
using TeamSim.Sports.Soccer.Models;

namespace TeamSim.Soccer.Core.Services.Generators
{
    public class CityService
    {
        public CityService() { 
        
        }
        public async Task<List<City>> GetCitiesAsync()
        {
            // Esempio di utilizzo di Bogus per generare città casuali
            var faker = new Faker<City>()
                .RuleFor(c => c.Name, f => f.Address.City());
                //.RuleFor(c => c.Nation, f => f.Address.Country());

            var cities = faker.Generate(10);
            return await Task.FromResult(cities);
        }
    }
}
