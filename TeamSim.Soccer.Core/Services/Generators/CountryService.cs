using Newtonsoft.Json;
using TeamSim.Soccer.Contract.Models;

namespace TeamSim.Soccer.Core.Services.Generators
{
    public class CountryService
    {
        private readonly List<Country> _countries;

        public CountryService(string jsonFilePath)
        {
            if (string.IsNullOrEmpty(jsonFilePath))
            {
                throw new ArgumentException("File path cannot be null or empty.", nameof(jsonFilePath));
            }

            if (!File.Exists(jsonFilePath))
            {
                throw new FileNotFoundException($"File not found: {jsonFilePath}");
            }

            string json = File.ReadAllText(jsonFilePath);

            _countries = JsonConvert.DeserializeObject<List<Country>>(json) ?? new List<Country>();
        }

        public List<Country> GetAllCountries()
        {
            return _countries;
        }

        public Country GetCountryByName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            return _countries.Find(country => country.Name.Common.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<Country> GetCountriesByRegion(string region)
        {
            if (string.IsNullOrEmpty(region)) throw new ArgumentException("Region cannot be null or empty.", nameof(region));
            return _countries.FindAll(country => country.Region.Equals(region, StringComparison.OrdinalIgnoreCase));
        }
    }
}
