namespace TeamSim.Sports.Soccer.Models
{
    public class Team
    {
        public string id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string country { get; set; }
        public string type { get; set; }
        public string leagueId { get; set; }
        public string countryId { get; set; }
        public string playerCount { get; set; }
        public string transferBudget { get; set; }
        public string intPrestige { get; set; }
        public string domPrestige { get; set; }
        public string popularity { get; set; }
        public string youthDevelopment { get; set; }
        public string clubWorth { get; set; }
        public string opponentWeakThreshold { get; set; }
        public string opponentStrongThreshold { get; set; }
        public string stadiumId { get; set; }
        public string rivalTeamId { get; set; }
        public string xiAverageAge { get; set; }
        public string totalAverageAge { get; set; }
        public string overallRating { get; set; }
        public string attackRating { get; set; }
        public string midfieldRating { get; set; }
        public string defenseRating { get; set; }
        public string trait1 { get; set; }
        public string profitability { get; set; }
        public string busBuildUpSpeed { get; set; }
        public string busPassing { get; set; }
        public string busDribbling { get; set; }
        public string busPositioning { get; set; }
        public string ccCrossing { get; set; }
        public string ccPassing { get; set; }
        public string ccPositioning { get; set; }
        public string ccShooting { get; set; }
        public string defAggression { get; set; }
        public string defDefenderLine { get; set; }
        public string defTeamWidth { get; set; }
        public string defMentality { get; set; }
        public string defensiveStyle { get; set; }
        public string defensiveWidth { get; set; }
        public string defensiveDepth { get; set; }
        public string offensiveStyle { get; set; }
        public string offensiveWidth { get; set; }
        public string playersInBoxCross { get; set; }
        public string playersInBoxCorner { get; set; }
        public string playersInBoxFreeKick { get; set; }
        public string buildUpPlay { get; set; }
        public string chanceCreation { get; set; }
        public string roster { get; set; }
        public string version { get; set; }
        public string export { get; set; }
        public string latestRoster { get; set; }
        public List<Player> players { get; set; }   
    }
}