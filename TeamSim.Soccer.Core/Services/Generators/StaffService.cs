using Bogus;
using TeamSim.Sports.Soccer.Models;
using TeamSim.Sports.Soccer.Models.StaffFeature;

namespace TeamSim.Soccer.Core.Services.Generators
{
    internal class StaffService
    {
        public async Task<List<Staff>> GetStaffAsync()
        {
            var PersonalFaker = new Faker<Personal>();
            var ContractStaffFaker = new Faker<ContractStaff> ();
            var MentalTraitsFaker = new Faker<MentalTraits> ();
            var PrefsFaker = new Faker<Prefs> ();
            var PositionsFaker = new Faker<Positions> ();
            var PlayerFaker = new Faker<Player> ();
            var HistoryFaker = new Faker<List<History>> ();

            var faker = new Faker<Staff>()
                .RuleFor(c => c.Personal, f => PersonalFaker.Generate())
                .RuleFor(c => c.ContractStaff, f => ContractStaffFaker.Generate())
                .RuleFor(c => c.MentalTraits, f => MentalTraitsFaker.Generate())
                .RuleFor(c => c.Prefs, f => PrefsFaker.Generate())
                .RuleFor(c => c.Positions, f => PositionsFaker.Generate())
                .RuleFor(c => c.Player, f => PlayerFaker.Generate())
                .RuleFor(c => c.History, f => HistoryFaker.Generate());

            var list = faker.Generate(10);
            return await Task.FromResult(list);
        }
    }
}
