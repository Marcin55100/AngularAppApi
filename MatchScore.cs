namespace AngularAppApi
{
    public class MatchScore
    {
        public MatchScore(string homeTeam, int homeScore, string awayTeam, int awayScore)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeScore = homeScore;
            AwayScore = awayScore;
        }

        public string HomeTeam { get; set; }
        public int HomeScore { get; set; }
        public string AwayTeam { get; set; }
        public int AwayScore { get; set; }
    }
}
