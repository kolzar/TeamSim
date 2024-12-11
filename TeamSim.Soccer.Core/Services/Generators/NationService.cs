using Bogus;
using TeamSim.Sports.Soccer.Models;
using TeamSim.Sports.Soccer.Models.NationFeature;

namespace TeamSim.Soccer.Core.Services.Generators
{
    public class NationService
    {
        public NationService() { 
        
        }

        public async Task<List<Nation>> GetNationsAsync()
        {
            var RegionFaker = new Faker<Region>();

            var DetailsNationFaker = new Faker<DetailsNation>()
                .RuleFor(c => c.ActualRegion, f => RegionFaker.Generate());

            var StatsNationFaker = new Faker<StatsNation>();

            var CoefficientsNationFaker = new Faker<CoefficientsNation>();
            
            var PrefsNationFaker = new Faker<PrefsNation>();

            var faker = new Faker<Nation>()
                .RuleFor(c => c.DetailsNation, f => DetailsNationFaker.Generate())
                .RuleFor(c => c.StatsNation, f => StatsNationFaker.Generate())
                .RuleFor(c => c.CoefficientsNation, f => CoefficientsNationFaker.Generate())
                .RuleFor(c => c.PrefsNation, f => PrefsNationFaker.Generate());

            var nations = faker.Generate(10);
            return await Task.FromResult(nations);
        }
    }
}
