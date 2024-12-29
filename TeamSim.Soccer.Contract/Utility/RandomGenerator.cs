namespace TeamSim.Soccer.Contract.Utility
{
    using System;
    using System.Linq;

    public class RandomStringGenerator
    {
        /// <summary>
        /// Generates the random string.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <returns></returns>
        public static string GenerateRandomString(int length)
        {
            // RandomStringGenerator.GenerateRandomString(10)
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
